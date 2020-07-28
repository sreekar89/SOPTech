using System;
using SOPTechAssgn.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SOPTechAssgn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ScanView()); 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
