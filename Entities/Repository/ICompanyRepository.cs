using Entities.Models;
using System.Collections.Generic;

namespace Entities.Repository
{
    public interface ICompanyRepository
    {
        IEnumerable<Customer> GetAllCustomers (bool trackChanges);
        
    }
}