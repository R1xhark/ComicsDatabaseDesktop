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
using MySql.Data.MySqlClient;
using System.Data;

namespace ComicsDatabaseDesktop
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

        private void ButtonAddKomiks_Click(object sender, RoutedEventArgs e)
        {

            var pridejKomiks = new Window2();
            pridejKomiks.Show();

        }
        private void ButtonSearchKomiks_Click(object sender, RoutedEventArgs e)
        {
            string connectionSQL = "server=127.0.0.1;uid=root;" +
                   "pwd=|pryxi!Am4yZxE0N};database=komiksy";
            MySqlConnection connect = new MySqlConnection(connectionSQL);
           
            try
            {
                connect.Open();

                string sql = "select *from komiksy ";
                MySqlCommand sqlCmd = new MySqlCommand(sql, connect);
                sqlCmd.ExecuteNonQuery();
                
                var dataAdapter= new MySqlDataAdapter(sqlCmd);
                var dTableKomiksy = new DataTable();
                dataAdapter.Fill(dTableKomiksy);
                KomiksySeznam.ItemsSource = dTableKomiksy.DefaultView;
                dataAdapter.Update(dTableKomiksy);

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}