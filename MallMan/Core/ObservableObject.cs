using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MallMan.Core
{
    class ObservableObject: INotifyPropertyChanged
    {
        //Bu sınıf MVVM kalıbımızın ViewModel Katmanının View katmanı tarafından anlaşılabilmesi için, built-in olarak verilen INotifyPropertyChanged interface'ini daha kolay hale getirmiştir.
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChaned([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
