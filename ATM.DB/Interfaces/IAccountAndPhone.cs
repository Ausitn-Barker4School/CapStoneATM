using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DB.Interfaces
{
    public interface IAccountAndPhone
    {
       string GetAccount(string id);
        string AddPhone(string phone);
        string GetPhone(string phone);
    }
}
