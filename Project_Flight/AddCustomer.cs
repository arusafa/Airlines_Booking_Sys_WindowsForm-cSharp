using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Flight
{
    public partial class AddCustomer : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project_Flight\Project_Flight\Project_Flight\GBC_AirlinesDB.mdf;Integrated Security=True");
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_firstName.Text == "" || txt_lastName.Text == "" || txt_phone.Text == "" || txt_bookingNumber.Text == "")
            {
                MessageBox.Show("Missing Information!!! \n\nPlease fill out all the information!");
            }
            else
            {
                try
                {
                    Random rnd = new Random();
                    int num = rnd.Next();

                    customer_id.Text += Convert.ToString(num);

                    int bookings = Convert.ToInt32(txt_bookingNumber.Text);

                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = $"insert into gbc_airlines_customers_table values ('{txt_firstName.Text}','{txt_lastName.Text}','{txt_phone.Text}',{bookings},'{customer_id.Text}');";

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer is recorded successfully!");
                    reset_info();

                    conn.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_firstName.Text = txt_lastName.Text = txt_phone.Text = txt_bookingNumber.Text = "";
        }
        private void reset_info()
        {
            txt_firstName.Text = txt_lastName.Text = txt_phone.Text = txt_bookingNumber.Text = customer_id.Text = "";
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
