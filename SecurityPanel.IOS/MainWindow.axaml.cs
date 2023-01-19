using Avalonia.Controls;

namespace SecurityPanel.IOS;

public partial class MainWindow : Window
{
    public string Logo => "avares://SecurityPanel.Share/Icons/Logo.png";
    public MainWindow()
    {
        InitializeComponent();
    }
}