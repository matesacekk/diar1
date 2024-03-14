using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace diar
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Records { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Records = new ObservableCollection<string>();
            listBox.ItemsSource = Records;

        }

        private void AddRecord_Click(object sender, RoutedEventArgs e)
        {
            AddEntryWindow addRecordWindow = new AddEntryWindow();
            addRecordWindow.Owner = this;
            if (addRecordWindow.ShowDialog() == true)
            {
                Records.Add(addRecordWindow.Record);
            }
        }

        private void DeleteRecord_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                Records.Remove(listBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Vyber záznam ke smazání.");
            }
        }
    }
}
