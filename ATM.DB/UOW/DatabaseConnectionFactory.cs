using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using ATM.DB.Interfaces;
using NLog.Internal;



namespace ATM.DB.UOW
{
    public class DatabaseConnectionFactory : IConnectionFactory
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        private readonly string connectionString =
            "Data Source = (localdb)\\MSSQLLocalDB;" +
            "Initial Catalog = CapeStoneATM;" +
            "Trusted_Connection=True;";

       
        

        public IDbConnection GetConnetion
        {
            get
            {
                

                DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionString;

                //conn.Open();
                return conn;
            }
        }
    }
}
