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


		bool alreadyRedirectedOnce = false;
		protected override async void OnAppearing()
		{
			base.OnAppearing();
			//dataGrid.Rows = Contact.GetDataList ();
			/*
			var list = new Models.tblContacts[] {
					new Models.tblContacts { ContactName = "test1", ContactType = "type1" },
					new Models.tblContacts { ContactName = "test2", ContactType = "type2" }
			};

			var listCnt = new List<Models.tblContacts> ();
			listCnt.Add (new Models.tblContacts { ContactName = "test1", ContactType = "type1" });
			listCnt.Add (new Models.tblContacts { ContactName = "test1222", ContactType = "type1222" });

			dataGrid.Rows = list;
			*/
			try
			{
				//dataGrid.Rows = list;
				dataGrid.Rows = await Task<Models.tblContacts[]>.Run(() =>
					{
						return DependencyService.Get<IDataService>().LoadAllArray<Models.tblContacts>();
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
	}
}

