// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ffmobile.xaml {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class tblContactsPage : ContentPage {
        
        private ListView itemsList;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(tblContactsPage));
            itemsList = this.FindByName <ListView>("itemsList");
        }
    }
}
