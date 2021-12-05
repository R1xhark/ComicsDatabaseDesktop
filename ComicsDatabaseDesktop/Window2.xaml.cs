﻿using System;
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
using ComicsDatabaseDesktop.Database;

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
            string Pripojeni;
            Pripojeni = "server=127.0.0.1;uid=root;" +
                "pwd=|pryxi!Am4yZxE0N};database=komiksy";
            MySqlConnection ObrazekConn = new MySqlConnection(Pripojeni);
            string pathObrazekKeKomiksu = @"ObrazekPath.Text";
            try
            {
                ObrazekConn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO komiksy(ObrazekPath)Values(" +pathObrazekKeKomiksu+ ")", ObrazekConn);
                MessageBox.Show("Obrazek byl uspesne pridanDotabaze");
                ObrazekConn.Close();
            }

            catch (MySqlException ex)
            {

                MessageBox.Show("Pripojeni k databazi selhalo\n" + ex.ToString(), "Error : Pripojeni k databazi SQL selhalo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public void ButtonPridejKomics(object sender,RoutedEventArgs e)
        {
            string Pripojeni;
            Pripojeni = "server=127.0.0.1;uid=root;" +
                "pwd=|pryxi!Am4yZxE0N};database=komiksy";

            if (!String.IsNullOrWhiteSpace(Jmeno.Text) && !String.IsNullOrWhiteSpace(Autor.Text)) {
                MySqlConnection conn = new MySqlConnection(Pripojeni);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO komiksy(Nazev,Autor,RokVydani,Popis)Values("+Jmeno.Text+Autor.Text+RokVydani.Text+Popis.Text+")",conn);
                MessageBox.Show("Komiks byl uspesne pridan do databaze !");
                conn.Close();
            }

            catch (MySqlException ex)
            {

                MessageBox.Show("Pripojeni k databazi selhalo\n" + ex.ToString(), "Error : Pripojeni k databazi SQL selhalo",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            }
            else
            {
                MessageBox.Show("Prosim vyplnte pole autor a nazev","zadny input", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
