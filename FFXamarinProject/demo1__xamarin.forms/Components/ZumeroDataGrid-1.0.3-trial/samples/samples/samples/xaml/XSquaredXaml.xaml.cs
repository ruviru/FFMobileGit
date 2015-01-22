using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace samples
{
    public partial class XSquaredXaml : ContentPage
	{
        public static readonly BindableProperty DataRowsProperty =
            BindableProperty.Create<XSquaredXaml, ObservableCollection<object>>(
                p => p.DataRows, null);

        public ObservableCollection<object> DataRows
        {
            get { return (ObservableCollection<object>)GetValue(DataRowsProperty); }
            set { SetValue(DataRowsProperty, value); } // TODO disallow invalid values
        }

        public XSquaredXaml()
		{
			InitializeComponent ();
            this.BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (DataRows == null)
                DataRows = new ObservableCollection<object> {
                        new myRow {X = 1},
                        new myRow {X = 2},
                        new myRow {X = 3},
                        new myRow {X = 4},
                        new myRow {X = 5},
                        new myRow {X = 6},
                        new myRow {X = 7},
                };
        }
	}
}

