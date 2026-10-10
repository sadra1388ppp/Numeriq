using System.Windows;
namespace ClickCounter;

public partial class MainWindow : Window
{
    int clickCount = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void ClickButton_Click(object sender, RoutedEventArgs e)
    {
        clickCount++;
        CountText.Text = clickCount.ToString();
    }

    private void DecreaseButton_Click(object sender, RoutedEventArgs e)
    {
        clickCount--;
        CountText.Text = clickCount.ToString();
    }
}