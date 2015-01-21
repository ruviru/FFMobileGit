﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ffmobile.Data;
using ffmobile.Views;
using Xamarin.Forms;
using ffmobile.Models;

namespace ffmobile.xaml
{
    public partial class tblContactsPage : ContentPage
    {
        public tblContactsPage()
        {
            InitializeComponent();
            this.BindingContext = this;

			ToolbarItems.Add(new ToolbarItem()
            {
                Name = "Sync"
				, Icon = (Device.OS == TargetPlatform.WinPhone) ? "refresh.png" : null
                , Order = ToolbarItemOrder.Primary,
                Command = new Command(() =>
                {
                    this.Navigation.PushAsync(new SyncPage());
                })
            });
			
            ToolbarItems.Add(new ToolbarItem()
            {
                Name = "Insert",
				Icon = (Device.OS == TargetPlatform.WinPhone) ? "new.png" : null,
                Order = ToolbarItemOrder.Primary,
                Command = new Command(() =>
                {
                    this.Navigation.PushAsync(new tblContactsDetailPage(null));
                })
            });
        }

        public void ItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem == null)
                return;
            else
            {
                this.Navigation.PushAsync(new tblContactsDetailPage(args.SelectedItem as Models.tblContacts));
            }
        }
		
		bool alreadyRedirectedOnce = false;
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                this.FindByName<ListView>("itemsList").ItemsSource = await Task<IList<Models.tblContacts>>.Run(() =>
                {
                    return DependencyService.Get<IDataService>().LoadAll<Models.tblContacts>();
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