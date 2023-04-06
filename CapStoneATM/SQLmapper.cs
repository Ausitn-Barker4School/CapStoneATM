using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;


namespace CapStoneATM
{
   public class SQLmapper
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        private readonly string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;" +
            "Initial Catalog = CapeStoneATM"
            + "Trusted_Connection=True;";

        //public IDbConnection GetConnection
        //{
        //    get
        //    {
        //        DbProviderFactories.RegisterFactory("System.Data.SqlClient");
        //        var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
        //        var conn = factory.CreateConnection();
        //        conn.ConnectionString = connectionString;

        //        //conn.Open();
        //        return conn;
        //    }
        //}
    }
}
