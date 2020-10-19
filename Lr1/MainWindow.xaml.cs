using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary1;

namespace l1_1v
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ClassLR Sum = new ClassLR(TbValue1.Text, TbValue2.Text);
            answ.Content = Sum.getSum();
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TbValue2.Text.Length == 0) return;
            int x;
            if (int.TryParse(TbValue2.Text, out x))
            {
                if (x < 0) TbValue2.Text = "0";
                if (x > 1000000000) TbValue2.Text = "1000000000";
            }
            else
                TbValue2.Text = "";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ClassLR Otr = new ClassLR(TbValue1.Text, TbValue2.Text);
            answ.Content = Otr.getOtr();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ClassLR Ymn = new ClassLR(TbValue1.Text, TbValue2.Text);
            answ.Content = Ymn.getYmn();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ClassLR Del = new ClassLR(TbValue1.Text, TbValue2.Text);
            answ.Content = Del.getDel();
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {

            TbValue1.Clear();
            TbValue2.Clear();
            ClassLR Clear = new ClassLR(TbValue1.Text, TbValue2.Text);
            answ.Content = Clear.getClear();
        }

        private void TbValue1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TbValue1.Text.Length == 0) return;
            int x;
            if (int.TryParse(TbValue1.Text, out x))
            {
                if (x < 0) TbValue1.Text = "0";
                if (x > 1000000000) TbValue1.Text = "1000000000";
            }
            else
                TbValue1.Text = "";
        }
    }
}



