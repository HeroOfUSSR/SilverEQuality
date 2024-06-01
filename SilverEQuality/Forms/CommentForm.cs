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
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverEQuality.Forms
{
    public partial class CommentForm : Form
    {
        public bool isMouseDown;
        public Point startPoint;

        private Order commentOrder;
        public CommentForm(Order order)
        {
            InitializeComponent();
            textBoxComment.MaxLength = 100;
            labelSymbolsLeft.Parent = textBoxComment;
            InitFlow(order);
            commentOrder = order;

        }

        private void InitFlow(Order order)
        {
            flowLayoutPanelComments.Controls.Clear();

            using (var db = new SilverEQContext(DBHelper.Option()))
            {

                var comments = db.Comments.Where(x => x.OrderComment == order.IdOrder).OrderByDescending(x => x.DateComment).ToList();
                if (comments != null)
                {
                    foreach (var comment in comments)
                    {
                        CommentView commentView = new CommentView(comment);
                        commentView.Parent = flowLayoutPanelComments;
                    }
                }
                else
                {
                    CustomMessageBox noEntries = new CustomMessageBox("Комментарии не найдены", false);
                    noEntries.ShowDialog();
                }

            }
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            labelSymbolsLeft.Text = (textBoxComment.MaxLength - textBoxComment.Text.Length).ToString();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                Comment newComment = new Comment
                {
                    TextComment = textBoxComment.Text,
                    UserComment = AuthForm.authorizedUser.IdUser,
                    DateComment = DateTime.Now,
                    OrderComment = commentOrder.IdOrder,
                };

                db.Comments.Add(newComment);
                db.SaveChanges();

                if (checkBoxSendEmail.Checked == true)
                {
                    SendEmail();
                }
                else
                {
                    CustomMessageBox successComment = new CustomMessageBox("Комментарий добавлен", false);
                    successComment.ShowDialog();
                }
            }
        }

        private void SendEmail()
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var recipients = db.Users.Where(x => x.RoleUser == 3).ToList();

                foreach (var recipient in recipients)
                {
                    if (recipient.AvailableUser == true)
                    {
                        string smtpServer = "smtp.mail.ru";
                        int smtpPort = 587;
                        string smtpUsername = "arhangel19960530@mail.ru";
                        string smtpPassword = "8kuupgQFpGjKF2XwbbPs";

                        using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
                        {
                            smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                            smtpClient.EnableSsl = true;

                            using (MailMessage mailMessage = new MailMessage())
                            {
                                mailMessage.From = new MailAddress(smtpUsername, "SilverEQualityAPP");


                                mailMessage.To.Add(recipient.EmailUser);
                                mailMessage.Subject = $"Комментарий по заказу №{commentOrder.IdOrder}";
                                mailMessage.Body = textBoxComment.Text;

                                try
                                {
                                    smtpClient.Send(mailMessage);
                                }
                                catch (Exception ex)
                                {
                                    CustomMessageBox errorMail = new CustomMessageBox("Ошибка отправки сообщения", false);
                                }
                            }
                        }

                    }
                }
            }
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
