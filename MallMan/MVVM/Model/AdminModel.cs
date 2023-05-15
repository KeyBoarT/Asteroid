using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MallMan.MVVM.Model
{
    public class AdminModel
    {
        private int _adminID;
        private string _adminName;
        private string _adminPassword;
        private string _adminEmail;
        private ImageSource _adminImage;

        public int AdminID
        {
            get { return _adminID; }
            set { _adminID = value; }
        }

        public string AdminName
        {
            get { return _adminName; }
            set { _adminName = value; }
        }

        public string AdminPassword
        {
            get { return _adminPassword; }
            set { _adminPassword = value; }
        }

        public string AdminEmail
        {
            get { return _adminEmail; }
            set { _adminEmail = value; }
        }

        public ImageSource AdminImage
        {
            get
            {
                if (_adminImage == null)
                    return new BitmapImage(new Uri( $@"{new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\ExampleImage\unknownAdmin.jpg"));
                else
                    return _adminImage;
            }
            set { _adminImage = value; }
        }
    }
}
