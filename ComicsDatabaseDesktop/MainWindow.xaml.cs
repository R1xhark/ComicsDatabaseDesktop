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

            string sql = "Select * from komiksy";
            MySqlCommand cmd = new MySqlCommand(sql, Connect);
            MySqlDataReader Reader = cmd.ExecuteReader();

          //  listView1.Items.Clear();

           /* while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.Items.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                listView1.Items.Add(lv);

            }
            Reader.Close();*/









        }
    }
}
