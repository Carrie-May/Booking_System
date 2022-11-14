using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Booking_System.Booking_System
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        public static registration reg;
        public string username, password, confirm_password;

        MySqlDataReader reader;
        MySqlCommand command;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        Controller.CustomerDetailDB db_bs = new Controller.CustomerDetailDB();


        //check username length and no input data
        bool check_user_length()
        {
            bool urt = false;
            username = txt_username.Text;

            if (username == "")
            {
                MessageBox.Show("Please enter Username.");
            }


            //OR operator 5 > 5 or 5 == 5
            else if (username.Length >= 5 && username.Length <= 50)
            {
                urt = true;
            }
            else
            {
                MessageBox.Show("Username should be between 5 and 50 characters.");
            }
            return urt;
        }


        // check if uesrname have special characters
        bool has_special_char()
        {
            bool srt = false;
            username = txt_username.Text;
            string[] specialChar = { "@", "|", "", "!", "#", "$", "%", "^", "*", "(", ")", "=", "?", "/", "<", ">", ",",
                ".", "?", "_", "-", "+", "\"\"", "~", "`", ":", ";", "'", "{", "}", "[", "]", "€" };

            for (int i = 0; i < username.Length; i++)
            {
                for (int j = 0; j < specialChar.Length; j++)
                {
                    if (username[i].ToString() == specialChar[j])
                    {
                        srt = false;
                        MessageBox.Show("Username include special characters.");
                        j = specialChar.Length;
                        i = username.Length;
                    }
                    else
                    {
                        srt = true;
                    }
                }
            }
            return srt;
        }     

        //password and confirm password equality

        bool pws_eql_cpws() // pws_eql_cpws = password same with confirm password
        {
            bool psrt = false;
            password = txt_password.Text;
            confirm_password = txt_confirm_password.Text;

            
           if (password == confirm_password)
            {
                psrt = true;
            }
            else
            {
                MessageBox.Show("Password is not equal with confirm password.");
            }
            return psrt;

        }

        //Check password length
        bool check_password_length()
        {
            bool cpsrt = false;
            password = txt_password.Text;
            confirm_password = txt_confirm_password.Text;

            if (password == "" && confirm_password == "")
            {
                MessageBox.Show("Please enter Password and Confirm Password.");
            }
            //OR operator 6 > 6 or 6 == 6
            else if (password.Length >= 5 && confirm_password.Length >= 5)
            {
                cpsrt = true;
            }
            else
            {
                MessageBox.Show("Password is not valid");
            }
            return cpsrt;
        }

        // validation for data duplication
        public int user_acc()
        {
            int ck = 0;
            string n="",p;
            db_bs.connection_open();
            var customer_account = new login();
            string query = "select user_name,password from customer_account where user_name='" + txt_username.Text + "' and password='" + txt_password.Text + "'";
            command = new MySqlCommand(query, db_bs.MySqlConnector);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                n = reader.GetValue(0).ToString();
                p = reader.GetValue(1).ToString();

            }
            if (n == "")
            {
                ck = 1;
            }
            return ck;
        }


        private void register_btn_Click(object sender, EventArgs e)
        {
            if (user_acc() == 1)
            {
                if (check_user_length() && check_password_length() && pws_eql_cpws())
                {
                    string query = "Insert into customer_account(user_name, password) values('" + txt_username.Text + "', '" + txt_password.Text + "')";

                    db_bs.connection_open();
                    command = db_bs.MySqlConnector.CreateCommand();
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    db_bs.MySqlConnector.Close();
                    MessageBox.Show("Registration Successful");

                    Booking_System.login log = new Booking_System.login();
                    log.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unsuccessful Registration , Try Again");
                }
            }
            else
            {
                MessageBox.Show("change user name");
            }           
        }

        
        // link to Login page
        private void login_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var log = new login();
            login.log = new login();
            log.Show();
            this.Hide();
        }

        
    }
}
