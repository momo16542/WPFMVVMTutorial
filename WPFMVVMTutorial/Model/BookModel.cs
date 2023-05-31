using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMTutorial.Model
{
    public class BookModel : ModelBase
    {
        public int No { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
