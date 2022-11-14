using Booking_System.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_System.Booking_System
{
    public partial class booking : Form
    {
        public static booking book;
        public static string name, pwd;
        public static float total_price, menu_price;
        
        string query;
        public booking()
        {
            InitializeComponent();
        }

        
        Controller.CustomerDetailDB db_customer_detail = new Controller.CustomerDetailDB();
        MySqlCommand command;
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        DataTable dt = new DataTable();

        float Total_Price()
        {
            total_price = 0;
            if (txt_book_menu.SelectedIndex == 0)
            {
                menu_price = 16900;
            }
            else if (txt_book_menu.SelectedIndex == 1)
            {
                menu_price = 21900;
            }
            else if (txt_book_menu.SelectedIndex == 2)
            {
                menu_price = 25900;
            }


            if (txt_book_person.SelectedIndex == 0)
            {
                total_price += menu_price * 1;
            }
            else if (txt_book_person.SelectedIndex == 1)
            {
                total_price += menu_price * 2;
            }
            else if (txt_book_person.SelectedIndex == 2)
            {
                total_price += menu_price * 3;
            }
            else if (txt_book_person.SelectedIndex == 3)
            {
                total_price += menu_price * 4;
            }
            else if (txt_book_person.SelectedIndex == 4)
            {
                total_price += menu_price * 5;
            }
            else if (txt_book_person.SelectedIndex == 5)
            {
                total_price += menu_price * 6;
            }
            else if (txt_book_person.SelectedIndex == 6)
            {
                total_price += menu_price * 7;
            }
            else if (txt_book_person.SelectedIndex == 7)
            {
                total_price += menu_price * 8;
            }
            else if (txt_book_person.SelectedIndex == 8)
            {
                total_price += menu_price * 9;
            }
            else if (txt_book_person.SelectedIndex == 9)
            {
                total_price += menu_price * 10;
            }
            else if (txt_book_person.SelectedIndex == 10)
            {
                total_price += menu_price * 11;
            }


            return total_price;
            
        }

        //Update section
        private void btn_updateview_Click(object sender, EventArgs e)
            {
                string query = "update customer_booking set contact='" + txt_book_contact.Text + "', address='" + txt_book_address.Text + "', " +
                    "menu='" + txt_book_menu.Text + "', person_count='" + txt_book_person.Text + "', " +
                    "book_table='" + txt_book_table.Text + "', date='" + txt_book_date.Text + "', time='" + txt_book_time.Text + "' , total_price='"+ Total_Price() + "' where customer_name='" + login.name + "' and contact = '" + txt_book_contact.Text + "' and date = '" + txt_book_date.Text + "'";
                adapter = new MySqlDataAdapter();
                //command = new MySqlCommand();
                db_customer_detail.connection_open();
                adapter.UpdateCommand = new MySqlCommand(query, db_customer_detail.MySqlConnector);
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("The booking is updated.");
            }

        // booking data duplication
        public int book_data_duplicate()
        { 
            int ck = 0;
            string bt = "";
            db_customer_detail.connection_open();
            var customer_account = new login();
            string query = "select customer_name from customer_booking where contact = '" + txt_book_contact.Text + "' and date='" + txt_book_date.Text + "' and time='" + txt_book_time.Text + "'";
            command = new MySqlCommand(query, db_customer_detail.MySqlConnector);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                bt = reader.GetValue(0).ToString();

            }
            if (bt == "")
            {
                ck = 1;
            }
            else
            {
                MessageBox.Show("This booking has already reserved.");
            }
            return ck;
        }

        //Book section
       private void btn_bookview_Click(object sender, EventArgs e)
        {
            if (book_data_duplicate() == 1)
            {
                query = "insert into customer_booking(customer_name,contact,address,menu,person_count,book_table,date,time,total_price) " +
                               "values('" + txt_book_name.Text + "','" + txt_book_contact.Text + "','" + txt_book_address.Text +
                               "', '" + txt_book_menu.Text + "', '" + txt_book_person.Text + "', '" + txt_book_table.Text + "', '"
                               + txt_book_date.Text + "', '" + txt_book_time.Text + "' , '" + Total_Price() + "')";

                //query = "insert into customer_booking(contact) values('"+"09123456789"+"')";
                db_customer_detail.connection_open();
                command = db_customer_detail.MySqlConnector.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                db_customer_detail.MySqlConnector.Close();

                MessageBox.Show("The registered booking is successful.");

                Booking_System.welcome wel = new Booking_System.welcome();
                wel.Show();
                this.Hide();
            }
        }


        //Show section
        MySqlDataAdapter myapdater;
        private void btn_showview_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            myapdater = new MySqlDataAdapter();
            BindingSource bindingSource = new BindingSource();
            string query;

            booking_data.DataSource = bindingSource;
            db_customer_detail.connection_open();
                if (login.name == "Admin")
                {
                    query = "select * from customer_booking";
                }
                else
                {
                    query = "select * from customer_booking where customer_name = '" + login.name + "'";
                }
            myapdater.SelectCommand = new MySqlCommand(query, db_customer_detail.MySqlConnector);
            myapdater.Fill(dt);
            bindingSource.DataSource = dt;
            booking_data.DataSource = bindingSource;
        }

        //Cancel section
        private void btn_cancelview_Click(object sender, EventArgs e)
        {
            Booking_System.welcome wel = new Booking_System.welcome();
            wel.Show();
            this.Hide();
        }

        MySqlDataReader reader;

        // page load
        private void booking_Load(object sender, EventArgs e)
        {
            string choice = welcome.set_choice;
            if (choice == "book")
            {
                txt_book_name.Text = login.name;
                
            }
            else if (choice == "setA_booking")
            {
                txt_book_name.Text = login.name;
                txt_book_menu.Text = welcome.set_menu_order;
            }
            else if (choice == "setB_booking")
            {
                txt_book_name.Text = login.name;
                txt_book_menu.Text = welcome.set_menu_order;
            }
            else if (choice == "setC_booking")
            {
                txt_book_name.Text = login.name;
                txt_book_menu.Text = welcome.set_menu_order;
            }
            else if (choice == "update")
            {
                string query = "Select customer_name, contact, address, menu, person_count, book_table, date, time from customer_booking where customer_name = '" + login.name + "'";
                db_customer_detail.connection_open();
                command = new MySqlCommand(query, db_customer_detail.MySqlConnector);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txt_book_name.Text = reader["customer_name"].ToString();
                    txt_book_contact.Text = reader["contact"].ToString();
                    txt_book_address.Text = reader["address"].ToString();
                    txt_book_menu.Text = reader["menu"].ToString();
                    txt_book_person.Text = reader["person_count"].ToString();
                    txt_book_table.Text = reader["book_table"].ToString();
                    txt_book_date.Text = reader["date"].ToString();
                    txt_book_time.Text = reader["time"].ToString();
                }
                command.Dispose();
                db_customer_detail.MySqlConnector.Close();
            }

        }

        //Delete section
        private void btn_deleteview_Click(object sender, EventArgs e)
        {
            db_customer_detail.connection_open();
            query = "delete from customer_booking where customer_name = '" + txt_book_name.Text + "' and contact = '" + txt_book_contact.Text + "' and date = '" + txt_book_date.Text + "' and time = '" + txt_book_time.Text + "'";
            myapdater.SelectCommand = new MySqlCommand(query, db_customer_detail.MySqlConnector);
            myapdater.Fill(dt);
            MessageBox.Show("The registered booking is deleted.");
        }
    }
}
