using Microsoft.Win32;
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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login_page l = new Login_page();
            l.ShowDialog();
            this.Close();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Registration register = new Registration ();
            register.ShowDialog();
            this.Close();
        }
    }
}
