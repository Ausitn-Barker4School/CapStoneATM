using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DB.Interfaces
{
    public interface IAccountAndPin
    {
        string GetAccount(string id);
        int AddPin(int pin);
        int GetPin(int pin);
    }
}
