using SEP_Framework.FrameWork.Controllers;
using SEP_Framework.MemberShip;
using SEP_Framework.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEP_Framework
{
    public partial class RegisterForm : Form
    {
        public Member member;
        public RegisterForm()
        {
            InitializeComponent();
            this.passwordTextBox._TextBox.PasswordChar = '*';
            this.password2TextBox._TextBox.PasswordChar = '*';
            string cnnString = DBInfoSingleton.getInstance().getCnnString();
            string nameDB = DBInfoSingleton.getInstance().getNameDB();
            AbstractController controller = new MySQLController(cnnString, nameDB);
            member = new Member(controller); ;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerButton_Click_1(object sender, EventArgs e)
        {
            var user = this.usernameTextBox._TextBox.Text;
            var pas = this.passwordTextBox._TextBox.Text;
            var pas2 = this.password2TextBox._TextBox.Text;

           
            if (pas != pas2)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp", "Thông báo");
            }
            else if (this.member.Register(user, pas))
            {
                this.Hide();
            }
            else
            {
                //Label Mes = new Label();
                //Mes.Text = "Tài khoản đã tồn tại!";
                //Mes.Location = new Point(103, 273);
                //Mes.Font = new Font("Microsoft Sans Serif", 12f);
                //Mes.Size = new System.Drawing.Size(215, 20);
                //Mes.ForeColor = Color.White;
                //this.Controls.Add(Mes);
                MessageBox.Show("Tài khoản đã tồn tại");
            }
        }
    }
}
