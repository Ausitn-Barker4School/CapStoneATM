using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DB.Interfaces;
using ATM.Logic.Models;
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

        public string GetFirstName(string id)
        {
            throw new NotImplementedException();
        }

        public string GetFunds(string id)//It will not get the funds so I can change them. 
        {
            var sql = "SELECT Funds FROM Customer WHERE AccountNumber = @AccountNumber";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.QueryFirst(sql, new { AccountNumber = id });
                
                return result;
            }
        }

        public string GetLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public decimal UpdateFunds(decimal funds, string id)
        {
            var sql = "UPDATE Customer SET Funds = Funds - @Funds WHERE AccountNumber =@AccountNumber";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.Execute(sql, new { Funds = funds, AccountNumber = id });
                return result;
            }
        }
    }
}
