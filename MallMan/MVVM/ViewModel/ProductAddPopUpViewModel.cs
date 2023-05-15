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
    class ProductAddPopUpViewModel: ObservableObject
    {
        #region fields
        private int _id;
        private ImageSource _image;
        private string _productName;
        private int _productAmount;
        private float _productPrice;
        private string _productInfo;
        #endregion

        #region Properties
        public int ID { get { return _id; } set { _id = value; OnPropertyChaned(); } }
        public ImageSource Image { get { return _image; } set { _image = value; OnPropertyChaned(); } }
        public string ProductName { get { return _productName; } set { _productName = value; OnPropertyChaned(); } }
        public int ProductAmount { get { return _productAmount; } set { _productAmount = value; OnPropertyChaned(); } }
        public float ProductPrice { get { return _productPrice; } set { _productPrice = value; OnPropertyChaned(); } }
        public string ProductInfo { get { return _productInfo; } set { _productInfo = value; OnPropertyChaned(); } }
        #endregion

        #region RelayCommands
        public RelayCommand MoveWindowCommand { get; set; }
        public RelayCommand CloseWindowCommand { get; set; }
        public RelayCommand AddImageCommand { get; set; }
        public RelayCommand SaveCommand { get; set; }
        #endregion

        public ProductAddPopUpViewModel()
        {
            MoveWindowCommand = new RelayCommand(o =>
            {
                (o as Window).DragMove();
            });
            CloseWindowCommand = new RelayCommand(o =>
            {
                (o as Window).Close();
            });
            AddImageCommand = new RelayCommand(o =>
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
            SaveCommand = new RelayCommand(o =>
            {
                MessageBox.Show("Kayıt Başladı");
                if (Image != null)
                    if (!String.IsNullOrEmpty(ProductName))
                        if (ProductPrice != 0)
                            if (!String.IsNullOrEmpty(ProductInfo))
                                if (ProductAmount != 0)
                                {
                                    IProductRepository repo = new ProductRepository();
                                    repo.Add(new ProductModel
                                    {
                                        ProductName = ProductName,
                                        ProductAmount = ProductAmount,
                                        ProductImage = Image,
                                        ProductInfo = ProductInfo,
                                        ProductPrice = ProductPrice,
                                        StoreID = StoreRepository.CurrentAccount.StoreID
                                    });
                                    (o as Window).Close();
                                }
                                else
                                {
                                    MessageBox.Show("Lütfen bir miktar giriniz !");
                                }
                            else
                            {
                                MessageBox.Show("Lütfen bir açıklama giriniz !");
                            }
                        else
                        {
                            MessageBox.Show("Lütfen bir fiyat giriniz !");
                        }
                    else
                    {
                        MessageBox.Show("Lütfen bir isim giriniz !");
                    }
                else
                {
                    MessageBox.Show("Lütfen bir resim giriniz !");
                }
            });
        }
    }
}
