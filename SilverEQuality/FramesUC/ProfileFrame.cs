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
                buttonCreateUser.Visible = false;
            }

            if (currentUser.RoleUser == 3) 
            {
                buttonOrders.Visible = false;
                buttonComment.Visible = false;
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
                                orderView.Width = MinimumSize.Width - 30;
                            }

                            orderView = new OrderView(order);
                            orderView.Parent = flowLayoutPanelBody;
                            // Ивент добавить сюда
                        }

                        break;
                    case 2:

                        var comments = db.Comments.OrderByDescending(x => x.IdComment).Include(x => x.OrderCommentNavigation).ToList();

                        if (AuthForm.authorizedUser.RoleUser != 1)
                        {
                            comments = comments.Where(x => x.OrderCommentNavigation.AppointedOrder == AuthForm.authorizedUser.IdUser).ToList();
                        }

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

                            userView.refreshProfile += UserView_refreshProfile;
                        }

                        break;
                    default:
                        break;
                }
            }
        }

        private void UserView_refreshProfile(bool toRefresh)
        {
            if (toRefresh)
            {
                InitFlowView(buttonPressed);
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
            InitFlowView(buttonPressed);
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            var changeEmail = new ChangeProfileData(1);
            changeEmail.ShowDialog();
            InitFlowView(buttonPressed);

        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            var createUser = new CreateUserForm();
            createUser.ShowDialog();
            InitFlowView(buttonPressed);

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
