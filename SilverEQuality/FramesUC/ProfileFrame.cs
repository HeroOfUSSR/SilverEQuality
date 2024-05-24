﻿using SilverEQuality_Context.Models;
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
        public ProfileFrame()
        {
            InitializeComponent();

            currentUser = AuthForm.authorizedUser;

            if (currentUser.AvatarUser != null)
                pictureBoxAvatar.Image = Image.FromStream(new MemoryStream(currentUser.AvatarUser));
            labelName.Text = currentUser.FullnameUser;
            labelDate.Text = currentUser.DateOfBirthUser.ToString("d MMMM yyyy");
        }
    }
}