using System;
using lib2;
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

namespace пр2_головиной
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

        int[] mas;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             int sum; 
            //функция
            Pr2.Function( out sum, mas);
            string sumSTR = sum.ToString();
            //вывод суммы
            sum1.Text = sumSTR.ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //получ диапазон
            int randmax = Convert.ToInt32(max.Text);
            //кол-во ячеек
            int n = Convert.ToInt32(valn.Text);
            //заполн табл рандомом
            Pr2.Massiv(out  mas, n, randmax);
            //вывод массива
            mas1.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;

        }
    }
}
