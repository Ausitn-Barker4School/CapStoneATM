using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DB.Interfaces;
using ATM.Logic.Models;
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

        public int AddPhone(AccountAndPhone entity)
        {
            var sql = "INSERT INTO AccountAndPhone (AccountNumber, PhoneNumber) VALUE(@AccountNumber, @PhoneNumber)";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.Execute(sql, entity);
                return result;
            }
        }

        public List<AccountAndPhone> GetAccount(string id)
        {
            var sql = "SELECT * FROM AccountAndPhone WHERE AccountNumber = @AccountNumber";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.Query<AccountAndPhone>(sql, new { AccountNumber = id }).ToList();
                return result;
            }
        }

        public string GetPhone(string phone)
        {
            var sql = "SELECT * FROM AccountAndPhone WHERE Phone = @Phone";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.QuerySingleOrDefault<string>(sql, new { Phone = phone });
                return result;
            }
        }
    }
}
