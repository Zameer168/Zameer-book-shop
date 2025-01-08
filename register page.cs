using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project_book_store
{
    public partial class Registration : Form
    {
        public SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user\\Desktop\\Book Store.mdf\";Integrated Security=True;Connect Timeout=30");
        public Registration()
        {
            InitializeComponent();
        }



        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //Empty fields
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtConPass.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPerAddress.Text) || string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtLName.Text) || string.IsNullOrEmpty(txtFatherName.Text) || string.IsNullOrEmpty(txtCNIC.Text) || string.IsNullOrEmpty(txtPHNo.Text))
                {
                    MessageBox.Show("Please fill all fields.", "Empty Fields");
                    return;
                }

                //Password Match
                if (txtConPass.Text != txtPass.Text)
                {
                    MessageBox.Show("Enter Correct Password.", "Error");
                    return;
                }

                //Email Validation
                if (!Regex.IsMatch(txtEmail.Text, "^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$"))
                {
                    MessageBox.Show("Enter correct Email.", "Error");
                    return;
                }

                //Data Insertion into Database

                SqlCommand cmd = new SqlCommand("INSERT INTO Customers(First Name,Last Name,Father Name,CNIC,Email,Ph no,Password,Confirm Password,Address,Permanent Address) VALUES('" + txtFName.Text + "','" + txtLName.Text + "','" + txtFatherName.Text + "','" + txtCNIC.Text + "','" + txtEmail.Text + "','" + txtPHNo.Text + "','" + txtPass.Text + "','" + txtConPass.Text + "','" + txtAddress.Text + "','" + txtPerAddress.Text + "')",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Entered", "Success");
                //hey
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.\nError Trace : " + ex.Message, "Error");

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login_page h = new Login_page();
            h.ShowDialog();
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            homepage h = new homepage();
            h.ShowDialog();
            this.Close();
        }
    }
}
