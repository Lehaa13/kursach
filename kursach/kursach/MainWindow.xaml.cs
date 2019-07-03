using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Data.SQLite;
using Microsoft.Win32;

namespace kursach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game game = new Game();
        int sec = 0;
        int g = 0;
        bool flag = false;
        int n;

        int button;
        Button[] Buttons = new Button[16];

        public MainWindow()


        {
            InitializeComponent();
            ugr.Rows = 4;
            ugr.Columns = 4;
            //указываются размеры сетки (число ячеек * (размер кнопки в ячейки + толщина её границ))
            ugr.Width = 4 * (110 + 4);
            ugr.Height = 4 * (110 + 4);
            //толщина границ сетки
            game.game(4);


            for (int i = 0; i < 16; i++)
            {
              
                {
                    Buttons[i] = new Button();
                    //создание кнопки
                    Buttons[i].Width = 110;
                    Buttons[i].Height = 110;
                    //запись номера кнопки
                    Buttons[i].Tag = i;
                    Buttons[i].Content = i;
                    //толщина границ кнопки
                    //btn.Margin = new Thickness();
                    //при нажатии кнопки, будет вызываться метод Btn_Click
                    int x = i % 4;
                    int y = i / 4;
                    Buttons[i].Click += ButtonClick;
                    //добавление кнопки в сетку
                    ugr.Children.Add(Buttons[i]);
                }
            }
            game.Shuffle();
        }

        System.Windows.Threading.DispatcherTimer Timer;




        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            g++;
            XoD.Content = g.ToString(); /*\\ s4et*/



            //int Buttons = Convert.ToInt32(Buttons[].Tag);
            //button = Convert.ToInt32(Buttons[1].Tag);
            //button = Convert.ToInt32(Buttons[2].Tag);
            //button = Convert.ToInt32(Buttons[3].Tag);
            //button = Convert.ToInt32(Buttons[4].Tag);
            //button = Convert.ToInt32(Buttons[5].Tag);
            //button = Convert.ToInt32(Buttons[6].Tag);
            //button = Convert.ToInt32(Buttons[7].Tag);
            //button = Convert.ToInt32(Buttons[8].Tag);
            //button = Convert.ToInt32(Buttons[9].Tag);
            //button = Convert.ToInt32(Buttons[10].Tag);
            //button = Convert.ToInt32(Buttons[11].Tag);
            //button = Convert.ToInt32(Buttons[12].Tag);
            //button = Convert.ToInt32(Buttons[13].Tag);
            //button = Convert.ToInt32(Buttons[14].Tag);
            //button = Convert.ToInt32(Buttons[15].Tag);

            button = Convert.ToInt32(((Button)sender).Tag);
            //((Button)sender).Tag.Content.ToString;
           // MessageBox.Show(((Button)sender).Tag.ToString());
       
          //  ugr.Children()


            game.Shift(button);
           
            Refresh();
          
            if (flag == true)
            {
                
                //int W = imag.PixelWidth / 4;
                //int H = imag.PixelHeight / 4;
                //int button = Convert.ToInt32(((Button)sender).Tag);

                int W = imag.PixelWidth / 4;
                int H = imag.PixelHeight / 4;

                //vibor(button0, W, H, 0);
                //vibor(button1, W, H, 1);
                //vibor(button2, W, H, 2);
                //vibor(button3, W, H, 3);
                //vibor(button4, W, H, 4);
                //vibor(button5, W, H, 5);
                //vibor(button6, W, H, 6);
                //vibor(button7, W, H, 7);
                //vibor(button8, W, H, 8);
                //vibor(button9, W, H, 9);
                //vibor(button10, W, H, 10);
                //vibor(button11, W, H, 11);
                //vibor(button12, W, H, 12);
                //vibor(button13, W, H, 13);
                //vibor(button14, W, H, 14);
                //vibor(button15, W, H, 15);

                //for (int i = 0; i < 16; i++)
                //{
                //    vibor(button, W, H, i);
                //}

            }


            if (game.isEndGame())
              
            {
                Window1 w1 = new Window1(sec,g);
               



                w1.Show();
                
                this.Close();

                

            }


        }

        private void BlockButtons()
        {
            for (int i = 0; i < 16; i++)
            {
                Buttons[i].IsEnabled = false;
            }
        }

        private void UnblockButtons()
        {
            for (int i = 0; i < 16; i++)
            {
                Buttons[i].IsEnabled = true;
            }
        }

        private Button _Button(int button)
        {
           
            switch (button)
            {
               
                case 1: return Buttons[1];
                case 2: return Buttons[2];
                case 3: return Buttons[3];
                case 4: return Buttons[4];
                case 5: return Buttons[5];
                case 6: return Buttons[6];
                case 7: return Buttons[7];
                case 8: return Buttons[8];
                case 9: return Buttons[9];
                case 10: return Buttons[10];
                case 11: return Buttons[11];
                case 12: return Buttons[12];
                case 13: return Buttons[13];
                case 14: return Buttons[14];
                case 15: return Buttons[15];
                case 16: return Buttons[16];
                default: return null;
            }
        }

        private void StartGameClick(object sender, RoutedEventArgs e)
        {
            //    StartGame();

            //    flag = false;

            //    //button0.Background = Brushes.LightGray;
            //    //button1.Background = Brushes.LightGray;
            //    //button2.Background = Brushes.LightGray;
            //    //button3.Background = Brushes.LightGray;
            //    //button4.Background = Brushes.LightGray;
            //    //button5.Background = Brushes.LightGray;
            //    //button6.Background = Brushes.LightGray;
            //    //button7.Background = Brushes.LightGray;
            //    //button8.Background = Brushes.LightGray;
            //    //button9.Background = Brushes.LightGray;
            //    //button10.Background = Brushes.LightGray;
            //    //button11.Background = Brushes.LightGray;
            //    //button12.Background = Brushes.LightGray;
            //    //button13.Background = Brushes.LightGray;
            //    //button14.Background = Brushes.LightGray;
            //    //button15.Background = Brushes.LightGray;



            }

        private void Refresh()
        {
            for (int i = 0; i < 16; i++)
            {
                
                Buttons[i].Content = game.GetNumber(i).ToString();
                Buttons[i].Visibility = (game.GetNumber(i) > 0) ? Visibility.Visible : Visibility.Hidden;
            }
        }

        private void StartGame()
        {
           
            vr.Content = sec.ToString(); 
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
           // UnblockButtons();
            game.Start();
            for (int i = 0; i < 10; i++)
            {
                game.Shuffle();
            }
            Refresh();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
           
            sec++;
            vr.Content = sec.ToString();
        }

        private void Main_Loaded(object sender, RoutedEventArgs e)
        {
            StartGame();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
         
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            
           
            if (e.Key == Key.I)
            {
                
                MessageBox.Show("Вы победили!", "Победа");
                if ((MessageBox.Show((sec.ToString() + " секунд. Записать время?"), "", MessageBoxButton.YesNo) == MessageBoxResult.Yes))
                {
                    Timer.Stop();
                    Window1 w1 = new Window1(sec,g);
                    w1.Owner = this;
                    if (w1.ShowDialog() == true)

                    {

                        if ((MessageBox.Show("Начать игру заново?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes))
                        {
                            Timer.Start();
                            sec = 0;
                            g = 0;
                            
                            StartGame();
                        }

                        else
                        {
                           // BlockButtons();
                        }
                    }
                }
                else
                {
                    //BlockButtons();
                }
            }
        }

        BitmapImage imag;



        private void vibor(Button Buttons, int W, int H, int n)
        {
            ImageBrush ib = new ImageBrush();

            //изображение будет выведено без растяжения/сжатия
            ib.AlignmentX = AlignmentX.Left;
            ib.AlignmentY = AlignmentY.Top;
            ib.Stretch = Stretch.None;

            //участок изображения который будет нарисован
            //в данном случае, второй кадр первой строки
            int num = int.Parse(Buttons.Content.ToString());

            double px = (num % 4) * W;
            double py = (num / 4) * H;

            ib.Viewbox = new Rect(px, py, px + W, py + H);
            ib.ViewboxUnits = BrushMappingMode.Absolute;
            ib.ImageSource = imag;

            Buttons.Background = ib;


        }

        private void LoadingImage(object sender, RoutedEventArgs e)
        {

            OpenFileDialog dl = new OpenFileDialog();
            dl.ShowDialog();



            imag = new BitmapImage(new Uri(dl.FileName, UriKind.Absolute));

            flag = true;

            int W = imag.PixelWidth % 4;
            int H = imag.PixelHeight / 4;

            vibor(Buttons[0], W, H, 0);
            vibor(Buttons[1], W, H, 1);
            vibor(Buttons[2], W, H, 2);
            vibor(Buttons[3], W, H, 3);
            vibor(Buttons[4], W, H, 4);
            vibor(Buttons[5], W, H, 5);
            vibor(Buttons[6], W, H, 6);
            vibor(Buttons[7], W, H, 7);
            vibor(Buttons[8], W, H, 8);
            vibor(Buttons[9], W, H, 9);
            vibor(Buttons[10], W, H, 10);
            vibor(Buttons[11], W, H, 11);
            vibor(Buttons[12], W, H, 12);
            vibor(Buttons[13], W, H, 13);
            vibor(Buttons[14], W, H, 14);
            vibor(Buttons[15], W, H, 15);
            //vibor(Buttons[16], W, H, 0);
            //Buttons = Convert.ToInt32(((Button)sender).Tag);

        }

        private void LoadingTabl(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1(sec,g);
            w1.Owner = this;
            if (w1.ShowDialog() == true) ;
        }
    }
}


