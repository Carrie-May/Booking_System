using Booking_System.Controller;
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
    public partial class checkout : Form
    {
        public static checkout bill;
        public checkout()
        {
            InitializeComponent();
        }

        Controller.CustomerDetailDB db_customer_detail=new Controller.CustomerDetailDB();
        MySqlCommand command;
        MySqlDataReader reader;

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            string n="", p="";
            string query = "Select customer_name,  total_price from customer_booking where contact = '" +
                txt_check_out_contact.Text + "' and menu='"+txt_check_out_menu.Text+"' and date ='"+
                dtp_check_out_date.Text+"' and time= '"+cbo_check_out_time.Text+"'";
            db_customer_detail.connection_open();
            command = new MySqlCommand(query, db_customer_detail.MySqlConnector);
            reader = command.ExecuteReader();   

            while (reader.Read())
            {
                n = reader.GetValue(0).ToString();
                p = reader.GetValue(1).ToString();
            }
            lbl_cus_name.Text= n;
            lbl_price.Text = p;
        }
    }
}
