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
using MySql.Data.MySqlClient;


namespace ComicsDatabaseDesktop
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        public void ButtonPridejObrazek(object sender,RoutedEventArgs e)
        {
            //zatim nic
        }
        public void ButtonPridejKomics(object sender,RoutedEventArgs e)
        {
            string Pripojeni;
            Pripojeni = "server=127.0.0.1;uid=root;" +
                "pwd=|pryxi!Am4yZxE0N};database=komiksy";

            if (!String.IsNullOrWhiteSpace(Jmeno.Text) && !String.IsNullOrWhiteSpace(Autor.Text) && !String.IsNullOrWhiteSpace(RokVydani.Text) && !String.IsNullOrWhiteSpace(Popis.Text)) {
                MySqlConnection conn = new MySqlConnection(Pripojeni);
            try
            {
                conn.Open();
                    
                string sqlCmd = "insert into komiksy(Nazev,Autor, RokVydani,Popis, ObrazekPath)values('"+this.Jmeno.Text+"','"+this.Autor.Text+"','"+this.RokVydani.Text+"','"+this.Popis.Text+"')";
                MySqlCommand read = new MySqlCommand(sqlCmd, conn);
                MySqlDataReader reader;
                reader = read.ExecuteReader();
                MessageBox.Show("Komiks byl uspesne pridan do databaze !");
                    Jmeno.Clear();
                    Autor.Clear();
                    RokVydani.Clear();
                    Popis.Clear();
                    conn.Close();

            }

            catch (MySqlException ex)
            {

                MessageBox.Show("Pripojeni k databazi selhalo" + ex.ToString(), "Error : Pripojeni k databazi SQL selhalo",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            }
            else
            {
                MessageBox.Show("Prosim vyplnte vsechny pole","Chybejici input", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
