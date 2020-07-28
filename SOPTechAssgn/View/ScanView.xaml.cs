using System;
using System.Collections.Generic;
using SOPTechAssgn.Service;
using Xamarin.Forms;

namespace SOPTechAssgn.View
{
    public partial class ScanView : ContentPage
    {
        //public BarcodeService barcodeService;
        public ScanView()
        {
            InitializeComponent();
            //barcodeService = new BarcodeService();
        }
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                var content = await Utilities.Constants.getBarcodeDetail();
                if(content != null)
                {
                    if (content.success == 1)
                    {
                        await Navigation.PushAsync(new BarcodeDetail(content.data));
                    }
                    else
                    {
                        await DisplayAlert("Alert", "Barcode not found!", "ok");
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
