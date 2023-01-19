using System;
using Avalonia;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using SecurityPanel.Window.ViewModels;

namespace SecurityPanel.Window;

public partial class MainWindow : Avalonia.Controls.Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}