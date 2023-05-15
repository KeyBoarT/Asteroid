using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MallMan.MVVM.Model
{
    public class DeveloperModel
    {
        private string _developerMail;
        private string _developerName;
        private string _developerCV;
        private ImageSource _developerImage;

        public string DeveloperMail
        {
            get { return _developerMail; }
            set { _developerMail = value; }
        }

        public string DeveloperName
        {
            get
            { return _developerName; }
            set { _developerName = value;}
        }

        public string DeveloperCV
        {
            get { return _developerCV; }
            set { _developerCV = value; }
        }

        public ImageSource DeveloperImage
        {
            get
            {
                if (_developerImage == null)
                {
                    return new BitmapImage(new Uri(@"C:\Users\mehme\source\repos\MallMan\MallMan\ExampleImage\developerImageNotFound.jpg"));
                }
                else
                    return _developerImage;
            }
            set { _developerImage = value; }
        }
    }
}
