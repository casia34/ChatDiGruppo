using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ChatDiGruppo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        ObservableCollection<Person> people = new ObservableCollection<Person>();
        public MainWindow()
        {
            InitializeComponent();

            // Wire up the CollectionChanged event.
            people.CollectionChanged += people_CollectionChanged;
            DataContext = people;


        }

        static void people_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {


            // They removed something. 
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {

                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }

            // They added something. 
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                // Now show the NEW items that were inserted.

                foreach (Person p in e.NewItems)
                {
                    
                }
            }
        }

        private void InviaMessaggio_Click(object sender, RoutedEventArgs e)
        {

            people.Add(new Person(Messaggio.Text, "Smith", 32));
            Messaggio.Text = "";
        }
    }
}
