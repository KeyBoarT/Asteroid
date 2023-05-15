using System.Collections.Generic;
using MallMan.Core;
using MallMan.MVVM.Model;
using MallMan.Repositories;

namespace MallMan.MVVM.ViewModel
{
    class MapsViewModel: ObservableObject
    {
        #region fields
        private Dictionary<string, double> _keyValues = new Dictionary<string, double>()
        {
        };
        #endregion

        #region properties
        public Dictionary<string, double> KeyValues
        {
            get { return _keyValues; }
            set
            {
                _keyValues = value;
                OnPropertyChaned();
            }
        }

        #endregion
        public MapsViewModel()
        {
            IMallRepository mallRepository = new MallRepository();
            foreach(var model in mallRepository.GetList(AdminRepository.CurrentAccount.AdminID))
            {
                KeyValues.Add(model.CityCode, model.MallID);
            }
        }
    }
}
