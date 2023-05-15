using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallMan.MVVM.Model
{
    public interface IStoreRepository
    {
        void Add(StoreModel model);
        bool AuthenticateStore(int id, string password);
        void Edit(StoreModel model);
        void Remove(int id);
        StoreModel GetById(int id);
        List<StoreModel> GetList(int MallID);
    }
}
