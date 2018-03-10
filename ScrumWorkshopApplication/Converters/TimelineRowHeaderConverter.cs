using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace ScrumWorkshopApplication.Converters
{
    public class TimelineRowHeaderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return GetRowHeader((value as DataGridRow).GetIndex());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }

        private string GetRowHeader(int index)
        {
            return string.Format("{0}:00", index + 8);
        }
    }
}
