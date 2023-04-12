using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DB.Interfaces
{
    public interface ICustomer
    {
        string GetAccount(string account);
        string GetFirstName(string firstName);
        string GetLastName(string lastName);
        decimal GetFunds(decimal funds);

    }
}
