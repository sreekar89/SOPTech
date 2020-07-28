using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SOPTechAssgn.Model;

namespace SOPTechAssgn.Service
{
    public class BarcodeService
    {
        //String url = "https://plutokm.com//barcode_scan_api.php?barcode=TG14915052010";
        //HttpResponseMessage response = null;

        //Uri uri = new Uri(string.Format("https://plutokm.com//barcode_scan_api.php?barcode=TG14915052010"));
        public static async Task<Response> getBarcodeData(String barcode)
        {
            Response oResponse = null;
            try
            {
                var client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://plutokm.com//barcode_scan_api.php?barcode=" + barcode);
                oResponse = JsonConvert.DeserializeObject<Response>(response.Content.ReadAsStringAsync().Result);

            }
            catch (Exception ex)
            {

            }
            return oResponse;
        }
    }
}
