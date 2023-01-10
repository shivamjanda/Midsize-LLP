/*
 * Name: Shivam Janda
 * Date: Ocotber 22, 2022
 * Description: Main Window properties and functions
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Allows us to move the window
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        //If the selection is changed, load the appropriate custom user control.
        private void SettingsListViewSelectionChanged(object sender, SelectionChangedEventArgs e )
       {
            ListView listView = e.Source as ListView;
            if (listView!=null)
            {
                ContentPanel.Children.Clear();
            }


            if (listView.SelectedItem.Equals(changeLendOut))
            {
                // LendOut is a user control
                Control controlLendOut = new LendOut();
                //Settings Content Panel is the grid in our MainWindow.xaml
                this.ContentPanel.Children.Add(controlLendOut);
            }

            if (listView.SelectedItem.Equals(changeViewLendOut))
            {
                // ViewLendOut is a user control
                Control controlViewLendOut = new ViewLendOut();
                //Settings Content Panel is the grid in our MainWindow.xaml
                this.ContentPanel.Children.Add(controlViewLendOut);
            }

            if (listView.SelectedItem.Equals(changeSearch))
            {
                // ViewLendOut is a user control
                Control controlSearch = new Search();
                //Settings Content Panel is the grid in our MainWindow.xaml
                this.ContentPanel.Children.Add(controlSearch);
            }


        }
    }

    
     
}
