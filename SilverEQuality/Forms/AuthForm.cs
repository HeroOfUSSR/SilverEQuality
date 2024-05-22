using SilverEQuality.Forms;
using SilverEQuality.MessageBoxes;
using SilverEQuality_Context;
using SilverEQuality_Context.Models;
using System.Security.Cryptography;
using System.Text;

namespace SilverEQuality
{
    public partial class AuthForm : Form
    {
        public bool isMouseDown;
        public Point startPoint;

        public static User authorizedUser;
        private int triesToLogin = 0;
        private string captcha;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                authorizedUser = db.Users.FirstOrDefault(x => x.LoginUser == textBoxLogin.Text && x.PasswordUser == textBoxPassword.Text);

                if (triesToLogin == 2)
                {
                    Height = 520;
                    panelCaptcha.Visible = true;
                    textBoxCaptcha.Visible = true;
                    buttonReload.Visible = true;
                    RefreshCaptcha();
                }

                if (authorizedUser != null && triesToLogin < 2 
                    || triesToLogin >= 2 && authorizedUser != null && textBoxCaptcha.Text == captcha)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBoxAuth authError = new MessageBoxAuth();
                    authError.ShowDialog();
                    triesToLogin++;
                }
            }
        }

        private string RandomCaptchaString()
        {
            string s = "", symb = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
                s += symb[rnd.Next(0, symb.Length)];
            return s;
        }

        void RefreshCaptcha()
        {
            CaptchaImage c = new CaptchaImage(RandomCaptchaString(), 300, 134);
            panelCaptcha.BackgroundImage = c.Image;
            captcha = c.Text;
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            RefreshCaptcha();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
