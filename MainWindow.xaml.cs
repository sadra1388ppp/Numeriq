using System.Windows;
using System.Windows.Media;

namespace ClickCounter;

public partial class MainWindow : Window
{
    private int clickCount = 0;
    private bool isDarkMode = false;

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

    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        clickCount = 0;
        CountText.Text = clickCount.ToString();
    }

    private void ThemeButton_Click(object sender, RoutedEventArgs e)
    {
        isDarkMode = !isDarkMode;

        if (isDarkMode)
        {
            SetBrushColor("BackgroundBrush", Color.FromRgb(30, 30, 46));
            SetBrushColor("TextBrush", Color.FromRgb(244, 244, 248));
            SetBrushColor("ButtonBackgroundBrush", Color.FromRgb(52, 52, 73));
            SetBrushColor("ButtonForegroundBrush", Color.FromRgb(244, 244, 248));

            ThemeButton.Content = "☀️ Switch to Light Mode";
        }
        else
        {
            SetBrushColor("BackgroundBrush", Colors.White);
            SetBrushColor("TextBrush", Color.FromRgb(23, 23, 23));
            SetBrushColor("ButtonBackgroundBrush", Color.FromRgb(232, 232, 238));
            SetBrushColor("ButtonForegroundBrush", Color.FromRgb(23, 23, 23));

            ThemeButton.Content = "🌙 Switch to Dark Mode";
        }
    }

    private void SetBrushColor(string resourceKey, Color color)
    {
        // Replace the resource instead of mutating it, avoiding frozen-brush exceptions.
        Resources[resourceKey] = new SolidColorBrush(color);
    }
}