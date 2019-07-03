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
using System.Data.SQLite;

namespace kursach
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public int time = 0;
        public int XoD = 0;
         SQlite sq = new SQlite();
        public Window1(int timer , int g)
        {
            InitializeComponent();

            InitializeComponent();
            scoregrid.ItemsSource = sq.output();
            scoregrid.Items.Refresh();
            time = timer;
            XoD = g ;
            scoregrid.IsReadOnly = true;
            
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            add.IsEnabled = false;
            sq.input(time, name.Text , XoD);
            scoregrid.ItemsSource = sq.output();
            scoregrid.Items.Refresh();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //this.DialogResult = true;
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (name.Text == "" || name.Text == "Имя")
            {
                add.IsEnabled = false;
            }
            else
            {
                add.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

