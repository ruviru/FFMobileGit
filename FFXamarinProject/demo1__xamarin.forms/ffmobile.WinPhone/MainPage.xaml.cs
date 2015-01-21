﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ffmobile.WinPhone.Resources;
using System.Security.Cryptography;
using Xamarin.Forms;
using System.IO;
using System.Text;

[assembly: Dependency(typeof(ffmobile.WinPhone.SHA1Service))]
[assembly: Dependency(typeof(ffmobile.Data.BaseSyncService))]
namespace ffmobile.WinPhone
{
    public class SHA1Service : ffmobile.Data.ISHA1Service
    {
        public string HashString(string input)
        {
            byte[] jsonBytes = Encoding.UTF8.GetBytes(input);
            var sha1 = new SHA1Managed();
            byte[] hashBytes = sha1.ComputeHash(jsonBytes);

            var sb = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                var hex = b.ToString("X2");
                sb.Append(hex);
            }
            return sb.ToString();
        }
    }
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            var sqliteFilename = "data.db3";

            string documentsPath = Windows.Storage.ApplicationData.Current.LocalFolder.Path;// System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            ffmobile.App.DatabasePath = path;

            Forms.Init();
            Content = ffmobile.App.GetMainPage().ConvertPageToUIElement(this);
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}