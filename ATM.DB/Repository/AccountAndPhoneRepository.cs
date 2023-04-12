using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DB.Interfaces;

namespace ATM.DB.Repository
{
    public class AccountAndPhoneRepository : IAccountAndPhone
    {
        private readonly IConnectionFactory _connectionFactory;

        public AccountAndPhoneRepository(IConnectionFactory conn)
        {
            _connectionFactory = conn;
        }

        public string AddPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public string GetAccount(string id)
        {
            throw new NotImplementedException();
        }

        public string GetPhone(string phone)
        {
            throw new NotImplementedException();
        }
    }
}
