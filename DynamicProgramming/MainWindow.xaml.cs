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

namespace DynamicProgramming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random _random;

        public MainWindow()
        {
            InitializeComponent();
            _random = new Random();
        }

        private void InitialButton_Click(object sender, RoutedEventArgs e)
        {
            // Létrehozunk egy új gombot
            Button newButton = new Button
            {
                // A gomb szövege
                Content = "Szia",
                // Véletlenszerű háttérszín beállítása
                Background = new SolidColorBrush(RandomColor()),
                // Betűszín beállítása
                Foreground = Brushes.White,
                // Szélesség beállítása
                Width = 100,
                // Magasság beállítása
                Height = 50,
                // Szöveg igazítása középre
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                // Margó beállítása
                Margin = new Thickness(5),
                // Betűméret beállítása
                FontSize = 16,
                // Szegély színe és vastagsága
                BorderBrush = Brushes.Black,
                BorderThickness = new Thickness(2)
            };

            // A gomb kattintás eseményének kezelése (például egy üzenet megjelenítése)
            newButton.Click += (s, args) =>
            {
                MessageBox.Show("Ez egy dinamikusan létrehozott gomb!", "Információ");
            };

            // Az új gomb hozzáadása a StackPanel-hez
            MainStackPanel.Children.Add(newButton);
        }

        // Véletlenszerű szín generálása
        private Color RandomColor()
        {
            return Color.FromRgb((byte)_random.Next(256), (byte)_random.Next(256), (byte)_random.Next(256));
        }
    }
}