using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NoteApp {
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e) {
            string title = Convert.ToString(txtTitle.Text),
                   content = Convert.ToString(txtNote.Text);

        List<Note> notes = new List<Note>();
        notes.Add(new Note() { Title = title, Content = content });
        lstMessages.ItemsSource = notes;
    }

        private void btnRead_Click(object sender, RoutedEventArgs e) {
            Note note = lstMessages.SelectedItem as Note;
            
            txtTitle.Text = note.Title;
            txtNote.Text = note.Content;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e) {
            Note note = lstMessages.SelectedItem as Note;

            if(txtTitle.Text == note.Title && txtNote.Text == note.Content) {
                txtTitle.Text = "";
                txtNote.Text = "";
            }
        }
    }
}
