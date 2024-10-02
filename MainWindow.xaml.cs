using System;
using System.Windows;
using System.Windows.Media;

namespace RandomColorButton
{
    public partial class MainWindow : Window
    {
        private Random _random = new Random();
        // Створюємо об'єкт Random для генерації випадкових кольорів

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            // Генеруємо випадковий колір
            byte r = (byte)_random.Next(256);
            byte g = (byte)_random.Next(256);
            byte b = (byte)_random.Next(256);
            Color randomColor = Color.FromRgb(r, g, b);

            // Змінюємо колір кнопки
            btnChangeColor.Background = new SolidColorBrush(randomColor);
        }
    }
}