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
    public partial class CommentView : UserControl
    {
        public CommentView(Comment comment)
        {
            InitializeComponent();
            InitView(comment);
        }

        private void InitView(Comment comment)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                labelCommentTitle.Text = $"Комментарий к заказу №{comment.OrderComment}";
                textBoxComment.Text = comment.TextComment;
                labelDateCom.Text = comment.DateComment.ToString("D");

                var author = db.Users.FirstOrDefault(x => x.IdUser == comment.UserComment);

                if (author.AvatarUser != null)
                {
                    pictureBoxAuthor.Image = Image.FromStream(new MemoryStream(author.AvatarUser));
                }

                string[] initials = author.FullnameUser.Split(' ');
                labelAuthorName.Text = initials[0] + " " + initials[1][0] + "." + initials[2][0] + ".";

            }
        }

        private void CommentView_Load(object sender, EventArgs e)
        {
        }
    }
}
