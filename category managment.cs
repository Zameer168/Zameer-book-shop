using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project_book_store
{
    public partial class category_managment : Form
    {
        public SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user\\Desktop\\Book Store.mdf\";Integrated Security=True;Connect Timeout=30");
        public category_managment()
        {
            InitializeComponent();
            ListData();

        }
        void ListData()
        {
            SqlCommand cmd = new SqlCommand("select * from Categories", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataGrid.DataSource = dt;


            private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Query

                SqlCommand cmd = new SqlCommand("INSERT INTO Customers() VALUES('" + TxtFName.Text + "','" + txtLName.Text + "','" + txtFatherName.Text + "','" + txtCNIC.Text + "','" + txtEmail.Text + "','" + txtPHNo.Text + "','" + txtPass.Text + "','" + txtConPass.Text + "','" + txtAddress.Text + "','" + txtPerAddress.Text + "''Image')", con);
                con.Open();
                //Execute Open, Close
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //Update List
                ListData();
                //Message
                MessageBox.Show(txtName.Text + " added successfully.", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong. Please try again later.\nError: " + ex.Message);


            }

        }
    }
}