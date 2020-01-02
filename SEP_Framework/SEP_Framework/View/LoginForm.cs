using SEP_Framework.View;
using System;
using System.Windows.Forms;

namespace SEP_Framework
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.passwordTextBox._TextBox.PasswordChar = '*';
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            new HomeForm().Show();
            this.Hide();
        }
    }
}
