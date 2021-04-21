using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.UI.ViewModels.PagesViewModels
{
    class MainPageVM
    {
        public ObservableCollection<object> Collection { get; set; }
        public MainPageVM()
        {
            Collection = new ObservableCollection<object>(new List<object>()
            {
                new object(),
                new object()
            });

        }
    }
}
