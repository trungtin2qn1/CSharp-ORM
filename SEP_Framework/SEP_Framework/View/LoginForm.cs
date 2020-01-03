using SEP_Framework.FrameWork.Controllers;
using SEP_Framework.MemberShip;
using SEP_Framework.Utils;
using SEP_Framework.View;
using System;
using System.Windows.Forms;

namespace SEP_Framework
{
    public partial class LoginForm : Form
    {
        public Member member;
        public LoginForm()
        {
            InitializeComponent();
            this.passwordTextBox._TextBox.PasswordChar = '*';
            string cnnString = ConnectionStringSingleton.getInstance().getCnnString();
            SQLServerController controller = new SQLServerController(cnnString);
            member = new Member(controller); ;
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
            var user = usernameTextBox._TextBox.Text;
            var pas = passwordTextBox._TextBox.Text;

            if (this.member.Login(user, pas))
            {
                this.Hide();
                new HomeForm().Show();
            }
            else
            {
                //Label Mes = new Label();
                //Mes.Text = "Tài khoản hoặc mật khẩu sai!";
                //Mes.Location = new Point(103, 300);
                //Mes.Font = new Font("Microsoft Sans Serif", 12f);
                //Mes.Size = new System.Drawing.Size(215, 20);
                //Mes.ForeColor = Color.White;
                //this.Controls.Add(Mes);
                MessageBox.Show("Tài khoản hoặc mật khẩu sai !!!");
            }
        }
    }
}
