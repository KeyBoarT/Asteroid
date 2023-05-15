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
    class StoreMainViewModel: ObservableObject
    {
        #region Fields
        private object _currentView;
        private StoreModel _currentAccount;
        #endregion

        #region Properties
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChaned();
            }
        }

        public StoreModel CurrentAccount
        {
            get { return _currentAccount; }
            set { _currentAccount = value; OnPropertyChaned(); }
        }
        #endregion
        public HomeViewModel HomeViewModel { get; set; }
        public MapsViewModel MapsViewModel { get; set; }
        public DeveloperViewModel DeveloperViewModel { get; set; }
        public SettingsViewModel SettingsViewModel { get; set; }
        public ProductsViewModel ProductsViewModel { get; set; }

        #region Commands
        public RelayCommand MoveWindowCommand { get; set; }
        public RelayCommand CloseWindowCommand { get; set; }
        public RelayCommand MaximizeWindowCommand { get; set; }
        public RelayCommand MinimizeWindowCommand { get; set; }
        public RelayCommand RefreshWindowCommand { get; set; }
        public RelayCommand ShowHomeViewCommand { get; set; }
        public RelayCommand ShowMapsViewCommand { get; set; }
        public RelayCommand ShowDeveloperViewCommand { get; set; }
        public RelayCommand ShowSettingViewCommand { get; set; }
        public RelayCommand ShowProductsViewCommand { get; set; }

        #endregion

        public StoreMainViewModel()
        {
            CurrentAccount = StoreRepository.CurrentAccount;
            MoveWindowCommand = new RelayCommand(o => { (o as Window).DragMove(); });
            CloseWindowCommand = new RelayCommand(o => { Application.Current.Shutdown(); });
            MaximizeWindowCommand = new RelayCommand(o => { (o as Window).WindowState = ((o as Window).WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized; });
            MinimizeWindowCommand = new RelayCommand(o => { (o as Window).WindowState = WindowState.Minimized; });
            ShowDeveloperViewCommand = new RelayCommand(O=> { CurrentView = new DeveloperViewModel(); });
            ShowProductsViewCommand = new RelayCommand(O=> { CurrentView = new ProductsViewModel(); });
        }
    }
}
