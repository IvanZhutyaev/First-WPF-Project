﻿using System.Text;
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

    void acceptButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show(textBlock.Text);
    }

    void escButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("ГАЛЯ ОТМЕНА!!!");
        textBlock.Text = "";
    }
}