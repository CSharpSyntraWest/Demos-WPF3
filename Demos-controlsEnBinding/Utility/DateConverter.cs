using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Demos_controlsEnBinding.Utility
{
    [ValueConversion(typeof(DateTime), typeof(String))]
    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string returnValue = String.Empty;
            if (value != null)
            {
                returnValue = ((DateTime)value).ToString("dd/MM/yyyy");
            }

            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime resultDateTime = DateTime.Parse(value.ToString());
            return resultDateTime;
        }
    }
}
