using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DB.Interfaces;
using ATM.Logic.Models;
using Dapper;

namespace ATM.DB.Repository
{
    public class AccountAndPinRepository : IAccountAndPin
    {

        private readonly IConnectionFactory _connectionFactory;

        public AccountAndPinRepository(IConnectionFactory conn)
        {
            _connectionFactory = conn;
        }

        public int AddPin(string accountNumber, int pin)
        {
            var sql = "Insert into AccountAndPin (AccountNumber, Pin) VALUE(@AccountNumber, @Pin)";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault(sql, new { AccountNumber = accountNumber, Pin = pin });
                return result;
            }
        }

        public string GetAccount(string id)
        {
            var sql = "SELECT TOP 1 * FROM AccountAndPin WHERE AccountNumber = @AccountNumber";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault(sql, new { AccountNumber = id });
                return result;
            }
        }

        public bool GetPin(string accountNumber, int pin)
        {
            var sql = "SELECT TOP 1 * FROM AccountAndPin WHERE  AccountNumber = @AccountNumber AND Pin = @Pin";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
               var result = connection.QueryFirst(sql, new { AccountNumber = accountNumber, Pin = pin });
                
                //I am still having issues with the testing of the pins and the account and it will just say that it is invalide. 

            }




        }
    }
}

/*
 var sql = "SELECT * FROM AccountAndPin WHERE  AccountNumber = @AccountNumber AND Pin = @Pin";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
               
                var result = connection.QueryFirstOrDefault(sql, new { AccountNumber = accountNumber, Pin = pin });
                
                

            }
 */