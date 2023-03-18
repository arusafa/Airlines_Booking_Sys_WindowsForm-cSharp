
namespace Project_Flight
{
    partial class AddFlight
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
            this.txt_flightID = new System.Windows.Forms.TextBox();
            this.label_firstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maxSeats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_origin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_destination = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.customer_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customer_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_flightID
            // 
            this.txt_flightID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_flightID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_flightID.Location = new System.Drawing.Point(227, 79);
            this.txt_flightID.Multiline = true;
            this.txt_flightID.Name = "txt_flightID";
            this.txt_flightID.Size = new System.Drawing.Size(237, 45);
            this.txt_flightID.TabIndex = 17;
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.BackColor = System.Drawing.Color.Honeydew;
            this.label_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstName.Location = new System.Drawing.Point(24, 99);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(121, 25);
            this.label_firstName.TabIndex = 16;
            this.label_firstName.Text = "Flight ID  :";
            this.label_firstName.Click += new System.EventHandler(this.label_firstName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(144, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add a Flight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Maxium Seats  :";
            // 
            // txt_maxSeats
            // 
            this.txt_maxSeats.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_maxSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maxSeats.Location = new System.Drawing.Point(227, 169);
            this.txt_maxSeats.Multiline = true;
            this.txt_maxSeats.Name = "txt_maxSeats";
            this.txt_maxSeats.Size = new System.Drawing.Size(237, 45);
            this.txt_maxSeats.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Origin  :";
            // 
            // txt_origin
            // 
            this.txt_origin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_origin.Location = new System.Drawing.Point(227, 252);
            this.txt_origin.Multiline = true;
            this.txt_origin.Name = "txt_origin";
            this.txt_origin.Size = new System.Drawing.Size(237, 45);
            this.txt_origin.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Destination  :";
            // 
            // txt_destination
            // 
            this.txt_destination.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_destination.Location = new System.Drawing.Point(227, 334);
            this.txt_destination.Multiline = true;
            this.txt_destination.Name = "txt_destination";
            this.txt_destination.Size = new System.Drawing.Size(237, 45);
            this.txt_destination.TabIndex = 23;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_submit.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(57, 437);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(115, 37);
            this.btn_submit.TabIndex = 24;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_reset.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(189, 437);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(115, 37);
            this.btn_reset.TabIndex = 25;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Honeydew;
            this.btn_back.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Navy;
            this.btn_back.Location = new System.Drawing.Point(364, 437);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(115, 37);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // customer_pic
            // 
            this.customer_pic.Image = global::Project_Flight.Properties.Resources.AddFlight;
            this.customer_pic.Location = new System.Drawing.Point(501, 12);
            this.customer_pic.Name = "customer_pic";
            this.customer_pic.Size = new System.Drawing.Size(487, 476);
            this.customer_pic.TabIndex = 13;
            this.customer_pic.TabStop = false;
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_destination);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_origin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_maxSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_flightID);
            this.Controls.Add(this.label_firstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customer_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFlight";
            this.Load += new System.EventHandler(this.AddFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox customer_pic;
        private System.Windows.Forms.TextBox txt_flightID;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maxSeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_origin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_destination;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_back;
    }
}