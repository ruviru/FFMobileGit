using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ffmobile.Data;

namespace ffmobile.xaml
{
    public partial class TablesPage : ContentPage
    {
        public TablesPage()
        {
            InitializeComponent();
			ToolbarItems.Add(new ToolbarItem()
            {
                Name = "Sync",
				Icon = (Device.OS == TargetPlatform.WinPhone) ? "refresh.png" : null,
                Order = ToolbarItemOrder.Primary,
                Command = new Command(() =>
                {
                    this.Navigation.PushAsync(new SyncPage());
                })
            });
			
			ToolbarItems.Add(new ToolbarItem()
            {
                Name = "Revert Changes",
				Icon = (Device.OS == TargetPlatform.WinPhone) ? "undo.png" : null,
                Order = ToolbarItemOrder.Primary,
                Command = new Command(async () =>
                {
					bool revert = await this.DisplayAlert("Confirm", "Are you sure that you want to revert all changes made to the local database since the last sync?", "Revert", "Cancel");
                    if (revert)
					{
						try
						{
							DependencyService.Get<ISyncService>().RevertLocalChanges();
							this.DisplayAlert("Reverted", "All local changes have been reverted.", "Ok");
						}
						catch (Exception e)
						{
							this.DisplayAlert("Exception", e.Message, "Ok");
						}
					}
                })
            });
			
            this.BindingContext = this;
        }

        private string[] _tables = new string[] { 
		"tblInvoices",
		"tblAccounts",
		"tblLeads",
		"tblOpportunities",
		"tblContacts",
		};
        public string[] Tables
        {
            get { return _tables; }
            set { ; }
        }

        public void ItemTapped(object sender, ItemTappedEventArgs args)
        {
            if (args.Item == null)
                return;
            else
            {
				Page target = null;
				if (((string)args.Item) == "tblInvoices") target = new tblInvoicesPage();
				if (((string)args.Item) == "tblAccounts") target = new tblAccountsPage();
				if (((string)args.Item) == "tblLeads") target = new tblLeadsPage();
				if (((string)args.Item) == "tblOpportunities") target = new tblOpportunitiesPage();
				if (((string)args.Item) == "tblContacts") target = new tblContactsPage();
                this.Navigation.PushAsync(target);
            }
        }
    }
}
