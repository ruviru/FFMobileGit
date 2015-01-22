using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace samples
{
    public class ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;
            if (value is demo.Models.presidents)
            {
                return ImageSource.FromStream(() => { return new System.IO.MemoryStream(((demo.Models.presidents)value).portrait); });
            }
            return null;
        }
        public object ConvertBack(object value, Type targetType,
                         object parameter, CultureInfo culture)
        {
            return value;
        }
    }

    public partial class PresidentsXaml : ContentPage
	{
        public static readonly BindableProperty DataRowsProperty =
            BindableProperty.Create<PresidentsXaml, demo.Models.presidents[]>(
                p => p.DataRows, null);

        public demo.Models.presidents[] DataRows
        {
            get { return (demo.Models.presidents[])GetValue(DataRowsProperty); }
            set { SetValue(DataRowsProperty, value); } // TODO disallow invalid values
        }

        public PresidentsXaml()
		{
			InitializeComponent ();
            this.BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (DataRows == null)
                DataRows = await Task.Run(() =>
                {
                    return samples.SampleData.GetPresidents();
                });
        }
	}
}

