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
    public partial class login : Form
    {
        public static login log;
        public string username, password;
        public static string name, pwd;

        MySqlCommand command;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        Controller.CustomerDetailDB db_bs = new Controller.CustomerDetailDB();

        public login()
        {
            InitializeComponent();
        }

        //Link to register page
        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reg = new registration();
            registration.reg = new registration();
            reg.Show();
            this.Hide();
        }


        MySqlDataReader reader;
        private void btn_login_Click(object sender, EventArgs e)
        {
            db_bs.connection_open();
            var customer_account = new login();
            string query = "select user_name,password from customer_account where user_name='" + txt_username.Text + "' and password='" + txt_password.Text + "'";
            command = new MySqlCommand(query, db_bs.MySqlConnector);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                name = reader.GetValue(0).ToString();
                pwd = reader.GetValue(1).ToString();
            }
           
            if (name == txt_username.Text && pwd == txt_password.Text)
            {
                Booking_System.welcome wel = new Booking_System.welcome();
                wel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unsucessful Login , Please Try Again");
            }
        }
    }
}
