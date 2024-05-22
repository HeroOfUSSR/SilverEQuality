using SilverEQuality_Context;
using SilverEQuality_Context.Models;

namespace SilverEQuality
{
    public partial class AuthForm : Form
    {
        public static User authorizedUser; 
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext())
            {
                authorizedUser = db.Users.FirstOrDefault(x => x.LoginUser == textBoxLogin.Text && x.PasswordUser == textBoxPassword.Text);

                if (authorizedUser != null)
                {
                    
                }
            }
        }
    }
}
