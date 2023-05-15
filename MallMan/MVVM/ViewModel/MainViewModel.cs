using MallMan.Core;
using MallMan.MVVM.Model;
using MallMan.Repositories;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace MallMan.MVVM.ViewModel
{
    class MainViewModel: ObservableObject
    {
        #region Fields
        private object _currentView;
        private AdminModel _currentAccount;
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

        public AdminModel CurrentAccount
        {
            get { return _currentAccount; }
            set { _currentAccount = value; OnPropertyChaned(); }
        }
        #endregion
        public HomeViewModel HomeViewModel { get; set; }
        public MapsViewModel MapsViewModel { get; set; }
        public DeveloperViewModel DeveloperViewModel { get; set; }
        public SettingsViewModel SettingsViewModel { get; set; }

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
        public RelayCommand ShowStoresViewCommand { get; set; }

        #endregion

        public MainViewModel()
        {
            CurrentAccount = AdminRepository.CurrentAccount;
            CurrentView = new HomeViewModel();
            MoveWindowCommand = new RelayCommand(o => { (o as Window).DragMove();});
            CloseWindowCommand = new RelayCommand(o => { Application.Current.Shutdown();});
            MaximizeWindowCommand = new RelayCommand(o => { (o as Window).WindowState = ((o as Window).WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized; });
            MinimizeWindowCommand = new RelayCommand(o => { (o as Window).WindowState = WindowState.Minimized; });
            ShowHomeViewCommand = new RelayCommand(o => { CurrentView = new HomeViewModel();});
            ShowMapsViewCommand = new RelayCommand(o => { CurrentView = new MapsViewModel();});
            ShowDeveloperViewCommand = new RelayCommand(o => { CurrentView = new DeveloperViewModel(); });
            ShowSettingViewCommand = new RelayCommand(o => { CurrentView = new SettingsViewModel(); });
            RefreshWindowCommand = new RelayCommand(o => { CurrentAccount = AdminRepository.CurrentAccount; });
            ShowStoresViewCommand = new RelayCommand(o=> { CurrentView = new StoresViewModel(); });
        }
    }
}
