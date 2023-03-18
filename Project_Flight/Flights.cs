using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Flight
{
    public partial class Flights : Form
    {
        public Flights()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            AddFlight addFlight = new AddFlight();
            addFlight.Show();
            this.Hide();
        }

        private void btn_view_flight_Click(object sender, EventArgs e)
        {
            ViewFlights viewFlights = new ViewFlights();
            viewFlights.Show();
            this.Hide();
        }

        private void Flights_Load(object sender, EventArgs e)
        {

        }
    }
}
