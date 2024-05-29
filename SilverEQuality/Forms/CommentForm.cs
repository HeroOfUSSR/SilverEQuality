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

namespace SilverEQuality.Forms
{
    public partial class CommentForm : Form
    {
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

                CustomMessageBox successComment = new CustomMessageBox("Комментарий добавлен", false);
                successComment.ShowDialog();

            }
        }

        private void SendEmail(string messageTest)
        {
            string smtpServer = "smtp.mail.ru";
            int smtpPort = 587;
            string smtpUsername = "alexey_ivanov04@mail.ru";
        }
    }
}
