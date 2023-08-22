using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoMauiClient.Models
{
    public class ToDo : INotifyPropertyChanged
    {
        int _id;
        string _todoname;

        public int Id
        {
            get => _id;
            set
            {
                if (Id == value) return;

                _id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
            }
        }

        public string ToDoName
        {
            get => _todoname;

            set
            {
                if (ToDoName == value) return;

                _todoname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ToDoName)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
