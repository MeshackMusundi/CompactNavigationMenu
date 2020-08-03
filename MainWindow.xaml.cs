using System.Windows;

namespace CompactNavigationMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NavigationMenuListBox.Items.Add("Home");
            NavigationMenuListBox.Items.Add("Email");
            NavigationMenuListBox.Items.Add("Cloud");
        }
    }
}
