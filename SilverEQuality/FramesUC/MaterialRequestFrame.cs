using Microsoft.EntityFrameworkCore;
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

namespace SilverEQuality.FramesUC
{
    public partial class MaterialRequestFrame : UserControl
    {
        public MaterialRequestFrame()
        {
            InitializeComponent();
            InitFlow();
        }

        private void InitFlow()
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var reqs = db.SilverRequests.OrderByDescending(x => x.IdRequest)
                    .Include(x => x.StatusRequestNavigation)
                    .Include(x => x.PriorityRequestNavigation).ToList();

                foreach (var req in reqs)
                {
                    var reqView = new RequestView(req);
                    reqView.Parent = flowLayoutPanelRequests;
                }
            }
        }

        private void MaterialRequestFrame_Load(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                comboBoxSilverType.DisplayMember = nameof(SilverType.TitleSilverType);
                comboBoxSilverType.ValueMember = nameof(SilverType.CodeSilverType);
                comboBoxPriority.DisplayMember = nameof(Priority.TitlePriority);
                comboBoxPriority.ValueMember = nameof(Priority.IdPriority);
                comboBoxStatus.DisplayMember = nameof(Status.TitleStatus);
                comboBoxStatus.ValueMember = nameof(Status.IdStatus);
                comboBoxSortDate.DisplayMember = "Text";
                comboBoxSortDate.ValueMember = "Value";

                comboBoxSilverType.Items.AddRange(db.SilverTypes.ToArray());
                comboBoxPriority.Items.AddRange(db.Priorities.ToArray());
                comboBoxStatus.Items.AddRange(db.Statuses.ToArray());

                comboBoxSortDate.Items.Add(new { Text = "Самые новые", Value = 0 });
                comboBoxSortDate.Items.Add(new { Text = "Самые старые", Value = 1 });

                comboBoxSilverType.Items.Insert(0, new SilverType
                {
                    CodeSilverType = 0,
                    TitleSilverType = "Все виды серебра"
                });
                comboBoxPriority.Items.Insert(0, new Priority
                {
                    IdPriority = 0,
                    TitlePriority = "Все приоритеты"
                });
                comboBoxStatus.Items.Insert(0, new Status
                {
                    IdStatus = 0,
                    TitleStatus = "Все статусы"
                });

                comboBoxStatus.SelectedIndex = 0;
                comboBoxSortDate.SelectedIndex = 0;
                comboBoxPriority.SelectedIndex = 0;
                comboBoxSilverType.SelectedIndex = 0;
            }

        }

        private void Filter()
        {
            if (comboBoxSilverType.SelectedItem == null
                || comboBoxPriority.SelectedItem == null
                || comboBoxStatus.SelectedItem == null)
                return;

            var selectedType = ((SilverType)comboBoxSilverType.SelectedItem).CodeSilverType;
            var selectedStatus = ((Status)comboBoxStatus.SelectedItem).IdStatus;
            var selectedPriority = ((Priority)comboBoxPriority.SelectedItem).IdPriority;

            foreach (var item in flowLayoutPanelRequests.Controls)
            {
                var visible = true;
                if (item is RequestView requestView)
                {
                    if (selectedType != 0 &&
                        !(requestView.silverReqView.SilverTypeRequest == selectedType))
                    {
                        visible = false;
                    }

                    if (selectedStatus != 0 &&
                        !(requestView.silverReqView.StatusRequest == selectedStatus))
                    {
                        visible = false;
                    }

                    if (selectedPriority != 0 &&
                        !(requestView.silverReqView.PriorityRequest == selectedPriority))
                    {
                        visible = false;
                    }

                    if (!(string.IsNullOrEmpty(textBoxSearch.Text) ||
                        requestView.silverReqView.IdRequest.ToString().Contains(textBoxSearch.Text)))
                    {
                        visible = false;
                    }

                    requestView.Visible = visible;
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
