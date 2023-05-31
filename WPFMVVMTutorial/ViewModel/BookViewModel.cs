using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMTutorial.Model;

namespace WPFMVVMTutorial.ViewModel
{
    public class BookViewModel : ViewModelBase
    {
        private readonly BookModel model = new BookModel();

        public int No
        {
            get => model.No;
            set
            {
                model.No = value;
                OnPropertyChanged();
            }
        }
        public string Title
        {
            get => model.Title;
            set
            {
                model.Title = value;
                OnPropertyChanged();
            }
        }



        public string Author
        {
            get => model.Author;
            set
            {
                model.Author = value;
                OnPropertyChanged();
            }
        }


    }
}
