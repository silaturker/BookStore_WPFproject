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
using System.Collections.ObjectModel;

namespace BookStoreExp
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {  
        

        public SecondWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            ThirdWindow objThirdWindow = new ThirdWindow();
            this.Visibility = Visibility.Hidden;               
            objThirdWindow.Show();
            
            
        }

      
        private void ComboBoxItemadventure_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox2.Items.Clear();
            ComboBox2.Items.Add("Jungle Book");
            ComboBox2.Items.Add("Treasure Island");
            ComboBox2.Items.Add("Lost World");

        }

        private void ComboBoxItemclassics_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox2.Items.Clear();
            ComboBox2.Items.Add("Jane Eyre");
            ComboBox2.Items.Add("Great Expectations");
            ComboBox2.Items.Add("The Call of the Wild");
        }

        private void ComboBoxItemscience_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox2.Items.Clear();
            ComboBox2.Items.Add("Lord of The Rings");
            ComboBox2.Items.Add("I, Robot");
            ComboBox2.Items.Add("Solaris");
        }

        private void ConfirmBox_Checked(object sender, RoutedEventArgs e)
        {
            if (ConfirmBox.IsChecked == true)
            {
                NextButton.IsEnabled = true;
            }
            else
                NextButton.IsEnabled = false;
        }
        public static ObservableCollection<string> dizi1 = new ObservableCollection<string>();

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            //dizi1.Add(ComboBox1.Text.ToString());
            dizi1.Add(ComboBox2.Text.ToString());
            MessageBox.Show("Selected Book Added!");

        }
    }

}
