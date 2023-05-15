using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MallMan.Core
{
    //Bu class programda kullanılan bazı işe yarar eklentileri içermektedir
    internal class Extensions
    {
        public static readonly DependencyProperty Icon = DependencyProperty.RegisterAttached("Icon", typeof(string), typeof(Extensions), new PropertyMetadata(default(string)));

        //Bu fonksiyon xml dosyasındaki radio Buton'a icon eklememiz için gerekli
        public static void SetIcon(UIElement element, string value)
        {
            element.SetValue(Icon, value);
        }

        public static string GetIcon(UIElement element)
        {
            return (string)element.GetValue(Icon);
        }

        //Bu fonksiyon database'e kaydettiğimiz ByteArray türündeki veriyi BitmapImage haline getirmemizi sağlıyor.
        public static BitmapImage ImageFromBuffer(Byte[] bytes)
        {
            MemoryStream stream = new MemoryStream(bytes);
            stream.Seek(0, SeekOrigin.Begin);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();
            return image;
        }


        //Bu kod BitmapImage türündeki veriyi byteArray haline getirmemizi sağlıyor
        public static byte[] ImageSourceToBytes(ImageSource imageSource)
        {
            byte[] data;
            BitmapImage bitmapImage = imageSource as BitmapImage;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }

        //Bu kod içine girilen kod satırını try - catch bloğuna sokulmasını ve eğer bir hata yakalarsa message olarak verilmesini sağlıyor
        public static bool Test(Action act)
        {
            try
            {
                act();
                return true;
            }
            catch (Exception e) { MessageBox.Show(e.Message); return false; }
        }
    }
}
