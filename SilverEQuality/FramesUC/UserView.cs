using SilverEQuality.Forms;
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

namespace SilverEQuality.FramesUC
{
    public partial class UserView : UserControl
    {
        private User userView;
        public UserView(User user)
        {
            InitializeComponent();
            userView = user;
            InitView(userView);
        }

        private void InitView(User user)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                labelDateBirth.Text = user.DateOfBirthUser.ToString("D");
                if (user.AvailableUser == true)
                {
                    textBoxFullname.Text = user.FullnameUser;
                }
                else
                {
                    textBoxFullname.ForeColor = Color.DarkRed;
                    textBoxFullname.Text = $"{user.FullnameUser} | Пользователь отключён";

                }

                textBoxMail.Text = user.EmailUser;
                textBoxPhone.Text = user.PhoneUser;

                labelRole.Text = db.Roles.FirstOrDefault(x => x.IdRole == user.RoleUser).TitleRole;


                if (user.AvatarUser != null)
                {
                    pictureBoxAuthor.Image = Image.FromStream(new MemoryStream(user.AvatarUser));
                }
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CustomMessageBox areYouSure = new CustomMessageBox("Вы уверены что хотите удалить пользователя?", true);
            areYouSure.ShowDialog();

            if (areYouSure.DialogResult == DialogResult.OK)
            {
                var confirmAdmin = new ChangeProfileData(userView, 2);
                confirmAdmin.ShowDialog();

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var editChelik = new CreateUserForm(userView);
            editChelik.ShowDialog();
        }
    }
}
