using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace samples
{
    public partial class CountriesXaml : ContentPage
	{
        public static readonly BindableProperty DataRowsProperty =
            BindableProperty.Create<CountriesXaml, demo.Models.countries[]>(
                p => p.DataRows, null);

        public demo.Models.countries[] DataRows
        {
            get { return (demo.Models.countries[])GetValue(DataRowsProperty); }
            set { SetValue(DataRowsProperty, value); } // TODO disallow invalid values
        }

        public CountriesXaml()
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
                    return samples.SampleData.GetCountries();
                });
        }
	}
}

