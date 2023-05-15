using System;
using System.Windows;
using MallMan.Core;
using MallMan.MVVM.View;
using MySql.Data.MySqlClient;
using System.Configuration;
using MallMan.Repositories;
using MallMan.MVVM.Model;

namespace MallMan.MVVM.ViewModel
{
    class LoginViewModel: ObservableObject
    {

        #region Fields
        private int _id;
        private string _password;
        private bool _rememberMe;
        #endregion

        #region Properties
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChaned();
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChaned();
            }
        }
        public bool RememberMe
        {
            get { return _rememberMe; }
            set { _rememberMe = value; OnPropertyChaned(); }
        }
        #endregion

        #region Commands
        public RelayCommand MoveWindowCommand { get; set; }
        public RelayCommand CloseWindowCommand { get; set; }
        public RelayCommand SignInCommand { get; set; }
        #endregion

        public LoginViewModel()
        {
            ID = Properties.Settings.Default.UserName;
            MoveWindowCommand = new RelayCommand(o => { (o as Window).DragMove(); });
            CloseWindowCommand = new RelayCommand(o => { Application.Current.Shutdown(); });
            SignInCommand = new RelayCommand(o=>
            {
                IAdminRepository adminRepo = new AdminRepository();
                IStoreRepository storeRepo = new StoreRepository();
                if (adminRepo.AuthenticateAdmin(ID, Password))
                {
                    if(RememberMe)
                    {
                        MallMan.Properties.Settings.Default.UserName = ID;
                    }
                    (o as Window).Hide();
                    new MainWindow().Show();
                }
                else if (storeRepo.AuthenticateStore(ID, Password))
                {
                    if (RememberMe)
                    {
                        Properties.Settings.Default.UserName = ID;
                    }
                    (o as Window).Hide();
                    new StoreMainView().Show();
                }
                else
                {
                    MessageBox.Show("ID - Parola Uyuşmazlığı !");
                }
            });

        }
    }
}
