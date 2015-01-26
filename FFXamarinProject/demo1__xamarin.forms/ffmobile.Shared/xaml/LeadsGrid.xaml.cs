using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;
using ffmobile.xaml;

namespace ffmobile
{	
	public partial class LeadsGrid : ContentPage
	{	
		public LeadsGrid ()
		{
			InitializeComponent ();
		}


		bool alreadyRedirectedOnce = false;
		protected override async void OnAppearing(){
			base.OnAppearing ();
			try
			{
				dataGrid.Rows = await Task<Models.tblLeads[]>.Run(() =>
					{
						return DependencyService.Get<ffmobile.Data.IDataService>().LoadAllArray<Models.tblLeads>();
					});
			}
			catch (Exception e)
			{
				if (e.Message.StartsWith("no such table"))
				{
					this.DisplayAlert("Exception", "A sync hasn't been performed yet.  Please sync.", "Ok");
					if (!alreadyRedirectedOnce)
					{
						alreadyRedirectedOnce = true;
						this.Navigation.PushAsync(new SyncPage());
					}
				}
				else
					this.DisplayAlert("Exception", e.Message, "Ok");
			}
		}

		public void ItemSelected(object sender, SelectedItemChangedEventArgs args)
		{
			if (args.SelectedItem == null)
				return;
			else
			{
				this.Navigation.PushAsync(new tblLeadsDetailPage(args.SelectedItem as Models.tblLeads));
			}
		}


	}
}

