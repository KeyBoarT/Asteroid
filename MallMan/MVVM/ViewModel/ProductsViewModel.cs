using MallMan.Core;
using MallMan.MVVM.Model;
using MallMan.MVVM.View;
using MallMan.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace MallMan.MVVM.ViewModel
{
    class ProductsViewModel : ObservableObject
    {
        #region Fields
        private ObservableCollection<ProductModel> _products;
        private string _filter = String.Empty;
        private ProductModel _selectedProduct;
        #endregion

        #region Properties
        public string Filter
        {
            get { return _filter; }
            set
            {
                if (value != _filter && value != null)
                {
                    _filter = value;
                    ProductsCollectionView.Refresh();
                    OnPropertyChaned();
                }
            }
        }
        public ObservableCollection<ProductModel> Products
        {
            get { return _products; }
            set { _products = value; OnPropertyChaned(); }
        }
        public ICollectionView ProductsCollectionView { get; set; }
        public ProductModel SelectedProduct
        {
            get { return _selectedProduct; }
            set { _selectedProduct = value; OnPropertyChaned(); }
        }
        #endregion

        #region RelayCommands
        public RelayCommand FilterByName { get; set; }
        public RelayCommand FilterByProductNo { get; set; }
        public RelayCommand FilterByProductPrice { get; set; }
        public RelayCommand DeleteProductCommand { get; set; }
        public RelayCommand EditProductCommand { get; set; }
        public RelayCommand AddProductCommand { get; set; }
        #endregion
        public ProductsViewModel()
        {
            Products = new ObservableCollection<ProductModel>();
            IProductRepository productRepo = new ProductRepository();
            GetList();
            ProductsCollectionView.Filter = o => FilterProducts(o);
            FilterByName = new RelayCommand(o =>
            {
                ProductsCollectionView.SortDescriptions.Clear();
                ProductsCollectionView.GroupDescriptions.Clear();
                ProductsCollectionView.GroupDescriptions.Add(new PropertyGroupDescription(nameof(ProductModel.ProductName)));
                ProductsCollectionView.SortDescriptions.Add(new SortDescription(nameof(ProductModel.ProductName), ListSortDirection.Ascending));
            });
            FilterByProductNo = new RelayCommand(o=>
            {
                ProductsCollectionView.SortDescriptions.Clear();
                ProductsCollectionView.GroupDescriptions.Clear();
                ProductsCollectionView.GroupDescriptions.Add(new PropertyGroupDescription(nameof(ProductModel.ProductID)));
                ProductsCollectionView.SortDescriptions.Add(new SortDescription(nameof(ProductModel.ProductID), ListSortDirection.Ascending));
            });
            FilterByProductPrice = new RelayCommand(o =>
            {
                ProductsCollectionView.SortDescriptions.Clear();
                ProductsCollectionView.GroupDescriptions.Clear();
                ProductsCollectionView.GroupDescriptions.Add(new PropertyGroupDescription(nameof(ProductModel.ProductPrice)));
                ProductsCollectionView.SortDescriptions.Add(new SortDescription(nameof(ProductModel.ProductPrice), ListSortDirection.Ascending));
            });
            DeleteProductCommand = new RelayCommand(o =>
            {
                if (SelectedProduct != null)
                {
                    productRepo.Remove(SelectedProduct.ProductID);
                    GetList();
                }
            });
            EditProductCommand = new RelayCommand(o =>
            {
                if (SelectedProduct != null)
                {
                    var viewModel = new ProductUpdatePopUpViewModel(SelectedProduct);
                    ProductUpdatePopUp view = new ProductUpdatePopUp();
                    view.DataContext = viewModel;
                    view.ShowDialog();
                    GetList();
                }
                else
                {
                    MessageBox.Show("Lütfen düzenlemek için bir ürün seçiniz !");
                }
            });
            AddProductCommand = new RelayCommand(o =>
            {
                var viewModel = new ProductAddPopUpViewModel();
                ProductAddPopUp view = new ProductAddPopUp();
                view.DataContext = viewModel;
                view.ShowDialog();
                GetList();
            });
        }

        private bool FilterProducts (object o)
        {
            if(o is ProductModel model)
            {
                return model.ProductName.ToLower().Contains(Filter.ToLower()) || model.ProductInfo.ToLower().Contains(Filter.ToLower());
            }
            return false;
        }

        private void GetList()
        {
            IProductRepository productRepo = new ProductRepository();
            Products.Clear();
            foreach (var model in productRepo.GetList(StoreRepository.CurrentAccount.StoreID)) { Products.Add(model); }
            ProductsCollectionView = CollectionViewSource.GetDefaultView(Products);
        }
    }
}
