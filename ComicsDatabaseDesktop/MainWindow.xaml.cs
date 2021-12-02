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

        private void ButtonAddKomiks_Click(object sender,RoutedEventArgs e)
        {
            
                Window2 okno2 = new Window2();
                okno2.Show();
            
        }
        private void ButtonSearchKomiks_Click(object sender,RoutedEventArgs e)
        {
            Window1 okno1 = new Window1();
            okno1.Show();
        }

    }
}
