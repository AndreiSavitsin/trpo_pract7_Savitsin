using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace trpo_pract7_Savitsin.Converters
{
    class AnnualRateConverter :IValueConverter
    {
        public object Convert(object value, Type targetType, object parametr,
            CultureInfo culture)
        {
            if (value == null) return String.Empty;

            if (value is float f)
                return System.Convert.ToInt32(f * 100);
            if (value is double d)
                return System.Convert.ToInt32(d * 100);

            if (float.TryParse(value.ToString(), NumberStyles.Float, culture, out float result))
                return System.Convert.ToInt32(result * 100);

            return String.Empty;
        }
        public object ConvertBack(object value, Type targetType, object parametr,
            CultureInfo culture)
        {
            if (value == null)
                return null;

            if (float.TryParse(value.ToString(), NumberStyles.Float, culture, out float result))
                return result / 100f;

            return null;
        }
    }
}
