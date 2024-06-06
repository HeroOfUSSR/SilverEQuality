﻿using SilverEQuality_Context;
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
    public partial class RequestView : UserControl
    {
        public RequestView(SilverRequest silverRequest)
        {
            InitializeComponent();
            InitView(silverRequest);
        }

        private void InitView(SilverRequest silverRequest)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                labelRequestTitle.Text = $"Запрос №{silverRequest.IdRequest}";
                textBoxDescReq.Text = silverRequest.DescRequest;
                labelDateReq.Text = silverRequest.DateRequest.ToString("D");
                labelAmount.Text = $"{silverRequest.AmountRequest} кг";

                var author = db.Users.FirstOrDefault(x => x.IdUser == silverRequest.UserRequest);

                if (author.AvatarUser != null)
                {
                    pictureBoxUser.Image = Image.FromStream(new MemoryStream(author.AvatarUser));
                }

                string[] initials = author.FullnameUser.Split(' ');
                labelUserName.Text = initials[0] + " " + initials[1][0] + "." + initials[2][0] + ".";

            }
        }
    }
}