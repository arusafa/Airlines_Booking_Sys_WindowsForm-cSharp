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
    public partial class AddFlight : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project_Flight\Project_Flight\Project_Flight\GBC_AirlinesDB.mdf;Integrated Security=True");
        public AddFlight()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Flights flights = new Flights();
            flights.Show();
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_flightID.Text == "" || txt_maxSeats.Text == "" || txt_origin.Text == "" || txt_destination.Text == "")
            {
                MessageBox.Show("Missing Information!!! \n\nPlease fill out all the information!");
            }
            else
            {
                try
                {
                    int flightNum = Convert.ToInt32(txt_flightID.Text);
                    int maxSeats = Convert.ToInt32(txt_maxSeats.Text);
                   conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = $"insert into gbc_airlines_flight_table values ({flightNum},{maxSeats},'{txt_origin.Text}','{txt_destination.Text}');";

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight is recorded successfully!");

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
            txt_flightID.Text = txt_maxSeats.Text = txt_origin.Text = txt_destination.Text = " ";
        }

        private void AddFlight_Load(object sender, EventArgs e)
        {

        }

        private void label_firstName_Click(object sender, EventArgs e)
        {

        }
    }
}
