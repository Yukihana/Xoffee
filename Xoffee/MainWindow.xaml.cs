using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Xoffee;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Go_Click(object sender, RoutedEventArgs e)
    {
        LoadThis(AddressText.Text);
    }

    private void Home_Click(object sender, RoutedEventArgs e)
    {
        LoadThis("./www/Home.xaml");
    }

    private void LoadThis(string path)
    {
        using FileStream fs = new(path, FileMode.Open);
        var page = XamlReader.Load(fs);
        ContentSpace.Content = page as Page;
    }
}