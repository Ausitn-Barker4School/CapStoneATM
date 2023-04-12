using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace ATM.DB.Interfaces
{
   public interface IConnectionFactory
    {
        IDbConnection GetConnetion { get; }
    }
}
