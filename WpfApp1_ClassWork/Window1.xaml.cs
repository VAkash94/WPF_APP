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

namespace WpfApp1_ClassWork
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(String fname, String lname)
        {
            InitializeComponent();
            txt_fname.Text = fname;
            txt_lname.Text = lname;
            Keyboard.Focus(txt_fname);
            //txt_fname.SelectionStart = txt_fname.Text.Length - 1;
            txt_lname.SelectionStart = txt_lname.Text.Length;
        }

        private void btn_SendBack_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow mw;
            //mw.btn_Submit.Content = "Click to close App";
            this.Close();
        }
        public String GetFName()
        {
            return txt_fname.Text;
        }
        public String GetLName()
        {
            return txt_lname.Text;
        }
    }
}
