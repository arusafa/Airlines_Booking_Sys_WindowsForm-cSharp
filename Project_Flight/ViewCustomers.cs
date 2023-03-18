using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Flight
{
    public partial class ViewCustomers : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project_Flight\Project_Flight\Project_Flight\GBC_AirlinesDB.mdf;Integrated Security=True");
        public ViewCustomers()
        {
            InitializeComponent();
        }
        private void update()
        {
            conn.Open();

            string s = "select * from gbc_airlines_customers_table";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            conn.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            update();

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (firstName.Text == "" || lastName.Text == "" || phone.Text == "" || bookings.Text == "")
            {
                MessageBox.Show("Missing information to Update! \n\nPlease fill out all information");
            }
            else
            {
                try
                {
                    int book = Convert.ToInt32(bookings.Text);
                    int ID = Convert.ToInt32(txt_ID.Text);
                    
                    conn.Open();
                    string s = "update gbc_airlines_customers_table set FirstName='" + firstName.Text + "',LastName='" + lastName.Text + "',PhoneNumber='" + phone.Text + "',Bookings='" + book + "'where ID=" + ID + ";";
                    SqlCommand cmd = new SqlCommand(s, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer is updated successfully!");
                    conn.Close();
                    update();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            firstName.Text = lastName.Text = phone.Text = bookings.Text = txt_ID.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Please enter the Customer ID to Delete!");
            }
            else
            {
                try
                {
                    conn.Open();

                    string s = "delete from gbc_airlines_customers_table where CustomerID=" + txt_ID.Text + ";";
                    SqlCommand cmd = new SqlCommand(s, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer is deleted successfully!");
                    conn.Close();
                    update();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
