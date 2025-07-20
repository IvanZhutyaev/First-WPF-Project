using Microsoft.VisualBasic;
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

namespace FirstWPFProject;

public partial class MainWindow : Window
{
 
    public MainWindow()
    {
        InitializeComponent();

    }



    private void TextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Back)
        {
            
            textBlock1.Text = textBlock1.Text.Substring(0, e.Key.ToString().Length - 1); ;
        }
        else
        {
            textBlock1.Text += e.Key.ToString();
            
        }
        
        
    }



}