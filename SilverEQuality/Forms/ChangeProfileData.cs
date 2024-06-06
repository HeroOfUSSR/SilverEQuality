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
    public partial class ChangeProfileData : Form
    {
        public bool isMouseDown;
        public Point startPoint;

        private User deleteUser;

        private int optionProfile;
        public ChangeProfileData()
        {
            InitializeComponent();

        }

        public ChangeProfileData(int option) : this()
        {
            optionProfile = option;
            InitDataEditor();
        }


        public ChangeProfileData(User user) : this()
        {
            optionProfile = 2;
            deleteUser = user;
            InitDataEditor();
        }

        private void InitDataEditor()
        {
            switch (optionProfile)
            {
                case 0:

                    labelTitle.Text = "Смена почты";
                    labelCurrent.Text = "Текущая почта";
                    labelNew.Text = "Новая почта";
                    labelRepeat.Text = "Повторите почту";

                    if (AuthForm.authorizedUser.EmailUser != null)
                    {
                        textBoxCurrent.Text = AuthForm.authorizedUser.EmailUser;
                    }
                    else
                    {
                        textBoxCurrent.Text = "Отсутствует";
                    }

                    break;
                case 1:

                    labelTitle.Text = "Смена пароля";
                    labelCurrent.Text = "Текущий пароль";
                    labelNew.Text = "Новый пароль";
                    labelRepeat.Text = "Повторите пароль";

                    textBoxCurrent.ReadOnly = false;

                    break;
                case 2:

                    labelTitle.Text = "Подтвердите права";
                    labelCurrent.Visible = false;
                    textBoxCurrent.Visible = false;
                    labelNew.Text = "Пароль админа";
                    labelRepeat.Visible = false;
                    textBoxRepeat.Visible = false;

                    break;
                default:
                    break;
            }


        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                switch (optionProfile)
                {
                    case 0:

                        if (textBoxNew.Text == textBoxRepeat.Text && textBoxNew.Text != "")
                        {
                            AuthForm.authorizedUser.EmailUser = textBoxNew.Text;

                            db.Users.Update(AuthForm.authorizedUser);
                            db.SaveChanges();

                            CustomMessageBox successChange = new CustomMessageBox("Почта успешно изменена", false);
                            successChange.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            textBoxNew.ForeColor = Color.Red;
                            textBoxRepeat.ForeColor = Color.Red;
                        }

                        break;
                    case 1:

                        if (textBoxCurrent.Text == AuthForm.authorizedUser.PasswordUser)
                        {
                            if (textBoxNew.Text == textBoxRepeat.Text && textBoxNew.Text != "")
                            {
                                AuthForm.authorizedUser.PasswordUser = textBoxNew.Text;

                                db.Users.Update(AuthForm.authorizedUser);
                                db.SaveChanges();

                                CustomMessageBox successChange = new CustomMessageBox("Пароль успешно изменён", false);
                                successChange.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                textBoxNew.ForeColor = Color.Red;
                                textBoxRepeat.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            textBoxCurrent.ForeColor = Color.Red;
                        }

                        break;
                    case 2:

                        if (db.Users.FirstOrDefault(x => x.PasswordUser == textBoxNew.Text && x.RoleUser == 1) != null)
                        {
                            db.Users.Remove(deleteUser);
                            db.SaveChanges();
                        }
                        else
                        {
                            textBoxNew.ForeColor = Color.Red;
                        }

                        break;
                    default:
                        break;
                }
            }

        }

        private void textBoxCurrent_Enter(object sender, EventArgs e)
        {
            textBoxCurrent.ForeColor = Color.Black;
        }

        private void textBoxNew_Enter(object sender, EventArgs e)
        {
            textBoxNew.ForeColor = Color.Black;
        }

        private void textBoxRepeat_Enter(object sender, EventArgs e)
        {
            textBoxRepeat.ForeColor = Color.Black;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
