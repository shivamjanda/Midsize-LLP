/*
 * Name: Shivam Janda
 * Date: Ocotber 22, 2022
 * Description: Lend Out Window properties and functions
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
using System.Data.SqlClient;

namespace NETD_LAB2
{
    /// <summary>
    /// Interaction logic for LendOut.xaml
    /// </summary>
    public partial class LendOut : UserControl
    {
        public LendOut()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validation function
        /// </summary>
        /// <returns></returns>
        private string validation()
        {
            string errorMessage = "";
            int ID;

            // if the name text box is empty then add the error message to the error message string
            if (txtName.Text == string.Empty)
            {
                errorMessage += "Name cannot be empty!";
            }

            // if the name description text box is empty then add the error message to the error message string
            if (txtDesc.Text == string.Empty)
            {
                errorMessage += "Description cannot be empty!";
            }

            // if the phone number text box is empty then add the error message to the error message string
            if (txtPhone.Text == string.Empty)
            {
                errorMessage += "Phone Number cannot be empty!";
            }

            // if the user entered employee id is not a whole integer then add the error message to the error message string
            if (!int.TryParse(txtEmpID.Text, out ID))
            {
                errorMessage += "ID has to be a whole number!";
            }

            // return the error message string
            return errorMessage;
          
        }

        private void addToDatabse(object sender, RoutedEventArgs e)
        {
            string errorMessage = validation();
            // if the returned error message string from the validation function is not empty (there is an error) then
            if (errorMessage != string.Empty)
            {
                // show the message box with the error message
                MessageBox.Show(errorMessage, "error");
            }
            else 
                // otherwise populate the database
            try
            {
                string connectString = Properties.Settings.Default.connect_string;
                //creating a new connection
                SqlConnection cn = new SqlConnection(connectString);
                //opening the connection
                cn.Open();

                validation();
            
                // Inserting the query into the lend table
                string insertQuery = "INSERT INTO lend ([name], [empID], [desc], [phone]) VALUES('" + txtName.Text + "', '" + txtEmpID.Text + "', '" + txtDesc.Text + "', '" + txtPhone.Text + "')";
                //creating a new command and passing it the query + the connection.
                SqlCommand command = new SqlCommand(insertQuery, cn);
                // Executing the query
                command.ExecuteNonQuery();
                // closing the connection
                cn.Close();
                // message box popup if the values were added to the database properly
                MessageBox.Show("Added Sucessfully!");

                // emtpy the text box fields once added sucessfully
                txtName.Text = string.Empty;
                txtEmpID.Text = string.Empty;
                txtDesc.Text = string.Empty;
                txtPhone.Text = string.Empty;

            }
            // catching any errors that might occur
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
