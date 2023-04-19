using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DB.Interfaces
{
    public interface IAccountAndPhone
    {
       List<string> GetAccount(string id);
        string AddPhone(string accountNumber, string phone);
        string GetPhone(string phone);
    }
}
