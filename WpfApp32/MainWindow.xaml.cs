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

namespace WpfApp32
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static int f(int x)
        {
            int a = x / 10;
            int b = x % 10;
            return b * 10 + a;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(Boxx.Text);
            int x1 = f(x);
            txtOtv.Text = $" {x1}";
        }
    }
}
