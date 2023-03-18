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
    public partial class ViewBookings : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project_Flight\Project_Flight\Project_Flight\GBC_AirlinesDB.mdf;Integrated Security=True");
        public ViewBookings()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_flightID.Text == "" || txt_id.Text == "")
            {
                MessageBox.Show("Please enter the Customer ID to Delete!");
            }
            else
            {
                try
                {
                    conn.Open();

                    string s = "delete from gbc_airlines_bookings_table where FlightID=" + txt_flightID.Text +"and CustomerID=" +txt_id.Text + ";";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
            this.Hide();
        }
        private void update()
        {
            conn.Open();

            string s = "select * from gbc_airlines_customers_table , gbc_airlines_flight_table , gbc_airlines_bookings_table";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            conn.Close();

        }
        private void ViewBookings_Load(object sender, EventArgs e)
        {
            update();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

        }
    }
}
