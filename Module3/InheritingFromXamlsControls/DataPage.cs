using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace InheritingFromXamlsControls
{
    public class DataPage: Page
    {
        public DataPage()
        {
            this.DataContext = new
            {
                Header = "Title at the top of the page",
                SubHeader = "Text below the title"
            };
        }
    }
}
