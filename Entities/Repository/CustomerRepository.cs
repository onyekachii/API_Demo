using Entities.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Customer> GetAllCompanies(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(c => c.Id).ToList();
    }
}
