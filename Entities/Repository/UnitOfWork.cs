using Entities.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext _context;
        private CustomerRepository _customers;
        private IAccountRepository _accounts;

        public UnitOfWork(ApplicationContext Context)
        {
            _context = Context;
        }

        public CustomerRepository Customers { get { return _customers ??= _customers = new CustomerRepository(_context); } }
        public IAccountRepository Accounts { get { return _accounts ??= _accounts = new AccountRepository(_context); } }

        public void Save() => _context.SaveChanges();

    }
}
