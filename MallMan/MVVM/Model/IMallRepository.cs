using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallMan.MVVM.Model
{
    public interface IMallRepository
    {
        void Add(MallModel mallModel);
        void Remove(int adminCityID);
        List<MallModel> GetList(int adminID);
    }
}
