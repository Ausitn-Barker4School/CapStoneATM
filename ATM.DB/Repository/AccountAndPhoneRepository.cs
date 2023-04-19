using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DB.Interfaces;
using Dapper;

namespace ATM.DB.Repository
{
    public class AccountAndPhoneRepository : IAccountAndPhone
    {
        private readonly IConnectionFactory _connectionFactory;

        public AccountAndPhoneRepository(IConnectionFactory conn)
        {
            _connectionFactory = conn;
        }

        public string AddPhone(string accountNumber, string phone)
        {
            var sql = "Insert into AccountAndPhone (AccountNumber, PhoneNumber) VALUE(@AccountNumber, @PhoneNumber)";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault(sql, new {AccountNumber = accountNumber, Phone = phone });
                return result;
            }
        }

        public List<string> GetAccount(string id)
        {
            var sql = "SELECT * FROM AcountAndPhone WHERE AccountNumber = @AccountNumber";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.Query<string>(sql, new { AccountNumber = id }).ToList();
                return result;
            }
        }

        public string GetPhone(string phone)
        {
            var sql = "SELECT * FROM AcountAndPhone WHERE Phone = @Phone";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.QuerySingleOrDefault<string>(sql, new { Phone = phone });
                return result;
            }
        }
    }
}
