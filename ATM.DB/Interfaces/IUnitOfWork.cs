using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DB.Interfaces
{
    public interface IUnitOfWork
    {
        IAccountAndPhone AccountAndPhone { get; }
        ICustomer Customer { get; }
        IAccountAndPin AccountAndPin { get; }
    }
}
