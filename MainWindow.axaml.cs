using Avalonia.Controls;
using Avalonia.Interactivity;

namespace PTZManager;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void ClickMeButton_Click(object sender, RoutedEventArgs e)
    {
        GreetingTextBlock.Text = "Button Clicked!";
    }

}