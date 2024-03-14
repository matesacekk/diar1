using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace diar
{
    public partial class AddEntryWindow : Window
    {
        public string Record { get; set; }

        public AddEntryWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string selectedDate = datePicker.SelectedDate?.ToString("dd.MM.yyyy");
            if (string.IsNullOrEmpty(selectedDate))
            {
                MessageBox.Show("Vyber Datum!!!","POZOR", MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
            }

            Record = $"{selectedDate} - {eventTextBox.Text}";
            DialogResult = true;
            MessageBox.Show("Gratuluji, Úspěšný zápis", "Informace", MessageBoxButton.OK, MessageBoxImage.Asterisk);

    
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
