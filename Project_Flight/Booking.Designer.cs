
namespace Project_Flight
{
    partial class Booking
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
            this.btn_back_main = new System.Windows.Forms.Button();
            this.btn_view_booking = new System.Windows.Forms.Button();
            this.btn_add_booking = new System.Windows.Forms.Button();
            this.customer_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customer_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(707, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome To Booking";
            // 
            // btn_back_main
            // 
            this.btn_back_main.BackColor = System.Drawing.Color.Transparent;
            this.btn_back_main.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_main.ForeColor = System.Drawing.Color.Navy;
            this.btn_back_main.Location = new System.Drawing.Point(694, 423);
            this.btn_back_main.Name = "btn_back_main";
            this.btn_back_main.Size = new System.Drawing.Size(272, 36);
            this.btn_back_main.TabIndex = 15;
            this.btn_back_main.Text = "Back To Main Menu";
            this.btn_back_main.UseVisualStyleBackColor = false;
            this.btn_back_main.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_view_booking
            // 
            this.btn_view_booking.BackColor = System.Drawing.Color.Transparent;
            this.btn_view_booking.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_booking.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_view_booking.Location = new System.Drawing.Point(713, 259);
            this.btn_view_booking.Name = "btn_view_booking";
            this.btn_view_booking.Size = new System.Drawing.Size(230, 62);
            this.btn_view_booking.TabIndex = 14;
            this.btn_view_booking.Text = "View Booking";
            this.btn_view_booking.UseVisualStyleBackColor = false;
            this.btn_view_booking.Click += new System.EventHandler(this.btn_view_booking_Click);
            // 
            // btn_add_booking
            // 
            this.btn_add_booking.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_booking.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_booking.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_add_booking.Location = new System.Drawing.Point(713, 173);
            this.btn_add_booking.Name = "btn_add_booking";
            this.btn_add_booking.Size = new System.Drawing.Size(230, 62);
            this.btn_add_booking.TabIndex = 13;
            this.btn_add_booking.Text = "Add Booking";
            this.btn_add_booking.UseVisualStyleBackColor = false;
            this.btn_add_booking.Click += new System.EventHandler(this.btn_add_booking_Click);
            // 
            // customer_pic
            // 
            this.customer_pic.Image = global::Project_Flight.Properties.Resources.Booking;
            this.customer_pic.Location = new System.Drawing.Point(12, 12);
            this.customer_pic.Name = "customer_pic";
            this.customer_pic.Size = new System.Drawing.Size(644, 476);
            this.customer_pic.TabIndex = 11;
            this.customer_pic.TabStop = false;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btn_back_main);
            this.Controls.Add(this.btn_view_booking);
            this.Controls.Add(this.btn_add_booking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customer_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox customer_pic;
        private System.Windows.Forms.Button btn_back_main;
        private System.Windows.Forms.Button btn_view_booking;
        private System.Windows.Forms.Button btn_add_booking;
    }
}