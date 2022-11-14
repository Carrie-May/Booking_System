namespace Booking_System.Booking_System
{
    partial class booking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deleteview = new System.Windows.Forms.Button();
            this.txt_book_table = new System.Windows.Forms.ComboBox();
            this.btn_showview = new System.Windows.Forms.Button();
            this.btn_cancelview = new System.Windows.Forms.Button();
            this.btn_updateview = new System.Windows.Forms.Button();
            this.txt_book_time = new System.Windows.Forms.ComboBox();
            this.txt_book_date = new System.Windows.Forms.DateTimePicker();
            this.txt_book_person = new System.Windows.Forms.ComboBox();
            this.booking_data = new System.Windows.Forms.DataGridView();
            this.txt_book_menu = new System.Windows.Forms.ComboBox();
            this.btn_bookview = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_table = new System.Windows.Forms.Label();
            this.label_person = new System.Windows.Forms.Label();
            this.txt_book_address = new System.Windows.Forms.TextBox();
            this.label_menu = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.txt_book_contact = new System.Windows.Forms.TextBox();
            this.label_contact = new System.Windows.Forms.Label();
            this.txt_book_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.heading.Location = new System.Drawing.Point(85, 27);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(144, 38);
            this.heading.TabIndex = 2;
            this.heading.Text = "Booking";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_deleteview);
            this.panel1.Controls.Add(this.txt_book_table);
            this.panel1.Controls.Add(this.btn_showview);
            this.panel1.Controls.Add(this.btn_cancelview);
            this.panel1.Controls.Add(this.btn_updateview);
            this.panel1.Controls.Add(this.txt_book_time);
            this.panel1.Controls.Add(this.txt_book_date);
            this.panel1.Controls.Add(this.txt_book_person);
            this.panel1.Controls.Add(this.booking_data);
            this.panel1.Controls.Add(this.txt_book_menu);
            this.panel1.Controls.Add(this.btn_bookview);
            this.panel1.Controls.Add(this.label_time);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_table);
            this.panel1.Controls.Add(this.label_person);
            this.panel1.Controls.Add(this.txt_book_address);
            this.panel1.Controls.Add(this.label_menu);
            this.panel1.Controls.Add(this.label_address);
            this.panel1.Controls.Add(this.txt_book_contact);
            this.panel1.Controls.Add(this.label_contact);
            this.panel1.Controls.Add(this.txt_book_name);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Location = new System.Drawing.Point(23, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 659);
            this.panel1.TabIndex = 3;
            // 
            // btn_deleteview
            // 
            this.btn_deleteview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_deleteview.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_deleteview.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteview.ForeColor = System.Drawing.Color.Black;
            this.btn_deleteview.Location = new System.Drawing.Point(784, 582);
            this.btn_deleteview.Name = "btn_deleteview";
            this.btn_deleteview.Size = new System.Drawing.Size(148, 50);
            this.btn_deleteview.TabIndex = 27;
            this.btn_deleteview.Text = "Delete";
            this.btn_deleteview.UseVisualStyleBackColor = false;
            this.btn_deleteview.Click += new System.EventHandler(this.btn_deleteview_Click);
            // 
            // txt_book_table
            // 
            this.txt_book_table.FormattingEnabled = true;
            this.txt_book_table.Items.AddRange(new object[] {
            "Table 1",
            "Table 2",
            "Table 3",
            "Table 4",
            "Table 5",
            "Table 6",
            "Table 7"});
            this.txt_book_table.Location = new System.Drawing.Point(522, 127);
            this.txt_book_table.Name = "txt_book_table";
            this.txt_book_table.Size = new System.Drawing.Size(409, 24);
            this.txt_book_table.TabIndex = 26;
            // 
            // btn_showview
            // 
            this.btn_showview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_showview.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_showview.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showview.ForeColor = System.Drawing.Color.Black;
            this.btn_showview.Location = new System.Drawing.Point(37, 430);
            this.btn_showview.Name = "btn_showview";
            this.btn_showview.Size = new System.Drawing.Size(148, 50);
            this.btn_showview.TabIndex = 25;
            this.btn_showview.Text = "Show";
            this.btn_showview.UseVisualStyleBackColor = false;
            this.btn_showview.Click += new System.EventHandler(this.btn_showview_Click);
            // 
            // btn_cancelview
            // 
            this.btn_cancelview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cancelview.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cancelview.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelview.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelview.Location = new System.Drawing.Point(37, 499);
            this.btn_cancelview.Name = "btn_cancelview";
            this.btn_cancelview.Size = new System.Drawing.Size(148, 50);
            this.btn_cancelview.TabIndex = 24;
            this.btn_cancelview.Text = "Cancel";
            this.btn_cancelview.UseVisualStyleBackColor = false;
            this.btn_cancelview.Click += new System.EventHandler(this.btn_cancelview_Click);
            // 
            // btn_updateview
            // 
            this.btn_updateview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_updateview.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_updateview.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateview.ForeColor = System.Drawing.Color.Black;
            this.btn_updateview.Location = new System.Drawing.Point(211, 582);
            this.btn_updateview.Name = "btn_updateview";
            this.btn_updateview.Size = new System.Drawing.Size(145, 50);
            this.btn_updateview.TabIndex = 23;
            this.btn_updateview.Text = "Update";
            this.btn_updateview.UseVisualStyleBackColor = false;
            this.btn_updateview.Click += new System.EventHandler(this.btn_updateview_Click);
            // 
            // txt_book_time
            // 
            this.txt_book_time.FormattingEnabled = true;
            this.txt_book_time.Items.AddRange(new object[] {
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
            this.txt_book_time.Location = new System.Drawing.Point(524, 276);
            this.txt_book_time.Name = "txt_book_time";
            this.txt_book_time.Size = new System.Drawing.Size(408, 24);
            this.txt_book_time.TabIndex = 22;
            // 
            // txt_book_date
            // 
            this.txt_book_date.Location = new System.Drawing.Point(524, 202);
            this.txt_book_date.Name = "txt_book_date";
            this.txt_book_date.Size = new System.Drawing.Size(407, 22);
            this.txt_book_date.TabIndex = 21;
            // 
            // txt_book_person
            // 
            this.txt_book_person.FormattingEnabled = true;
            this.txt_book_person.Items.AddRange(new object[] {
            "1 person",
            "2 person",
            "3 person",
            "4 person",
            "5 person",
            "6 person",
            "7 person",
            "8 person",
            "9 person"});
            this.txt_book_person.Location = new System.Drawing.Point(523, 52);
            this.txt_book_person.Name = "txt_book_person";
            this.txt_book_person.Size = new System.Drawing.Size(407, 24);
            this.txt_book_person.TabIndex = 20;
      //      this.txt_book_person.SelectedIndexChanged += new System.EventHandler(this.txt_book_person_SelectedIndexChanged);
            // 
            // booking_data
            // 
            this.booking_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booking_data.Location = new System.Drawing.Point(211, 359);
            this.booking_data.Name = "booking_data";
            this.booking_data.RowHeadersWidth = 51;
            this.booking_data.RowTemplate.Height = 24;
            this.booking_data.Size = new System.Drawing.Size(721, 190);
            this.booking_data.TabIndex = 19;
            // 
            // txt_book_menu
            // 
            this.txt_book_menu.FormattingEnabled = true;
            this.txt_book_menu.Items.AddRange(new object[] {
            "Set A",
            "Set B",
            "Set C"});
            this.txt_book_menu.Location = new System.Drawing.Point(37, 276);
            this.txt_book_menu.Name = "txt_book_menu";
            this.txt_book_menu.Size = new System.Drawing.Size(407, 24);
            this.txt_book_menu.TabIndex = 18;
            // 
            // btn_bookview
            // 
            this.btn_bookview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_bookview.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_bookview.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookview.ForeColor = System.Drawing.Color.Black;
            this.btn_bookview.Location = new System.Drawing.Point(37, 359);
            this.btn_bookview.Name = "btn_bookview";
            this.btn_bookview.Size = new System.Drawing.Size(148, 50);
            this.btn_bookview.TabIndex = 17;
            this.btn_bookview.Text = "Book";
            this.btn_bookview.UseVisualStyleBackColor = false;
            this.btn_bookview.Click += new System.EventHandler(this.btn_bookview_Click);
            // 
            // label_time
            // 
            this.label_time.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(519, 247);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(78, 26);
            this.label_time.TabIndex = 11;
            this.label_time.Text = "Time";
            // 
            // label_date
            // 
            this.label_date.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(519, 173);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(78, 26);
            this.label_date.TabIndex = 10;
            this.label_date.Text = "Date";
            // 
            // label_table
            // 
            this.label_table.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_table.ForeColor = System.Drawing.Color.White;
            this.label_table.Location = new System.Drawing.Point(519, 98);
            this.label_table.Name = "label_table";
            this.label_table.Size = new System.Drawing.Size(92, 26);
            this.label_table.TabIndex = 9;
            this.label_table.Text = "Table";
            // 
            // label_person
            // 
            this.label_person.AutoSize = true;
            this.label_person.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_person.ForeColor = System.Drawing.Color.White;
            this.label_person.Location = new System.Drawing.Point(519, 25);
            this.label_person.Name = "label_person";
            this.label_person.Size = new System.Drawing.Size(78, 26);
            this.label_person.TabIndex = 8;
            this.label_person.Text = "Person";
            // 
            // txt_book_address
            // 
            this.txt_book_address.Location = new System.Drawing.Point(37, 202);
            this.txt_book_address.Name = "txt_book_address";
            this.txt_book_address.Size = new System.Drawing.Size(407, 22);
            this.txt_book_address.TabIndex = 7;
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.Color.White;
            this.label_menu.Location = new System.Drawing.Point(35, 247);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(68, 26);
            this.label_menu.TabIndex = 6;
            this.label_menu.Text = "Menu";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.ForeColor = System.Drawing.Color.White;
            this.label_address.Location = new System.Drawing.Point(32, 173);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(88, 26);
            this.label_address.TabIndex = 4;
            this.label_address.Text = "Address";
            // 
            // txt_book_contact
            // 
            this.txt_book_contact.Location = new System.Drawing.Point(37, 127);
            this.txt_book_contact.Name = "txt_book_contact";
            this.txt_book_contact.Size = new System.Drawing.Size(407, 22);
            this.txt_book_contact.TabIndex = 3;
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact.ForeColor = System.Drawing.Color.White;
            this.label_contact.Location = new System.Drawing.Point(32, 98);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(97, 26);
            this.label_contact.TabIndex = 2;
            this.label_contact.Text = "Contact";
            // 
            // txt_book_name
            // 
            this.txt_book_name.Location = new System.Drawing.Point(37, 54);
            this.txt_book_name.Name = "txt_book_name";
            this.txt_book_name.Size = new System.Drawing.Size(407, 22);
            this.txt_book_name.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(32, 25);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(71, 26);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Booking_System.Properties.Resources.icons8_restaurant_64__1_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 770);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.heading);
            this.Name = "booking";
            this.Text = "BOOKING";
            this.Load += new System.EventHandler(this.booking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox txt_book_name;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.TextBox txt_book_contact;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.TextBox txt_book_address;
        private System.Windows.Forms.Label label_person;
        private System.Windows.Forms.Label label_table;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button btn_bookview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView booking_data;
        private System.Windows.Forms.ComboBox txt_book_menu;
        private System.Windows.Forms.ComboBox txt_book_person;
        private System.Windows.Forms.DateTimePicker txt_book_date;
        private System.Windows.Forms.ComboBox txt_book_time;
        private System.Windows.Forms.Button btn_cancelview;
        private System.Windows.Forms.Button btn_updateview;
        private System.Windows.Forms.Button btn_showview;
        private System.Windows.Forms.ComboBox txt_book_table;
        private System.Windows.Forms.Button btn_deleteview;
    }
}