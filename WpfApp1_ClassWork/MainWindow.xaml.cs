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

namespace WpfApp1_ClassWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txt_FirstName.Background = Brushes.Yellow;
            txt_LastName.Background = Brushes.Yellow;
            Keyboard.Focus(txt_FirstName);
            txt_bottom.Visibility = Visibility.Hidden;
            
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            if (btn_Submit.Content.Equals("Click to Close the App"))
            {
                this.Close();
            }
            //MessageBox.Show("Hi");
            bool val1 = false;
            bool val2 = false;

            if (string.IsNullOrEmpty(txt_FirstName.Text))
            {
                txt_FirstName.Background = Brushes.Yellow;
                val1 = false;
                Keyboard.Focus(txt_FirstName);
                
            }
            else {
                txt_FirstName.Background = Brushes.Green;
                val1 = true;
            }

            if (string.IsNullOrEmpty(txt_LastName.Text))
            {
                txt_LastName.Background = Brushes.Yellow;
                val2 = false;
                Keyboard.Focus(txt_LastName);
            }
            else {
                txt_LastName.Background = Brushes.Green;
                val2 = true;
            }

                if (val1 == true & val2 == true)
            {
                Window1 w1 = new Window1(txt_FirstName.Text, txt_LastName.Text);
                w1.ShowDialog();
                txt_FirstName.Text = w1.GetFName();
                txt_LastName.Text = w1.GetLName();
                btn_Submit.Content = "Click to Close the App";
                txt_FirstName.Background = Brushes.Yellow;
                txt_LastName.Background = Brushes.Yellow;

                txt_bottom.Text = "Got Back the data!!";
                txt_bottom.Visibility = Visibility.Visible;
            }
        }

        private void btn_Hide_Click(object sender, RoutedEventArgs e)
        {
            if (StPan.Visibility == Visibility.Hidden)
            {
                StPan.Visibility = Visibility.Visible;
            }
            else {
                StPan.Visibility = Visibility.Hidden;
            }

        }

    }
}
