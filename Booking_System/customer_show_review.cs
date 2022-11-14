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
    public partial class customer_show_review : Form
    {
        public customer_show_review()
        {
            InitializeComponent();
        }

        Controller.CustomerDetailDB db_customer_detail = new Controller.CustomerDetailDB();
        MySqlDataReader reader;
        MySqlCommand command;
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        DataTable dt = new DataTable();

        
        private void customer_show_review_Load(object sender, EventArgs e)
        {
            lbl_review_letter.Text = "";
            string query = "Select cus_name, letter from customer_review";
            db_customer_detail.connection_open();
            command = new MySqlCommand(query, db_customer_detail.MySqlConnector);
            reader = command.ExecuteReader();


            while (reader.Read())
            {
                lbl_review_letter.Text += $"Name : {reader.GetValue(0).ToString()} \n    Remark : {reader.GetValue(1).ToString()}\n";
            }
        }
    }
}
