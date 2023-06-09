﻿using System;
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
    public class AccountAndPinRepository : IAccountAndPin
    {

        private readonly IConnectionFactory _connectionFactory;

        public AccountAndPinRepository(IConnectionFactory conn)
        {
            _connectionFactory = conn;
        }

        public int AddPin(AccountAndPin entity)
        {
            var sql = "INSERT INTO AccountAndPin (AccountNumber, Pin) VALUES (@AccountNumber, @Pin)";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
                var result = connection.Execute(sql, entity); //This can be the issue Look at the CKK project to check. 
                return result;
            }
        }

        public  bool GetAccount(string id)
        {
            var sql = "SELECT * FROM AccountAndPin WHERE AccountNumber = @AccountNumber";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();

                var result = connection.QueryFirst(sql, new { AccountNumber = id });
                if(result != "")
                { return true; }
                else { return false; }
                
            }
        }

        public bool GetPin(string accountNumber, int pin)
        {
            var sql = "SELECT  * FROM AccountAndPin WHERE  AccountNumber = @AccountNumber AND Pin = @Pin";
            using (var connection = _connectionFactory.GetConnetion)
            {
                connection.Open();
               var result = connection.QueryFirst(sql, new { AccountNumber = accountNumber, Pin = pin });
                if (result != "")
                { return true; }
                else { return false; }
               
            }
            




        }
    }
}

