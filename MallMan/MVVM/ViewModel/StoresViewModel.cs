using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MallMan.Core;
using MallMan.MVVM.Model;
using MallMan.Repositories;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows;

namespace MallMan.MVVM.ViewModel
{
    class StoresViewModel: ObservableObject
    {
        private string _storeName;
        private string _ownerName;
        private string _password;
        private ImageSource _image;
        private int _selected;
        private StoreModel _selectedModel;
        private ObservableCollection<int> _malls;
        private ObservableCollection<StoreModel> _stores;

        public string StoreName
        {
            get { return _storeName;}
            set { _storeName = value; OnPropertyChaned(); }
        }
        public string OwnerName
        {
            get { return _ownerName; }
            set { _ownerName = value; OnPropertyChaned(); }
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
        public StoreModel SelectedStore
        {
            get { return _selectedModel; }
            set { _selectedModel = value; OnPropertyChaned(); }
        }
        public int Selected
        {
            get { return _selected; }
            set { _selected = value; OnPropertyChaned(); }
        }
        public ObservableCollection<StoreModel> Stores
        {
            get { return _stores; }
            set { _stores = value; OnPropertyChaned(); }
        }
        public ObservableCollection<int> Malls
        {
            get { return _malls; }
            set { _malls = value; OnPropertyChaned(); }
        }
        public RelayCommand AddImage { get; set; }
        public RelayCommand SaveStore { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        public StoresViewModel()
        {
            AddImage = new RelayCommand(o =>
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
            SaveStore = new RelayCommand(o=>
            {
                if (!String.IsNullOrEmpty(StoreName))
                {
                    if (!String.IsNullOrEmpty(OwnerName))
                    {
                        if (!String.IsNullOrEmpty(Password))
                        {
                            if (Selected != 0)
                            {
                                StoreModel model = new StoreModel()
                                {
                                    StoreName = StoreName,
                                    OwnerName = OwnerName,
                                    StorePassword = Password,
                                    Image = Image,
                                    MallID = Selected
                                };
                                IStoreRepository storeRepo = new StoreRepository();
                                storeRepo.Add(model);
                                GetList();
                                MessageBox.Show("Mağaza başarıyla eklendi !");
                            }
                            else { MessageBox.Show("Lütfen bir AVM seçin !"); }
                        }
                        else { MessageBox.Show("Lütfen şifre belirleyin !"); }
                    }
                    else { MessageBox.Show("Lütfen sahip adını giriniz !"); }
                }
                else { MessageBox.Show("Lütfen mağaza adını giriniz !"); }
            });
            DeleteCommand = new RelayCommand(o =>
            {
                if (SelectedStore != null)
                {
                    IStoreRepository repo = new StoreRepository();
                    repo.Remove(SelectedStore.StoreID);
                    GetList();
                }
                else
                {
                    MessageBox.Show("Lütfen silmek için bir mağaza seçiniz !");
                }
            });
            Stores = new ObservableCollection<StoreModel>();
            Malls = new ObservableCollection<int>();
            GetList();
            GetMalls();
        }

        private void GetList()
        {
            Stores.Clear();
            IStoreRepository storeRepo = new StoreRepository();
            IMallRepository mallRepo = new MallRepository();
            List<MallModel> mallModels = mallRepo.GetList(AdminRepository.CurrentAccount.AdminID);
            foreach (var mallModel in mallModels)
            {
                foreach (var storeModel in storeRepo.GetList(mallModel.MallID))
                {
                    Stores.Add(storeModel);
                }
            }
        }

        private void GetMalls()
        {
            Malls.Clear();
            IMallRepository mallRepo = new MallRepository();
            List<MallModel> malModels = mallRepo.GetList(AdminRepository.CurrentAccount.AdminID);
            foreach(var model in malModels)
            {
                Malls.Add(model.MallID);
            }
        }
    }
}
