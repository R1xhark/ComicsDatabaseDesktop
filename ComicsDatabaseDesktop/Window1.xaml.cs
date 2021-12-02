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
using System.Windows.Shapes;
using ComicsDatabaseDesktop.Database;
using MySql.Data.MySqlClient;

namespace ComicsDatabaseDesktop
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        public void ButtonVyhledejKomicks(object sender,RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(VyhledejTextBox.Text))
            {
                string PripojeniSearch;
                PripojeniSearch = "server=127.0.0.1;uid=root;" +
                    "pwd=|pryxi!Am4yZxE0N};database=komiksy";
                MySqlConnection connection= new MySqlConnection(PripojeniSearch);

                try {
                    connection.Open();
                    MySqlCommand search= new MySqlCommand("SELECT* FROM komiks_db.komiksy WHERE id=" + VyhledejTextBox.Text);
                    MessageBox.Show("uspech");
                    connection.Close();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Pripojeni k databazi selhalo\n" + ex.ToString(), "Error : Pripojeni k databazi SQL selhalo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else{
                MessageBox.Show("Nic jsi nezadal :)","Error: Zadny input",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
