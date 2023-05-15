using System.Windows.Controls;
using System.Windows.Media;

namespace MallMan.MVVM.Model
{
    public class ProductModel
    {
        private int _productID;
        private int _storeID;
        private string _productName;
        private int _productAmount;
        private float _productPrice;
        private ImageSource _productImage;
        private string _productInfo;
        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        public int StoreID
        {
            get { return _storeID; }
            set { _storeID = value; }
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public int ProductAmount
        {
            get { return _productAmount; }
            set { _productAmount = value; }
        }

        public float ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }

        public ImageSource ProductImage
        {
            get { return _productImage; }
            set { _productImage = value; }
        }

        public string ProductInfo
        {
            get { return _productInfo; }
            set { _productInfo = value; }
        }
    }
}
