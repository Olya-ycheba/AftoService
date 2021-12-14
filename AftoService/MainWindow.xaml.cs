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

namespace AftoService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentArea.Content = new Page1();
        }


        //Для того, чтобы убедиться, что страницы листаются
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new Page1();
            ColorBtnRaplace(btn1, btn2, btn3);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new Page2();
            ColorBtnRaplace(btn2, btn1, btn3);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new Page3();
            ColorBtnRaplace(btn3, btn1, btn2);
        }

        //перекраска кнопок
        private void ColorBtnRaplace(Button btn1, Button btn2, Button btn3)
        {
            btn1.Background = new SolidColorBrush(Color.FromRgb(255, 156, 26));
            btn1.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            btn2.Foreground = new SolidColorBrush(Color.FromRgb(255, 156, 26));
            btn2.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            btn3.Foreground = new SolidColorBrush(Color.FromRgb(255, 156, 26));
            btn3.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }
    }
}
