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
    public partial class ViewFlights : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project_Flight\Project_Flight\Project_Flight\GBC_AirlinesDB.mdf;Integrated Security=True");
        public ViewFlights()
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
            int searchId = Convert.ToInt32(seaechFli.Text);
            conn.Open();
            string s = "select * from gbc_airlines_flight_table where FlightID=" + seaechFli.Text + ";";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            conn.Close();

        }
        private void update()
        {
            conn.Open();

            string s = "select * from gbc_airlines_flight_table";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(s, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            conn.Close();
            

        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            update();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (seaechFli.Text == "")
            {
                MessageBox.Show("No items selected to delete");
            }
            else
            {
                try
                {
                    conn.Open();

                    string s = "delete from gbc_airlines_flight_table where FlightID=" + seaechFli.Text + ";";
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_flightID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
