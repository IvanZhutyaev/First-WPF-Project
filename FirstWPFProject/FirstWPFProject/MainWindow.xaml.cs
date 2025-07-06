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

    private void Red(object sender, RoutedEventArgs e)
    {
        ColorfullBtn.Background= new SolidColorBrush(Colors.Red);
    }
    private void Green(object sender, RoutedEventArgs e)
    {
        ColorfullBtn.Background= new SolidColorBrush(Colors.Green);
    }
    private void Blue(object sender, RoutedEventArgs e)
    {
        ColorfullBtn.Background= new SolidColorBrush(Colors.Blue);
    }
    private void Yellow(object sender, RoutedEventArgs e)
    {
        ColorfullBtn.Background= new SolidColorBrush(Colors.Yellow);
    }
    private void Purple(object sender, RoutedEventArgs e)
    {
        ColorfullBtn.Background= new SolidColorBrush(Colors.Purple);
    }
}