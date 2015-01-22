using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace samples
{	
	public partial class DynamicXaml : ContentPage
	{
		public DynamicXaml()
		{
			InitializeComponent ();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			if (this.datagrid.Rows == null) {
				this.datagrid.Rows = new myList (1000000);
			}
		}
	}
}

