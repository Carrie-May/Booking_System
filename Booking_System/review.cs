using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_System.Booking_System
{
    public partial class review : Form
    {
        public static review rev;

        public review()
        {
            InitializeComponent();
        }

        Controller.CustomerDetailDB dbc_d = new Controller.CustomerDetailDB();
        MySqlDataAdapter adapter;
        MySqlCommand command;

        private void btn_submit_Click(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter();
            command = new MySqlCommand();

            if (review_box.Text != "")
            {
                btn_submit.Enabled = true;
                string query = "insert into customer_review(cus_name,letter) values ('" 
                    + login.name + "','" + review_box.Text + "')";

                MessageBox.Show(login.name + review_box.Text);
                dbc_d.connection_open();

                command = dbc_d.MySqlConnector.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();

                MessageBox.Show("Thank you for your review.");

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter any comments for review.");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
