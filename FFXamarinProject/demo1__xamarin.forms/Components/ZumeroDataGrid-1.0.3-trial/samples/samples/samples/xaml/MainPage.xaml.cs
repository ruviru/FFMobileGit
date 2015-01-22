using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace samples.xaml
{
	public partial class MainPage
	{
		class SampleObject
		{
			public string SampleName { get; set; }
			public string SampleDescription { get; set; }

			public Func<Page> OpenCode { get; set; }
			public Func<Page> OpenXaml { get; set; }
				
		}
		public MainPage()
		{
			InitializeComponent();
		}

		void OnCodeButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;
			this.Navigation.PushAsync(((SampleObject)button.BindingContext).OpenCode());
		}

		void OnXamlButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;
		    this.Navigation.PushAsync(((SampleObject)button.BindingContext).OpenXaml());
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			datagrid.Rows = new ObservableCollection<object>
			{
				new SampleObject
				{
					SampleName = "Presidents",
					SampleDescription = "Shows images, dates. Includes headers and a frozen column.",
					OpenCode = () => { return new PresidentsCode(); },
					OpenXaml = () => { return new PresidentsXaml(); },
				},
				new SampleObject
				{
					SampleName = "Countries",
					SampleDescription = "Lots of rows. Unicode text.",
					OpenCode = () => { return new CountriesCode(); },
					OpenXaml = () => { return new CountriesXaml(); },
				},
				new SampleObject
				{
					SampleName = "Dynamic",
					SampleDescription = "Dynamic generation of one million 'virtual' rows.",
					OpenCode = () => { return new DynamicCode(); },
					OpenXaml = () => { return new DynamicXaml(); },
				},
				new SampleObject
				{
					SampleName = "XSquared",
					SampleDescription = "Includes slider controls with two way binding.",
					OpenCode = () => { return new XSquaredCode(); },
					OpenXaml = () => { return new XSquaredXaml(); },
				},
			};
		}
	}
}
