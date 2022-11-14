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
    public partial class welcome : Form
    {
        public static welcome wel;
        public static string set_menu_order, set_choice;
        
        public welcome()
        {
            InitializeComponent();
        }

        // Open with Login name
        private void welcome_Load(object sender, EventArgs e)
        {
            btn_user_loginshow.Text = login.name;
        }

        // link to review page
        private void btn_review_Click(object sender, EventArgs e)
        {
            Booking_System.review rev = new Booking_System.review();
            rev.Show();
            this.Show();
        }

        // Reach to booking page
        private void btn_booking_Click(object sender, EventArgs e)
        {
            if ( login.name == "Admin")
            {
                Booking_System.booking admin_view = new Booking_System.booking();
                admin_view.Show();
                this.Show();
            }
            else
            {
                set_choice = "book";
                booking bk = new booking();
                bk.Show();
                this.Hide();
            }
            
        }

        // Reach to updated booking page
        private void btn_updating_Click(object sender, EventArgs e)
        {
            set_choice = "update";
            booking bk = new booking();
            bk.Show();
            this.Hide();

        }

        //Set A Menu 
        private void setA_menu_Click(object sender, EventArgs e)
        {
            set_choice = "setA_booking";
            booking bk = new booking();
            set_menu_order = "Set A";
            bk.Show();
            this.Hide();

        }
        
        //Set B Menu 
        private void setB_menu_Click(object sender, EventArgs e)
        {
            set_choice = "setB_booking";
            booking bk = new booking();
            set_menu_order = "Set B";
            bk.Show();
            this.Hide();
        }
        
        //Set C Menu 
        private void setC_menu_Click(object sender, EventArgs e)
        {
            set_choice = "setC_booking";
            booking bk = new booking();
            set_menu_order = "Set C";
            bk.Show();
            this.Hide();
        }

        //Reach to customer show review page
        private void btn_customer_review_Click(object sender, EventArgs e)
        {
            Booking_System.customer_show_review cus_rev = new Booking_System.customer_show_review();
            cus_rev.Show();
            this.Show();
        }

        //Reach to checkout page
        private void btn_checkout_Click(object sender, EventArgs e)
        {
            Booking_System.checkout bill = new Booking_System.checkout();
            bill.Show();
            this.Show();
        }

        //Reach to login page
        private void btn_logout_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

    }
}
