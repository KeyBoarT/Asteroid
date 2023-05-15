using MallMan.Core;
using MallMan.MVVM.Model;
using MallMan.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MallMan.MVVM.ViewModel
{
    class DeveloperViewModel: ObservableObject
    {
        #region fields
        private DeveloperModel _currentDevModel;
        #endregion

        #region Properties
        public DeveloperModel CurrentDevModel
        {
            get { return _currentDevModel; }
            set { _currentDevModel = value; OnPropertyChaned();}
        }
        #endregion

        #region RelayCommand
        public RelayCommand dev1Command { get; set; }
        public RelayCommand dev2Command { get; set; }
        public RelayCommand dev3Command { get; set; }
        #endregion
        public DeveloperViewModel()
        {
            IDeveloperRepository devRepo = new DeveloperRepository();
            CurrentDevModel = devRepo.GetByMail("mehmetszr05@gmail.com");
            dev1Command = new RelayCommand(O => { CurrentDevModel = devRepo.GetByMail("mehmetszr05@gmail.com"); });
            dev2Command = new RelayCommand(O => { CurrentDevModel = devRepo.GetByMail("buseynr@gmail.com"); });
            dev3Command = new RelayCommand(O => { CurrentDevModel = devRepo.GetByMail("nisaksy@gmail.com"); });
        }
    }
}
