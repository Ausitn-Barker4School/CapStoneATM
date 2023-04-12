using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DB.Interfaces;

namespace ATM.DB.Repository
{
    public class CustomerRepository : ICustomer
    {
        private readonly IConnectionFactory _connectionFactory;

        public CustomerRepository(IConnectionFactory conn)
        {
            _connectionFactory = conn;
        }

        public string GetAccount(string account)
        {
            throw new NotImplementedException();
        }

        public string GetFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public decimal GetFunds(decimal funds)
        {
            throw new NotImplementedException();
        }

        public string GetLastName(string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
