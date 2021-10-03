using Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IUnitOfWork
    {
        CustomerRepository Customers { get; }
        IAccountRepository Accounts { get; }
        void Save();
    }

}
