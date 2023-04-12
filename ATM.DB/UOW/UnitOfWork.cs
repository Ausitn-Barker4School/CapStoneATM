using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Logic.Models;
using Dapper;
using ATM.DB.Interfaces;
using ATM.DB.Repository;

namespace ATM.DB.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IConnectionFactory Conn)
        {
            AccountAndPhone = new AccountAndPhoneRepository(Conn);
            Customer = new CustomerRepository(Conn);
            AccountAndPin = new AccountAndPinRepository(Conn);
        }

        public IAccountAndPin AccountAndPin { get; private set; }
        public ICustomer Customer { get; private set; }


        public IAccountAndPhone AccountAndPhone { get; private set; }
    }
}
