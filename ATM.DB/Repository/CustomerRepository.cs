using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DB.Interfaces;
using Dapper;

namespace ATM.DB.Repository
{
    public class CustomerRepository : ICustomer
    {
        private readonly IConnectionFactory _connectionFactory;

        public CustomerRepository(IConnectionFactory conn)
        {
            _connectionFactory = conn;
        }

        public List<string> GetAccount(string id)
        {
            var sql = "SELECT * FROM Customer WHERE AccountNumber = @AccountNumber";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.Query<string>(sql, new { AccountNumber = id }).ToList();
                return result;
            }
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

        public decimal UpdateFunds(decimal funds, string id)
        {
            var sql = "UPDATE Customer SET Funds = @Funds WHERE AccountNumber =@AccountNumber";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.Execute(sql, new { Funds = funds, AccountNumber = id });
                return result;
            }
        }
    }
}
