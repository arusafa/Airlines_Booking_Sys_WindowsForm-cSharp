
namespace Project_Flight
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_bookings = new System.Windows.Forms.Button();
            this.btn_flights = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_view_booking = new System.Windows.Forms.Button();
            this.btn_make_booking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "GBC AIRLINES";
            // 
            // btn_bookings
            // 
            this.btn_bookings.BackColor = System.Drawing.Color.Navy;
            this.btn_bookings.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookings.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_bookings.Location = new System.Drawing.Point(32, 249);
            this.btn_bookings.Name = "btn_bookings";
            this.btn_bookings.Size = new System.Drawing.Size(230, 62);
            this.btn_bookings.TabIndex = 16;
            this.btn_bookings.Text = "Bookings";
            this.btn_bookings.UseVisualStyleBackColor = false;
            this.btn_bookings.Click += new System.EventHandler(this.btn_bookings_Click);
            // 
            // btn_flights
            // 
            this.btn_flights.BackColor = System.Drawing.Color.Navy;
            this.btn_flights.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_flights.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_flights.Location = new System.Drawing.Point(32, 181);
            this.btn_flights.Name = "btn_flights";
            this.btn_flights.Size = new System.Drawing.Size(230, 62);
            this.btn_flights.TabIndex = 15;
            this.btn_flights.Text = "Flights";
            this.btn_flights.UseVisualStyleBackColor = false;
            this.btn_flights.Click += new System.EventHandler(this.txt_flights_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.Color.Navy;
            this.btn_customer.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_customer.Location = new System.Drawing.Point(32, 113);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(230, 62);
            this.btn_customer.TabIndex = 14;
            this.btn_customer.Text = "Customers";
            this.btn_customer.UseVisualStyleBackColor = false;
            this.btn_customer.Click += new System.EventHandler(this.txt_customer_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkRed;
            this.btn_exit.Font = new System.Drawing.Font("Stencil", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(868, 438);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(120, 50);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Flight.Properties.Resources.Airlines;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(976, 476);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_view_booking
            // 
            this.btn_view_booking.BackColor = System.Drawing.Color.Navy;
            this.btn_view_booking.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_booking.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_view_booking.Location = new System.Drawing.Point(32, 385);
            this.btn_view_booking.Name = "btn_view_booking";
            this.btn_view_booking.Size = new System.Drawing.Size(230, 62);
            this.btn_view_booking.TabIndex = 17;
            this.btn_view_booking.Text = "View Bookings";
            this.btn_view_booking.UseVisualStyleBackColor = false;
            this.btn_view_booking.Visible = false;
            // 
            // btn_make_booking
            // 
            this.btn_make_booking.BackColor = System.Drawing.Color.Navy;
            this.btn_make_booking.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_make_booking.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_make_booking.Location = new System.Drawing.Point(32, 317);
            this.btn_make_booking.Name = "btn_make_booking";
            this.btn_make_booking.Size = new System.Drawing.Size(230, 62);
            this.btn_make_booking.TabIndex = 18;
            this.btn_make_booking.Text = "Make Bookings";
            this.btn_make_booking.UseVisualStyleBackColor = false;
            this.btn_make_booking.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btn_make_booking);
            this.Controls.Add(this.btn_view_booking);
            this.Controls.Add(this.btn_bookings);
            this.Controls.Add(this.btn_flights);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bookings;
        private System.Windows.Forms.Button btn_flights;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_view_booking;
        private System.Windows.Forms.Button btn_make_booking;
    }
}