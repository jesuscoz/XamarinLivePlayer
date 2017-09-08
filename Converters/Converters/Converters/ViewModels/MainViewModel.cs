using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Converters.ViewModels
{
    public class MainViewModel : BindableObject
    {
        private List<string> _elements;

        public MainViewModel()
        {
            Elements = new List<string> { "one", "two", "three", "four", "five" };
        }

        public List<string> Elements { get => _elements; set => _elements = value; }
    }
}
