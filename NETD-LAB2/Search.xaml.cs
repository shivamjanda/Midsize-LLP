/*
 * Name: Shivam Janda
 * Date: Ocotber 28, 2022
 * Description: Search window properties and functions
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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : UserControl
    {
        public Search()
        {
            InitializeComponent();
        }

        private void click_search(object sender, RoutedEventArgs e)
        {

            int id;
            string errorMessage = "";

            // if the text entered for id is not a whole number
            if (!int.TryParse(txtID.Text, out id))
            {
                errorMessage = "Enter a whole id number.";
            }

            // if the error message string is not empty 
            if (errorMessage != string.Empty)
            {
                MessageBox.Show(errorMessage, "");
            }
            else 

            try
            {
                // database connection
                string connectString = Properties.Settings.Default.connect_string;
                SqlConnection cn = new SqlConnection(connectString);
                cn.Open();

                // Sql query  that equals to id entered
                string selectionQuery = "SELECT * FROM lend WHERE empID = " + id;
                SqlCommand command = new SqlCommand(selectionQuery, cn);

                // retrieve data from a data source and populate tables within a DataSet
                SqlDataAdapter sda = new SqlDataAdapter(command);

               // This datatable is being linked with the lend table.
                DataTable dt = new DataTable("search");
                sda.Fill(dt);


                gridSearch.ItemsSource = dt.DefaultView;

                // if there are no rows loading which also means there is no matching id then 
                if (gridSearch.Items.Count == 0)
                {
                        // output error message
                    errorMessage = "Employee ID does not exist";
                    MessageBox.Show(errorMessage, "");
                }
            }

            catch(Exception ex)
            {
                // throw error message
                MessageBox.Show(ex.ToString());
            }
        }

        // Data grid for numbering each row
        private void loading_row (object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }
    }
}
