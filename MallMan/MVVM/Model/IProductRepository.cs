using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallMan.MVVM.Model
{
    public interface IProductRepository
    {
        void Add(ProductModel model);
        void Remove(int id);
        void Update(ProductModel model);
        List<ProductModel> GetList(int storeID);
        ProductModel GetById(int id);
    }
}
