using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Logic.Models;

namespace ATM.DB.Interfaces
{
    public interface IAccountAndPhone
    {
       List<AccountAndPhone> GetAccount(string id);
        int AddPhone(AccountAndPhone entity);
        string GetPhone(string phone);
    }
}
