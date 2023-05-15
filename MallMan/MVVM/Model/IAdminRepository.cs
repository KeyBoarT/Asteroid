using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MallMan.MVVM.Model
{
    public interface IAdminRepository
    {
        bool AuthenticateAdmin(int id, string password);
        void Add(AdminModel adminModel);
        void Edit(AdminModel adminModel);
        void Remove(int id);
        AdminModel GetById(int id);
        AdminModel GetByAdminEmail(string adminEmail);
    }
}
