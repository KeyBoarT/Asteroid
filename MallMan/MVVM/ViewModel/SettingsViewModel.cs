using MallMan.Core;
using MallMan.MVVM.Model;
using MallMan.Repositories;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MallMan.MVVM.ViewModel
{
    class SettingsViewModel: ObservableObject
    {
        #region fields
        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private ImageSource _image;
        #endregion

        #region Properties

        public int ID
        {
            get { return _id; }
            set { _id = value; OnPropertyChaned(); }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChaned(); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChaned(); }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChaned(); }
        }

        public ImageSource Image
        {
            get { return _image; }
            set { _image = value; OnPropertyChaned(); }
        }
        #endregion

        public RelayCommand saveRelayCommand { get; set; }
        public RelayCommand addImageCommand { get; set; }
        public SettingsViewModel()
        {
            ID = AdminRepository.CurrentAccount.AdminID;
            Name = AdminRepository.CurrentAccount.AdminName;
            Email = AdminRepository.CurrentAccount.AdminEmail;
            Password = AdminRepository.CurrentAccount.AdminPassword;
            Image = AdminRepository.CurrentAccount.AdminImage;
            addImageCommand = new RelayCommand(o=>
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                Nullable<bool> dialog = openFile.ShowDialog();
                if (dialog == true)
                {
                    var imageBrush = (ImageBrush)(o as Border).Background;
                    imageBrush.ImageSource = new BitmapImage(new Uri(openFile.FileName, UriKind.Relative));
                }
            });
            saveRelayCommand = new RelayCommand(o=>
            {
                IAdminRepository adminRepo = new AdminRepository();
                if (!String.IsNullOrEmpty(Name))
                    if (!String.IsNullOrEmpty(Password))
                        if (!String.IsNullOrEmpty(Email))
                        {
                            AdminRepository.CurrentAccount.AdminEmail = Email;
                            AdminRepository.CurrentAccount.AdminName = Name;
                            AdminRepository.CurrentAccount.AdminPassword = Password;
                            AdminRepository.CurrentAccount.AdminImage = Image;
                            adminRepo.Edit(AdminRepository.CurrentAccount);
                            MessageBox.Show("Kaydedildi !");
                        }
                        else
                        {
                            MessageBox.Show("Email Alanı Boş kalamaz !");
                        }
                    else
                    {
                        MessageBox.Show("Parola Alanı Boş kalamaz !");
                    }
                else
                {
                    MessageBox.Show("İsim Alanı Boş Kalamaz !");
                }
            });
        }
    }
}
