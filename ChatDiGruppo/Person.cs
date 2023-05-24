using System.ComponentModel;

namespace ChatDiGruppo
{
    public class Person : INotifyPropertyChanged
    {
        public Person(string firstName, string lastName, int age)
        { 
            
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        private string _FirstName { get; set; }
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string _LastName { get; set; }
        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
                OnPropertyChanged("LastName");
            }
        }
        private int _Age { get; set; }
        public int Age
        {
            get
            { return _Age; }
            set { _Age = value; }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}