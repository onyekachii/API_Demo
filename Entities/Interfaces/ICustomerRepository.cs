using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface ICustomerRepository 
    {
        IEnumerable<Customer> GetAllCustomers(bool trackChanges);
    }
}
