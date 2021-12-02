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

            Window2 okno2 = new Window2();
            okno2.Show();

        }
        private void ButtonSearchKomiks_Click(object sender, RoutedEventArgs e)
        {
            Window1 okno1 = new Window1();
            okno1.Show();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string connectionSQL = "server=127.0.0.1;uid=root;" +
                "pwd=|pryxi!Am4yZxE0N};database=komiksy";
            MySqlConnection Connect = new MySqlConnection(connectionSQL);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM komiks (Nazev,Autor,RokVydani,Popis)", Connect);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
        }
    }
}
