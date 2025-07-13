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
        StackPanel stackPanel = new StackPanel();
        Button squareButton = new Button() {Width = 100, Height = 100, HorizontalAlignment = HorizontalAlignment.Right, VerticalAlignment = VerticalAlignment.Center, Padding = new Thickness(0), VerticalContentAlignment = VerticalAlignment.Center };
        Button squareButton1 = new Button()
        {
            Width = 50, Height = 50, HorizontalAlignment = HorizontalAlignment.Right,
            VerticalAlignment = VerticalAlignment.Center, Padding = new Thickness(0),
            VerticalContentAlignment = VerticalAlignment.Center
        };
        squareButton.Content = squareButton1;
        stackPanel.Children.Add(squareButton);
        StackPanel stackPanel1 = new StackPanel(){Orientation = Orientation.Vertical, Margin = new Thickness(0), HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Center, Width = 300, Height = 300, Background = new SolidColorBrush(Color.FromRgb(155, 255, 255))};

        Button squareButton3 = new Button() {Width = 100, Height = 100, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Center, Padding = new Thickness(0), VerticalContentAlignment = VerticalAlignment.Center };

        stackPanel1.Children.Add(squareButton3);
        stackPanel.Children.Add(stackPanel1);
        window.AddChild(stackPanel);
        
        
        


    }
    
    
    
}