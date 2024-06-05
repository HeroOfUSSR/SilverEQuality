using SilverEQuality.MessageBoxes;
using SilverEQuality_Context;
using SilverEQuality_Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverEQuality.Forms
{
    public partial class MaterialRequestForm : Form
    {
        private SilverRequest editRequest;
        public bool isMouseDown;
        public Point startPoint;
        public MaterialRequestForm()
        {
            InitializeComponent();

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                comboBoxPrio.DisplayMember = nameof(Priority.TitlePriority);
                comboBoxPrio.ValueMember = nameof(Priority.IdPriority);
                comboBoxStatus.DisplayMember = nameof(Status.TitleStatus);
                comboBoxStatus.ValueMember = nameof(Status.IdStatus);
                comboBoxSilver.DisplayMember = nameof(SilverType.TitleSilverType);
                comboBoxSilver.ValueMember = nameof(SilverType.CodeSilverType);

                comboBoxSilver.Items.AddRange(db.SilverTypes.ToArray());
                comboBoxStatus.Items.AddRange(db.Statuses.ToArray());
                comboBoxPrio.Items.AddRange(db.Priorities.ToArray());

                comboBoxSilver.SelectedValue = 0;
                comboBoxStatus.SelectedValue = 0;
                comboBoxPrio.SelectedValue = 0;
            }
        }

        public MaterialRequestForm(SilverType silverType) : this()
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var index = comboBoxSilver.FindString(silverType.TitleSilverType);

                comboBoxSilver.SelectedIndex = index;
            }
        }

        public MaterialRequestForm(SilverRequest silverRequest) : this()
        {
            buttonDone.Text = "Редактировать";
            labelTitle.Text = $"Редактирование запроса №{silverRequest.IdRequest}";


            var index = comboBoxStatus.FindString(silverRequest.StatusRequestNavigation.TitleStatus.ToString());

            comboBoxStatus.SelectedIndex = index;

            if (silverRequest.PriorityRequest != null)
            {
                index = comboBoxPrio.FindString(silverRequest.PriorityRequestNavigation.TitlePriority.ToString());

                comboBoxPrio.SelectedIndex = index;
            }
            if (silverRequest.CostRequest != null)
            {
                textBoxPayment.Text = silverRequest.CostRequest.ToString();
            }

            textBoxDesc.Text = silverRequest.DescRequest;
            numericUpDownAmount.Value = silverRequest.AmountRequest;


            editRequest = silverRequest;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                if (numericUpDownAmount.Value <= 0) return; // Валидацией займись

                string paymentRequest;
                if (textBoxPayment.Text == "")
                {
                    paymentRequest = null;
                }
                else
                {
                    paymentRequest = textBoxPayment.Text;
                }

                int statusRequest;
                if (comboBoxStatus.SelectedItem != null)
                {
                    statusRequest = ((Status)comboBoxStatus.SelectedItem).IdStatus;
                }
                else
                {
                    statusRequest = 1;
                }


                if (buttonDone.Text == "Редактировать")
                {
                    editRequest.StatusRequest = statusRequest;
                    editRequest.PriorityRequest = ((Priority)comboBoxPrio.SelectedItem).IdPriority;
                    editRequest.SilverTypeRequest = ((SilverType)comboBoxSilver.SelectedItem).CodeSilverType;
                    editRequest.AmountRequest = Convert.ToInt32(numericUpDownAmount.Value);
                    editRequest.DescRequest = textBoxDesc.Text;

                    editRequest.CostRequest = Convert.ToDecimal(paymentRequest);
                    editRequest.DateEndRequest = dateTimePickerEnd.Value;

                    db.SilverRequests.Update(editRequest);
                    db.SaveChanges();

                    CustomMessageBox successEdit = new CustomMessageBox("Запрос изменён", false);
                    successEdit.ShowDialog();

                }
                else
                {
                    SilverRequest newRequest = new SilverRequest
                    {
                        StatusRequest = statusRequest,
                        PriorityRequest = ((Priority)comboBoxPrio.SelectedItem).IdPriority,
                        SilverTypeRequest = ((SilverType)comboBoxSilver.SelectedItem).CodeSilverType,
                        UserRequest = AuthForm.authorizedUser.IdUser,
                        AmountRequest = Convert.ToInt32(numericUpDownAmount.Value),
                        DescRequest = textBoxDesc.Text,
                        CostRequest = Convert.ToDecimal(paymentRequest),
                        DateEndRequest = dateTimePickerEnd.Value,
                        DateRequest = DateTime.Now,

                    };

                    db.SilverRequests.Add(newRequest);
                    db.SaveChanges();

                    CustomMessageBox successAdd = new CustomMessageBox("Запрос создан", false);
                    successAdd.ShowDialog();
                }
            }
        }
    }
}
