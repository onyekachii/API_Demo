using Entities.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(ApplicationContext context) : base(context)
        {
        }

        public Account FindAccount(Guid Id)
        {
            return GetById(Id);
        }
                
    }
}
