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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btn_add_booking_Click(object sender, EventArgs e)
        {
            AddBooking addBooking = new AddBooking();
            addBooking.Show();
            this.Hide();
        }

        private void btn_view_booking_Click(object sender, EventArgs e)
        {
            ViewBookings viewBooking = new ViewBookings();
            viewBooking.Show();
            this.Hide();
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }
    }
}
