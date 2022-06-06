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

namespace WpfApp1
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

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(X.Text);
                double y = Convert.ToDouble(Y.Text);
                double Resheniye = (3 * Math.Sin(x) + 6 * Math.Cos(y)) / 2;
                Result2.Content = $"{Resheniye:###.###}";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                X.Text = null;
                Y.Text = null;
            }

        }
    }
}
