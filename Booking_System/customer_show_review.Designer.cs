namespace Booking_System.Booking_System
{
    partial class customer_show_review
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
            this.review_data = new System.Windows.Forms.Panel();
            this.lbl_review_letter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.heading = new System.Windows.Forms.Label();
            this.review_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // review_data
            // 
            this.review_data.BackColor = System.Drawing.Color.Gainsboro;
            this.review_data.Controls.Add(this.lbl_review_letter);
            this.review_data.Location = new System.Drawing.Point(31, 87);
            this.review_data.Name = "review_data";
            this.review_data.Size = new System.Drawing.Size(739, 400);
            this.review_data.TabIndex = 0;
            // 
            // lbl_review_letter
            // 
            this.lbl_review_letter.AutoSize = true;
            this.lbl_review_letter.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_review_letter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_review_letter.Location = new System.Drawing.Point(22, 21);
            this.lbl_review_letter.Name = "lbl_review_letter";
            this.lbl_review_letter.Size = new System.Drawing.Size(68, 23);
            this.lbl_review_letter.TabIndex = 0;
            this.lbl_review_letter.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Booking_System.Properties.Resources.icons8_star_20;
            this.pictureBox1.Location = new System.Drawing.Point(668, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
//            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.heading.Location = new System.Drawing.Point(25, 32);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(355, 34);
            this.heading.TabIndex = 12;
            this.heading.Text = "Our Customers\' Reviews";
            // 
            // customer_show_review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.review_data);
            this.Name = "customer_show_review";
            this.Text = "customer_show_review";
            this.Load += new System.EventHandler(this.customer_show_review_Load);
            this.review_data.ResumeLayout(false);
            this.review_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel review_data;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label lbl_review_letter;
    }
}