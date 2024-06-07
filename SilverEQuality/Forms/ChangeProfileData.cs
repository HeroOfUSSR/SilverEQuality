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
using System.Windows.Forms.VisualStyles;

namespace SilverEQuality.Forms
{
    public partial class ChangeProfileData : Form
    {
        public bool isMouseDown;
        public Point startPoint;

        private User workOnUser;

        private int optionProfile;
        private int optionAdmin;

        public ChangeProfileData()
        {
            InitializeComponent();

        }

        public ChangeProfileData(int option) : this()
        {
            optionProfile = option;
            InitDataEditor();
        }


        public ChangeProfileData(User user, int optionAdmin) : this()
        {
            optionProfile = 2;
            this.optionAdmin = optionAdmin;
            workOnUser = user;
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

                    this.Size = MaximumSize;

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

                    textBoxCurrent.UseSystemPasswordChar = true;
                    textBoxNew.UseSystemPasswordChar = true;
                    textBoxRepeat.UseSystemPasswordChar = true;

                    this.Size = MinimumSize;

                    labelTitle.Text = "Смена пароля";
                    labelCurrent.Text = "Текущий пароль";
                    labelNew.Text = "Новый пароль";
                    labelRepeat.Text = "Повторите пароль";

                    textBoxCurrent.ReadOnly = false;

                    break;
                case 2:

                    this.Size = MinimumSize;

                    labelTitle.Text = "Подтвердите права";
                    labelCurrent.Visible = false;
                    textBoxCurrent.Visible = false;
                    labelNew.Text = "Пароль админа";
                    textBoxNew.UseSystemPasswordChar = true;
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
                            labelNew.ForeColor = Color.Red;
                            textBoxRepeat.ForeColor = Color.Red;
                            labelRepeat.ForeColor = Color.Red;

                        }

                        break;
                    case 1:

                        if (MD5Encryptor.HashPassword(textBoxCurrent.Text) == AuthForm.authorizedUser.PasswordUser)
                        {
                            if (textBoxNew.Text == textBoxRepeat.Text && textBoxNew.Text != "")
                            {
                                AuthForm.authorizedUser.PasswordUser = MD5Encryptor.HashPassword(textBoxNew.Text);

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
                                labelNew.ForeColor = Color.Red;
                                labelRepeat.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            textBoxCurrent.ForeColor = Color.Red;
                            labelCurrent.ForeColor = Color.Red;
                        }

                        break;
                    case 2:

                        if (db.Users.FirstOrDefault(x => x.PasswordUser == MD5Encryptor.HashPassword(textBoxNew.Text) 
                            && x.IdUser == AuthForm.authorizedUser.IdUser) != null)
                        {
                            switch (optionAdmin)
                            {
                                case 0:
                                    db.Users.Add(workOnUser);
                                    db.SaveChanges();

                                    CustomMessageBox successAdd = new CustomMessageBox("Пользователь добавлен", false);
                                    successAdd.ShowDialog();
                                    break;
                                case 1:
                                    db.Users.Update(workOnUser);
                                    db.SaveChanges();

                                    CustomMessageBox successEdit = new CustomMessageBox("Успешное изменение", false);
                                    successEdit.ShowDialog();
                                    break;
                                case 2:
                                    db.Users.Remove(workOnUser);
                                    db.SaveChanges();

                                    CustomMessageBox successDelete = new CustomMessageBox("Пользователь удалён", false);
                                    successDelete.ShowDialog();
                                    break;
                            }
                            

                            
                            this.Close();
                        }
                        else
                        {
                            textBoxNew.ForeColor = Color.Red;
                            labelNew.ForeColor = Color.Red;
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
            labelCurrent.ForeColor = Color.Black;
        }

        private void textBoxNew_Enter(object sender, EventArgs e)
        {
            textBoxNew.ForeColor = Color.Black;
            labelNew.ForeColor = Color.Black;
        }

        private void textBoxRepeat_Enter(object sender, EventArgs e)
        {
            textBoxRepeat.ForeColor = Color.Black;
            labelRepeat.ForeColor = Color.Black;

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
