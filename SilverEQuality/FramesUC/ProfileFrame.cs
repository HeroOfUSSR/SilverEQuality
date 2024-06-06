using Microsoft.EntityFrameworkCore;
using SilverEQuality.Forms;
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
    public partial class ProfileFrame : UserControl
    {
        private User currentUser;
        private int buttonPressed;
        public ProfileFrame()
        {
            InitializeComponent();

            currentUser = AuthForm.authorizedUser;

            if (currentUser.AvatarUser != null)
                pictureBoxAvatar.Image = Image.FromStream(new MemoryStream(currentUser.AvatarUser));
            labelName.Text = currentUser.FullnameUser;
            labelDate.Text = currentUser.DateOfBirthUser.ToString("d MMMM yyyy");

            if (currentUser.RoleUser != 1)
            {
                buttonUsers.Visible = false;
            }
        }

        private void buttonChangeAv_Click(object sender, EventArgs e)
        {
            if (openFileDialogChangeAv.ShowDialog() != DialogResult.OK) return;
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var newAvatar = File.ReadAllBytes(openFileDialogChangeAv.FileName);

                currentUser.AvatarUser = newAvatar;

                db.Users.Update(currentUser);
                db.SaveChanges();

                pictureBoxAvatar.Image = Image.FromStream(new MemoryStream(newAvatar));
            }

        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            buttonOrders.BackColor = Color.White;
            buttonOrders.ForeColor = Color.SteelBlue;
            buttonPressed = 1;
            InitFlowView(buttonPressed);
            buttonComment.BackColor = Color.SteelBlue;
            buttonComment.ForeColor = Color.White;
            buttonUsers.BackColor = Color.SteelBlue;
            buttonUsers.ForeColor = Color.White;
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            buttonComment.BackColor = Color.White;
            buttonComment.ForeColor = Color.SteelBlue;
            buttonPressed = 2;
            InitFlowView(buttonPressed);
            buttonOrders.BackColor = Color.SteelBlue;
            buttonOrders.ForeColor = Color.White;
            buttonUsers.BackColor = Color.SteelBlue;
            buttonUsers.ForeColor = Color.White;
        }

        private void InitFlowView(int buttonNumber)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                flowLayoutPanelBody.Controls.Clear();

                switch (buttonNumber)
                {
                    case 1:

                        var orders = db.Orders.Where(x => x.AppointedOrder == AuthForm.authorizedUser.IdUser)
                            .Include(x => x.ManufacturerOrderNavigation).ToList();

                        foreach (var order in orders)
                        {
                            var orderView = new OrderView(order);

                            if (MainForm.isMenuExpanded)
                            {
                                orderView.Width = orderView.MinimumSize.Width;
                            }
                            else if (!MainForm.isMenuExpanded)
                            {
                                orderView.Width = MinimumSize.Width - 20;
                            }

                            orderView = new OrderView(order);
                            orderView.Parent = flowLayoutPanelBody;
                            // Ивент добавить сюда
                        }

                        break;
                    case 2:

                        var comments = db.Comments
                            .Where(x => x.OrderCommentNavigation.AppointedOrder == AuthForm.authorizedUser.IdUser).ToList();

                        foreach (var comment in comments)
                        {
                            var commentView = new CommentView(comment);
                            commentView.Parent = flowLayoutPanelBody;
                        }

                        break;
                    case 3:

                        var users = db.Users.Include(x => x.RoleUserNavigation).ToList();

                        foreach (var user in users)
                        {
                            var userView = new UserView(user);
                            userView.Parent = flowLayoutPanelBody;
                        }

                        break;
                    default:
                        break;
                }
            }
        }

        private void ProfileFrame_Resize(object sender, EventArgs e)
        {
            if (this.Size == MinimumSize || this.Size == MaximumSize)
            {
                InitFlowView(buttonPressed);
            }
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            var changeEmail = new ChangeProfileData(0);
            changeEmail.ShowDialog();
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            var changeEmail = new ChangeProfileData(1);
            changeEmail.ShowDialog();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            buttonUsers.BackColor = Color.White;
            buttonUsers.ForeColor = Color.SteelBlue;
            buttonPressed = 3;
            InitFlowView(buttonPressed);
            buttonComment.BackColor = Color.SteelBlue;
            buttonComment.ForeColor = Color.White;
            buttonOrders.BackColor = Color.SteelBlue;
            buttonOrders.ForeColor = Color.White;
        }
    }
}
