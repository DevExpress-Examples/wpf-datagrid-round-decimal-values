using System;
using System.Globalization;
using System.Windows.Data;

namespace FilterDuplicateRecords_Converter
{
    internal class RoundConverter : IValueConverter
    {
        private const int decimals = 2;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is decimal number) {
                return Math.Round(number, decimals);
            }

            throw new ArgumentException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return value;
        }
    }
}
