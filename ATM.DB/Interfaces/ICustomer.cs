using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Logic.Models;

namespace ATM.DB.Interfaces
{
    public interface ICustomer
    {
        List<string> GetAccount(string id);
        string GetFirstName(string firstName);
        string GetLastName(string lastName);
        string GetFunds(string id);
        decimal UpdateFunds(decimal funds, string id);

    }
}
