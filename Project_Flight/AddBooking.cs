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
    public partial class AddBooking : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project_Flight\Project_Flight\Project_Flight\GBC_AirlinesDB.mdf;Integrated Security=True");
        public AddBooking()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
            this.Hide();
        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            update();
            this.Hide();
        }
        private void update()
        {
            conn.Open();

            string s = "select * from gbc_airlines_customers_table,gbc_airlines_flight_table";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            conn.Close();
            
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "" ||txt_flight_id.Text == "" )
            {
                MessageBox.Show("Missing Information!!! \n\nPlease fill out all the information!");
            }
            else
            {
                try
                {
                    Random rnd = new Random();
                    int num = rnd.Next();

                    id.Text += Convert.ToString(num);

                    string date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");

                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = $"insert into gbc_airlines_bookings_table values ('{txt_flight_id.Text}','{txt_ID.Text}','{id.Text}','{date}');";

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking is made successfully!");

                    string s = "select * from gbc_airlines_customers_table,gbc_airlines_flight_table,gbc_airlines_bookings_table";
                    

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s, conn);
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                    var dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];

                    conn.Close();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_flight_id.Text = txt_ID.Text = "";
        }
    }
}
