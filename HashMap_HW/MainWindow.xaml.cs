using System;
using System.Collections;
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

namespace HashMap_HW

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
{ public partial class MainWindow : Window

  {
    Hashtable hashtable;
    public MainWindow()
    { 
        InitializeComponent();
        hashtable = new Hashtable();
     }

    private void Add_Botton_Click(object sender, RoutedEventArgs e)
    {   //add
        hashtable.Add(Key_txtbox.Text, Value_txtbox.Text);

        Key_txtbox.Text = String.Empty;
        Value_txtbox.Text = string.Empty;

    }
   
        
        private void ReMove_Botton_Click(object sender, RoutedEventArgs e)
     {   //remove
        hashtable.Remove(Key_txtbox.Text);
       
        Key_txtbox.Text = String.Empty;     
        Value_txtbox.Text = String.Empty;  
      }
        

        private void ShowAll_Button_Click(object sender, RoutedEventArgs e)
        {   //show
            ICollection iconllection = hashtable.Keys;
            foreach (string key in iconllection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}
