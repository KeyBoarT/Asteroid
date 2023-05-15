using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallMan.MVVM.Model
{
    public interface IDeveloperRepository
    {
        //Developerlar server tarafından düzenleceği için program içinde sadece get edilmeleri yeterli...
        DeveloperModel GetByMail(string mail);
    }
}
