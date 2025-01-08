using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_book_store
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text) && string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Please Enter User Name and Passwords Properly", "Empty Field");
                return;
            }
            if (txtname.Text == "Zameer" && txtpass.Text == "123")
            {
                MessageBox.Show("Login Successful", "Success");
            }
            else
            {
                MessageBox.Show("Login Failed", "Error");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            homepage h = new homepage();
            this.Hide();
            h.ShowDialog();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            Registration h = new Registration();
            this.Hide();
            h.ShowDialog();
        }

        private void txtforgotpass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact support at support@example.com to reset your password.", "Forgot Password");
        }
    }
}
