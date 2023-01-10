/*
 * Name: Shivam Janda
 * Date: Ocotber 22, 2022
 * Description: View Lend Out Window properties and functions
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data; 
using System.Data.SqlClient;

namespace NETD_LAB2
{
    /// <summary>
    /// Interaction logic for ViewLendOut.xaml
    /// </summary>
    public partial class ViewLendOut : UserControl
    {
        public ViewLendOut()
        {
            InitializeComponent();
            // use the fill data grid function
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            try
            { //We added the data source to our settings in order to achieve this.
                string connectString = Properties.Settings.Default.connect_string;
                //creating a new connection.
                SqlConnection cn = new SqlConnection(connectString);
                //opening the connection
                cn.Open();
                // Sql query 
                string selectionQuery = "SELECT * FROM lend";
                //Creating a command and passing the SqlCommand method the query and the connection.
                SqlCommand command = new SqlCommand(selectionQuery, cn);
            
                // retrieve data from a data source and populate tables within a DataSet
                SqlDataAdapter sda = new SqlDataAdapter(command);
             
               // This datatable is being linked with the lend table.
                DataTable dt = new DataTable("lend");
                //sda is the SqlDataAdapter
                sda.Fill(dt);

                lendOutGrid.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                // throw error message
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
