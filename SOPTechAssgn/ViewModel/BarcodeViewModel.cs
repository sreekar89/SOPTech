using System;
using SOPTechAssgn.Model;
using SOPTechAssgn.Service;
using System.Threading.Tasks;

namespace SOPTechAssgn.ViewModel
{
    public class BarcodeViewModel : BaseViewModel
    {

        public BarcodeViewModel()
        {
        
        }

        private BarcodeData _data;

        public BarcodeData data{
            get { return _data; }
            set { SetProperty(ref _data, value); }
        }
    }
}
