using System.Windows;


namespace DesktopContactsApp
{

    public partial class NewContactWindow : Window
    {
        public NewContactWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //Save Contact to Database implementation later.
            Close();
        }
    }
}
