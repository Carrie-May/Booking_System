namespace Booking_System.Booking_System
{
    partial class checkout
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
            this.heading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkout_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_check_out_time = new System.Windows.Forms.ComboBox();
            this.dtp_check_out_date = new System.Windows.Forms.DateTimePicker();
            this.label_time = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.txt_check_out_menu = new System.Windows.Forms.ComboBox();
            this.label_menu = new System.Windows.Forms.Label();
            this.txt_check_out_contact = new System.Windows.Forms.TextBox();
            this.label_contact = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_cus_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.heading.Location = new System.Drawing.Point(101, 32);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(88, 48);
            this.heading.TabIndex = 19;
            this.heading.Text = "Bill";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Booking_System.Properties.Resources.icons8_restaurant_64__1_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(26, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total Price ";
            // 
            // checkout_btn
            // 
            this.checkout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkout_btn.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_btn.ForeColor = System.Drawing.Color.White;
            this.checkout_btn.Location = new System.Drawing.Point(23, 499);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(384, 51);
            this.checkout_btn.TabIndex = 26;
            this.checkout_btn.Text = "Make a Payment";
            this.checkout_btn.UseVisualStyleBackColor = false;
            this.checkout_btn.Click += new System.EventHandler(this.checkout_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(351, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "MMK";
            // 
            // cbo_check_out_time
            // 
            this.cbo_check_out_time.FormattingEnabled = true;
            this.cbo_check_out_time.Items.AddRange(new object[] {
            "12:00 pm",
            "12:30 pm",
            "1:00 pm",
            "1:30 pm",
            "2:00 pm",
            "2:30 pm",
            "3:00 pm",
            "3:30 pm",
            "4:00 pm",
            "4:30 pm",
            "5:00 pm",
            "5:30 pm",
            "6:00 pm",
            "6:30 pm",
            "7:00 pm",
            "7:30 pm",
            "8:00 pm",
            "8:30 pm",
            "9:00 pm",
            "9:30 pm"});
            this.cbo_check_out_time.Location = new System.Drawing.Point(172, 369);
            this.cbo_check_out_time.Name = "cbo_check_out_time";
            this.cbo_check_out_time.Size = new System.Drawing.Size(233, 24);
            this.cbo_check_out_time.TabIndex = 36;
            // 
            // dtp_check_out_date
            // 
            this.dtp_check_out_date.Location = new System.Drawing.Point(171, 298);
            this.dtp_check_out_date.Name = "dtp_check_out_date";
            this.dtp_check_out_date.Size = new System.Drawing.Size(234, 22);
            this.dtp_check_out_date.TabIndex = 35;
            // 
            // label_time
            // 
            this.label_time.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_time.Location = new System.Drawing.Point(27, 367);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(78, 26);
            this.label_time.TabIndex = 34;
            this.label_time.Text = "Time";
            // 
            // label_date
            // 
            this.label_date.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_date.Location = new System.Drawing.Point(27, 298);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(78, 26);
            this.label_date.TabIndex = 33;
            this.label_date.Text = "Date";
            // 
            // txt_check_out_menu
            // 
            this.txt_check_out_menu.FormattingEnabled = true;
            this.txt_check_out_menu.Items.AddRange(new object[] {
            "Set A",
            "Set B",
            "Set C"});
            this.txt_check_out_menu.Location = new System.Drawing.Point(173, 235);
            this.txt_check_out_menu.Name = "txt_check_out_menu";
            this.txt_check_out_menu.Size = new System.Drawing.Size(234, 24);
            this.txt_check_out_menu.TabIndex = 40;
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_menu.Location = new System.Drawing.Point(27, 235);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(68, 26);
            this.label_menu.TabIndex = 39;
            this.label_menu.Text = "Menu";
            // 
            // txt_check_out_contact
            // 
            this.txt_check_out_contact.Location = new System.Drawing.Point(173, 167);
            this.txt_check_out_contact.Name = "txt_check_out_contact";
            this.txt_check_out_contact.Size = new System.Drawing.Size(233, 22);
            this.txt_check_out_contact.TabIndex = 38;
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_contact.Location = new System.Drawing.Point(26, 167);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(97, 26);
            this.label_contact.TabIndex = 37;
            this.label_contact.Text = "Contact";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_price.Location = new System.Drawing.Point(169, 435);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(21, 23);
            this.lbl_price.TabIndex = 41;
            this.lbl_price.Text = "0";
            // 
            // lbl_cus_name
            // 
            this.lbl_cus_name.AutoSize = true;
            this.lbl_cus_name.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cus_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_cus_name.Location = new System.Drawing.Point(166, 110);
            this.lbl_cus_name.Name = "lbl_cus_name";
            this.lbl_cus_name.Size = new System.Drawing.Size(171, 26);
            this.lbl_cus_name.TabIndex = 42;
            this.lbl_cus_name.Text = "Customer name";
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 576);
            this.Controls.Add(this.lbl_cus_name);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txt_check_out_menu);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.txt_check_out_contact);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.cbo_check_out_time);
            this.Controls.Add(this.dtp_check_out_date);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkout_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.heading);
            this.Name = "checkout";
            this.Text = "checkout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checkout_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_check_out_time;
        private System.Windows.Forms.DateTimePicker dtp_check_out_date;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.ComboBox txt_check_out_menu;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.TextBox txt_check_out_contact;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_cus_name;
    }
}