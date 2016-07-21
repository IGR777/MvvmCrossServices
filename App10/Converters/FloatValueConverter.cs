using MvvmCross.Platform.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace App10.Converters
{
    public class FloatValueConverter : MvxValueConverter<float?, string>
    {
        protected override string Convert(float? value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!value.HasValue)
                return "";
            return value.Value.ToString();
        }

        protected override float? ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
        {
            if (string.IsNullOrEmpty(value))
                return null;
            float result;
            if (float.TryParse(value, out result))
                return result;
            return null;
        }
    }
}
