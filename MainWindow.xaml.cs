using System.Windows;

namespace DesktopContactsApp
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            NewContactWindow newContactWindow = new();
            newContactWindow.ShowDialog();
        }
    }
}