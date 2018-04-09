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

namespace XamlTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Размер сетки: " + MyGrid.ActualWidth + "x" + MyGrid.ActualHeight);
        }

        private void btn1Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Help;
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            txt1.Text = "Обычный текст...";
        }

        private void Btn1_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
