using Microsoft.VisualBasic.ApplicationServices;
using SilverEQuality.FramesUC;
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
using User = SilverEQuality_Context.Models.User;

namespace SilverEQuality.Forms
{
    public partial class CreateUserForm : Form
    {
        public bool isMouseDown;
        public Point startPoint;

        private User editUser;
        private User createUser = new User();
        public CreateUserForm()
        {
            InitializeComponent();

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                comboBoxDepartment.DataSource = db.Departments.Where(x => x.IsAtWorkDepartment == true).ToList();
                comboBoxRoles.DataSource = db.Roles.ToList();


                comboBoxDepartment.DisplayMember = nameof(Department.CodeDepartment);
                comboBoxDepartment.ValueMember = nameof(Department.CodeDepartment);
                comboBoxRoles.DisplayMember = nameof(Role.TitleRole);
                comboBoxRoles.ValueMember = nameof(Role.IdRole);

                comboBoxRoles.SelectedValue = 0;
                comboBoxDepartment.SelectedValue = 0;
            }

        }

        public CreateUserForm(User user) : this()
        {
            Text = "Изменение пользователя";
            buttonDone.Text = "Редактировать";
            if (user.LoginUser != null) textBoxLogin.Text = user.LoginUser;
            //if (user.PasswordUser != null) textBoxPassword.Text = user.PasswordUser;
            if (user.EmailUser != null) textBoxMail.Text = user.EmailUser;
            textBoxFullname.Text = user.FullnameUser;
            maskedTextBoxNumber.Text = user.PhoneUser.Remove(0,1);
            dateTimePickerBirth.Value = user.DateOfBirthUser;

            var index = comboBoxRoles.FindString(user.RoleUserNavigation.TitleRole.ToString());

            comboBoxRoles.SelectedIndex = index;

            if (user.DepartmentUser != null)
            {
                index = comboBoxDepartment.FindString(user.DepartmentUser.ToString());
            }

            comboBoxDepartment.SelectedIndex = index;

            if (user.AvailableUser)
            {
                checkBoxAvailable.Checked = true;
            }
            else
            {
                checkBoxAvailable.Checked = false;
            }

            editUser = user;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                string phoneNumber = new string(maskedTextBoxNumber.Text.Where(t => char.IsDigit(t)).ToArray());

                if (buttonDone.Text == "Редактировать")
                {

                    if (textBoxFullname.Text == "" || maskedTextBoxNumber.Text == "" || comboBoxDepartment.SelectedIndex == 0)
                    {
                        CustomMessageBox errorAdding = new CustomMessageBox("Заполните все поля со звёздочкой", false);
                        errorAdding.ShowDialog();
                        return;
                    }

                    editUser.FullnameUser = textBoxFullname.Text;
                    editUser.PhoneUser = $"8{maskedTextBoxNumber.Text}";//textBoxPhone.Text;
                    editUser.DateOfBirthUser = dateTimePickerBirth.Value;
                    editUser.LoginUser = textBoxLogin.Text;

                    if (textBoxPassword.Text != "" && textBoxPassword.Text != null)
                    {
                        editUser.PasswordUser = MD5Encryptor.HashPassword(textBoxPassword.Text);
                    }
                    editUser.EmailUser = textBoxMail.Text;
                    editUser.DepartmentUser = ((Department)comboBoxDepartment.SelectedItem).CodeDepartment;
                    editUser.RoleUser = ((Role)comboBoxRoles.SelectedItem).IdRole;


                    if (checkBoxAvailable.Checked)
                    {
                        editUser.AvailableUser = true;
                    }
                    else
                    {
                        editUser.AvailableUser = false;
                    }


                    var confirmAdmin = new ChangeProfileData(editUser, 1);
                    confirmAdmin.ShowDialog();

                    
                }
                else
                {
                    if (textBoxFullname.Text == "" || phoneNumber == "" || comboBoxDepartment.SelectedIndex == 0)
                    {
                        CustomMessageBox errorAdding = new CustomMessageBox("Заполните все поля со звёздочкой", false);
                        errorAdding.ShowDialog();
                        return;
                    }

                    createUser.FullnameUser = textBoxFullname.Text;
                    createUser.PhoneUser = $"8{phoneNumber}"; ;
                    createUser.DateOfBirthUser = dateTimePickerBirth.Value;
                    createUser.LoginUser = textBoxLogin.Text;
                    if (textBoxPassword.Text != "")
                    {
                        createUser.PasswordUser = MD5Encryptor.HashPassword(textBoxPassword.Text);
                    }
                    else
                    {
                        createUser.PasswordUser = null;
                    }
                    createUser.EmailUser = textBoxMail.Text;

                    createUser.DepartmentUser = ((Department)comboBoxDepartment.SelectedItem).CodeDepartment;
                    createUser.RoleUser = ((Role)comboBoxRoles.SelectedItem).IdRole;


                    if (checkBoxAvailable.Checked)
                    {
                        createUser.AvailableUser = true;
                    }
                    else
                    {
                        createUser.AvailableUser = false;
                    }

                    var confirmAdmin = new ChangeProfileData(createUser, 0);
                    confirmAdmin.ShowDialog();

                }

                this.Close();
            }

        }

        private void buttonChangeAv_Click(object sender, EventArgs e)
        {
            if (openFileDialogChangeAv.ShowDialog() != DialogResult.OK) return;

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var newAvatar = File.ReadAllBytes(openFileDialogChangeAv.FileName);

                if (buttonDone.Text == "Редактировать")
                {
                    editUser.AvatarUser = newAvatar;
                }
                else
                {
                    createUser.AvatarUser = newAvatar;
                }

                pictureBoxAvatar.Image = Image.FromStream(new MemoryStream(newAvatar));
            }
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
