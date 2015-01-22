using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace samples
{
    public class App
    {
        public static Page GetMainPage()
        {

			var np = new NavigationPage(new xaml.MainPage());
			
            return np;            
        }
    }
}
