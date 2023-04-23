using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Logic.Models;

namespace ATM.DB.Interfaces
{
    public interface IAccountAndPin
    {
        bool GetAccount(string id);
        int AddPin(AccountAndPin entity);
        bool GetPin(string accountNumber, int pin);
    }
}

