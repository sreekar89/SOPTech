using System;
using System.Threading.Tasks;
using SOPTechAssgn.Model;
using SOPTechAssgn.Service;

namespace SOPTechAssgn.Utilities
{
    public class Constants
    {
        public Constants()
        {
        }

        public static async Task<Response> getBarcodeDetail()
        {
            Response oResponse = null;
            try
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();

                var result = await scanner.Scan();
                if (result == null)
                    return null;
                //ScanResult = result.Text;

                oResponse = await BarcodeService.getBarcodeData(result.Text);

            }
            catch (Exception ex)
            {

            }
            return oResponse;
        }
    }
}
