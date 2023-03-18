
namespace Project_Flight
{
    partial class Flights
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
            this.customer_pic = new System.Windows.Forms.PictureBox();
            this.btn_add_flight = new System.Windows.Forms.Button();
            this.btn_view_flight = new System.Windows.Forms.Button();
            this.btn_back_main = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customer_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(719, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome To Flights";
            // 
            // customer_pic
            // 
            this.customer_pic.Image = global::Project_Flight.Properties.Resources.Flights;
            this.customer_pic.Location = new System.Drawing.Point(12, 12);
            this.customer_pic.Name = "customer_pic";
            this.customer_pic.Size = new System.Drawing.Size(644, 476);
            this.customer_pic.TabIndex = 11;
            this.customer_pic.TabStop = false;
            // 
            // btn_add_flight
            // 
            this.btn_add_flight.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_flight.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_flight.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_add_flight.Location = new System.Drawing.Point(725, 151);
            this.btn_add_flight.Name = "btn_add_flight";
            this.btn_add_flight.Size = new System.Drawing.Size(230, 62);
            this.btn_add_flight.TabIndex = 13;
            this.btn_add_flight.Text = "Add Flight";
            this.btn_add_flight.UseVisualStyleBackColor = false;
            this.btn_add_flight.Click += new System.EventHandler(this.btn_add_customer_Click);
            // 
            // btn_view_flight
            // 
            this.btn_view_flight.BackColor = System.Drawing.Color.Transparent;
            this.btn_view_flight.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_flight.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_view_flight.Location = new System.Drawing.Point(725, 251);
            this.btn_view_flight.Name = "btn_view_flight";
            this.btn_view_flight.Size = new System.Drawing.Size(230, 62);
            this.btn_view_flight.TabIndex = 14;
            this.btn_view_flight.Text = "View Flights";
            this.btn_view_flight.UseVisualStyleBackColor = false;
            this.btn_view_flight.Click += new System.EventHandler(this.btn_view_flight_Click);
            // 
            // btn_back_main
            // 
            this.btn_back_main.BackColor = System.Drawing.Color.Transparent;
            this.btn_back_main.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_main.ForeColor = System.Drawing.Color.Navy;
            this.btn_back_main.Location = new System.Drawing.Point(703, 386);
            this.btn_back_main.Name = "btn_back_main";
            this.btn_back_main.Size = new System.Drawing.Size(272, 36);
            this.btn_back_main.TabIndex = 15;
            this.btn_back_main.Text = "Back To Main Menu";
            this.btn_back_main.UseVisualStyleBackColor = false;
            this.btn_back_main.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btn_back_main);
            this.Controls.Add(this.btn_view_flight);
            this.Controls.Add(this.btn_add_flight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customer_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Flights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox customer_pic;
        private System.Windows.Forms.Button btn_add_flight;
        private System.Windows.Forms.Button btn_view_flight;
        private System.Windows.Forms.Button btn_back_main;
    }
}