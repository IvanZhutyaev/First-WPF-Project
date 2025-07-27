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


    private void TetxBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        int val;
        if(!Int32.TryParse(e.Text, out val) && e.Text != "-")
        {
            e.Handled = true;
        }
    }

    private void TetxBox_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key==Key.Space)
        {
            e.Handled = true;
        }
    }

    private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
    {
        char text = txtBox.Text[0];
        if(char.IsLetter(text))
            MessageBox.Show("Буква");
        else if(char.IsDigit(text))
            MessageBox.Show("Цифра");
        else if (char.IsSymbol(text)|| char.IsPunctuation(text))
            MessageBox.Show($"Symbol: {text}");
        




    }

    private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        e.CanExecute = true;
    }
}