using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallMan.MVVM.Model
{
    public class MallModel
    {
        private int _mallID;
        private int _adminID;
        private string _cityCode;
        private int _storeCount;

        public int MallID
        {
            get { return _mallID; }
            set { _mallID = value; }
        }

        public int AdminID
        {
            get { return _adminID; }
            set { _adminID = value; }
        }

        public string CityCode
        {
            get { return _cityCode; }
            set { _cityCode = value; }
        }

        public int StoreCount
        {
            get { return _storeCount;}
            set { _storeCount = value; }
        }
    }
}
