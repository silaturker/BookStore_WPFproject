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
using System.Data;

namespace BookStoreExp
{
    /// <summary>
    /// Interaction logic for ThirdWindow.xaml
    /// </summary>
    public partial class ThirdWindow : Window
    {   
        public ThirdWindow()
        {
            InitializeComponent();
            foreach (string element in SecondWindow.dizi1)
            {
                listbox1.Items.Add(element.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SecondWindow.dizi1.Remove((string)listbox1.SelectedItem);
            listbox1.Items.Remove(listbox1.SelectedItem);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SecondWindow ssecondWindow = new SecondWindow();
            this.Visibility = Visibility.Hidden;
            ssecondWindow.Show();
        }
        private void Grid_loaded(object sender, RoutedEventArgs e)
        {

        }

      
    }
}
