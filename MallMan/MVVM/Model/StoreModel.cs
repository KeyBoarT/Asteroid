using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MallMan.MVVM.Model
{
    public class StoreModel
    {
        private int _storeID;
        private int _mallID;
        private string _storeName;
        private string _ownerName;
        private string _storePassword;
        private ImageSource _image;
        public int StoreID
        {
            get { return _storeID; }
            set { _storeID = value; }
        }

        public int MallID
        {
            get { return _mallID; }
            set { _mallID = value; }
        }

        public string StoreName
        {
            get { return _storeName; }
            set { _storeName = value; }
        }

        public string OwnerName
        {
            get { return _ownerName; }
            set { _ownerName = value; }
        }

        public string StorePassword
        {
            get { return _storePassword; }
            set { _storePassword = value; }
        }

        public ImageSource Image
        {
            get { return (_image != null)? _image: new BitmapImage(new Uri(@"C:\Users\mehme\source\repos\MallMan\MallMan\ExampleImage\developerImageNotFound.jpg")); }
            set { _image = value; }
        }
    }
}
