using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_System.Controller
{
    class CustomerDetailDB
    {
        public MySqlConnection MySqlConnector;
        string connection = "server = localhost; uid = root; pwd =; database = ncc_booking ; port =8111";
        public void connection_open()
        {
            try
            {
                MySqlConnector = new MySqlConnection(connection);
                MySqlConnector.Open();
            }

            catch (Exception error_message)
            {
                MessageBox.Show($"error occur : {error_message.Message}");
            }
        }
    }

}
