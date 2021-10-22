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

namespace BookStoreExp
{
    /// <summary>
    /// Interaction logic for FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            if (t1.Text.Equals("student") && (PasswordBox.Password.Equals("123456"))) 
               {
                    SecondWindow objsecondWindow = new SecondWindow();
                    this.Visibility = Visibility.Hidden;
                    objsecondWindow.Show();

                }
            else
                { MessageBox.Show("login failed"); }
                
               
                



         }
      
     }
 }
    

