using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallMan.MVVM.Model
{
    public class CityModel
    {
        private string _cityCode;
        private string _cityName;

        public string CityCode
        {
            get { return _cityCode; }
            set { _cityCode = value; }
        }

        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }
    }
}
