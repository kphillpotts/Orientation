using System;
using Xamarin.Forms;

namespace XfOrientation
{
    public class ImageResourceConverter : IValueConverter
    {
        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ImageSource.FromResource("XfOrientation.Images." + (value ?? ""));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        #endregion


    }
}

