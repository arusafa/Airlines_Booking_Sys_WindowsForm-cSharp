
namespace Project_Flight
{
    partial class Customers
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
            this.btn_add_customer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_view_customer = new System.Windows.Forms.Button();
            this.btn_back_main = new System.Windows.Forms.Button();
            this.customer_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customer_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_customer
            // 
            this.btn_add_customer.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_customer.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_customer.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_add_customer.Location = new System.Drawing.Point(718, 176);
            this.btn_add_customer.Name = "btn_add_customer";
            this.btn_add_customer.Size = new System.Drawing.Size(230, 62);
            this.btn_add_customer.TabIndex = 9;
            this.btn_add_customer.Text = "Add Customer";
            this.btn_add_customer.UseVisualStyleBackColor = false;
            this.btn_add_customer.Click += new System.EventHandler(this.btn_add_customer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(692, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome To Customers";
            // 
            // btn_view_customer
            // 
            this.btn_view_customer.BackColor = System.Drawing.Color.Transparent;
            this.btn_view_customer.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_customer.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_view_customer.Location = new System.Drawing.Point(718, 267);
            this.btn_view_customer.Name = "btn_view_customer";
            this.btn_view_customer.Size = new System.Drawing.Size(230, 62);
            this.btn_view_customer.TabIndex = 11;
            this.btn_view_customer.Text = "View Customer";
            this.btn_view_customer.UseVisualStyleBackColor = false;
            this.btn_view_customer.Click += new System.EventHandler(this.btn_view_customer_Click);
            // 
            // btn_back_main
            // 
            this.btn_back_main.BackColor = System.Drawing.Color.Transparent;
            this.btn_back_main.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_main.ForeColor = System.Drawing.Color.Navy;
            this.btn_back_main.Location = new System.Drawing.Point(698, 425);
            this.btn_back_main.Name = "btn_back_main";
            this.btn_back_main.Size = new System.Drawing.Size(272, 36);
            this.btn_back_main.TabIndex = 12;
            this.btn_back_main.Text = "Back To Main Menu";
            this.btn_back_main.UseVisualStyleBackColor = false;
            this.btn_back_main.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // customer_pic
            // 
            this.customer_pic.Image = global::Project_Flight.Properties.Resources.Customers;
            this.customer_pic.Location = new System.Drawing.Point(12, 12);
            this.customer_pic.Name = "customer_pic";
            this.customer_pic.Size = new System.Drawing.Size(644, 476);
            this.customer_pic.TabIndex = 1;
            this.customer_pic.TabStop = false;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btn_back_main);
            this.Controls.Add(this.btn_view_customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_customer);
            this.Controls.Add(this.customer_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox customer_pic;
        private System.Windows.Forms.Button btn_add_customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_view_customer;
        private System.Windows.Forms.Button btn_back_main;
    }
}