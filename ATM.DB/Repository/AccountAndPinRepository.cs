using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DB.Interfaces;

namespace ATM.DB.Repository
{
    public class AccountAndPinRepository : IAccountAndPin
    {

        private readonly IConnectionFactory _connectionFactory;

        public AccountAndPinRepository(IConnectionFactory conn)
        {
            _connectionFactory = conn;
        }

        public int AddPin(int pin)
        {
            throw new NotImplementedException();
        }

        public string GetAccount(string id)
        {
            throw new NotImplementedException();
        }

        public int GetPin(int pin)
        {
            throw new NotImplementedException();
        }
    }
}
