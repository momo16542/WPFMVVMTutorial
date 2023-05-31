using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFMVVMTutorial.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public BookViewModel Book
        {
            get => _book;
            set
            {
                _book = value;
                OnPropertyChanged();
            }
        }

        private BookViewModel _book;

        public ICommand ChangeBookCommand
        {
            get => _changeBookCommand;
            set
            {
                _changeBookCommand = value;
                OnPropertyChanged();
            }
        }

        private ICommand _changeBookCommand;
        public MainWindowViewModel()
        {
            ChangeBookCommand = new BaseCommand(ChangeBookExecute);
            Book = new BookViewModel() { No = 0, Author = "A1000", Title = "A 100 Book" };
        }

        private void ChangeBookExecute()
        {
            var currentNo = Book.No + 1;
            Book = new BookViewModel()
            { No = currentNo, Author = $"A{new Random().Next(100)}", Title = $"A {new Random().Next(100)} Book" };
        }
    }
}
