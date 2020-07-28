using System;
using System.Collections.Generic;
using SOPTechAssgn.Model;
using Xamarin.Forms;

namespace SOPTechAssgn.View
{
    public partial class BarcodeDetail : ContentPage
    {
        public BarcodeDetail(BarcodeData barcodeData)
        {
            InitializeComponent();
            fillGrid(barcodeData);
        }

        private void fillGrid(BarcodeData barcodeData)
        {
            lb_Division.Text = barcodeData.Division;
            lb_Section.Text = barcodeData.Section;
            lb_SubSection.Text = barcodeData.Subsection;
            lb_Barcode.Text = barcodeData.Barcode;
            lb_Location.Text = barcodeData.Location;
            lb_QTYStock.Text = barcodeData.qtyinstock;
            lb_SingleCP.Text = barcodeData.SingleItemCP?.ToString();
            lb_SingleMRP.Text = barcodeData.SingleItemMRP?.ToString();
            lb_SingleEffMRP.Text = barcodeData.SingleItemEffMRP?.ToString();
            lb_VendorCity.Text = barcodeData.VendorCity;
            lb_VendorName.Text = barcodeData.VendorName;
            lb_Age.Text = barcodeData.AgeDays;
            lb_CSNO.Text = barcodeData.CNSNO;
            lb_InvoiceNo.Text = barcodeData.InvoiceNo;
            lb_InvLineNo.Text = barcodeData.InvLineNo;
            lb_Promotion.Text = barcodeData.Promotion;
            lb_BatchNo.Text = barcodeData.BatchNo;
            lb_currentMU.Text = barcodeData.currentMU;
            lb_DCODE.Text = barcodeData.DCODE;
            lb_DesiredMU.Text = barcodeData.DesiredMU;
        }

        async void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                var content = await Utilities.Constants.getBarcodeDetail();
                if (content != null)
                {
                    if (content.success == 1)
                    {
                        fillGrid(content.data);
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
