using Avalonia.Controls;
using SecurityPanel.IOS.ViewModels;

namespace SecurityPanel.IOS;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}