using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class AccountDTO
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public int AccountNumber { get; set; }

        public decimal Balance { get; set; }
    }
}
