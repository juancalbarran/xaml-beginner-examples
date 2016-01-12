using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;

namespace IValueConverterImplementation
{
    public sealed class BooleanToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Color returnvalue = Colors.Transparent;

            if (value is bool)
            {
                returnvalue = (bool)value ? Colors.Green : Colors.Red;
            }

            return returnvalue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            bool returnvalue = default(bool);

            if (value is Color)
            {
                if (value.Equals(Colors.Green)) { returnvalue = true; }
                else if (value.Equals(Colors.Red)) { returnvalue = false; }
            }

            return returnvalue;
        }
    }
}
