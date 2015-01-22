using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ffmobile.Data;
using Xamarin.Forms;
using Zumero;
using ffmobile.xaml;


namespace ffmobile
{	
	public partial class ContactsGrid : ContentPage
	{	
		public ContactsGrid ()
		{
			InitializeComponent ();
		}


		//bool alreadyRedirectedOnce = false;
		protected override void OnAppearing()
		{
			base.OnAppearing();
			this.FindByName<DataGrid> ("dataGrid").Rows = Contact.GetDataList ();
			/*try
			{
				this.FindByName<DataGrid>("dataGrid").Rows = await Task<IList<Models.tblContacts>>.Run(() =>
					{
						return (IList<object>) DependencyService.Get<IDataService>().LoadAll<Models.tblContacts>();
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
			}*/

		}
	}
}

