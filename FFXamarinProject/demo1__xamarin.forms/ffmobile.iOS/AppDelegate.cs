﻿using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using ffmobile.Data;

[assembly: Dependency(typeof(ffmobile.iOS.SHA1Service))]
[assembly: Dependency(typeof(ffmobile.Data.BaseSyncService))]
namespace ffmobile.iOS
{
	public class SHA1Service : ffmobile.Data.ISHA1Service
    {
        public string HashString(string input)
        {
            byte[] jsonBytes = Encoding.UTF8.GetBytes(input);
            var sha1 = SHA1.Create();
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
	
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        UIWindow window;

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();
			Zumero.DataGridComponent.Init ();

            var sqliteFilename = "data.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);

            App.DatabasePath = path;

            window = new UIWindow(UIScreen.MainScreen.Bounds);

            window.RootViewController = App.GetMainPage().CreateViewController();

            window.MakeKeyAndVisible();

            return true;
        }
		
		// This method should be used to release shared resources and it should store the application state.
        // If your application supports background exection this method is called instead of WillTerminate
        // when the user quits.
        public override void DidEnterBackground(UIApplication application)
        {
            System.Console.WriteLine("AppDelegate:DidEnterBackground");

            if (!DependencyService.Get<ISyncService>().IsSyncRunning())
                return;

            int bgTaskId = UIApplication.BackgroundTaskInvalid;

            bgTaskId = UIApplication.SharedApplication.BeginBackgroundTask(
                () => { UIApplication.SharedApplication.EndBackgroundTask(bgTaskId); });
        }
    }
}
