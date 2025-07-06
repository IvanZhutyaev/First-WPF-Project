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

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    

    private void Spawn_ten_btns(object sender, RoutedEventArgs e)
    {
        for (int i = 0; i < 10; i++)
        {
            
            Button myButton = new Button();
            myButton.Width = 60;
            myButton.Height = 30;
            myButton.Margin = new Thickness(10+i*10, 10+i*10, 10, 10);
            Panel.SetZIndex(myButton, i);
            myButton.Content = $"Button+{i}";
            myButton.Click+=WriteName;
            Grid.Children.Add(myButton);
            
        }
    }

    private void WriteName(object sender, RoutedEventArgs e)
    {
        var btn = sender as Button;
        MessageBox.Show(btn.Content.ToString());
    }
    
    
}