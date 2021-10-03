using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class CustomerDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }                
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool DefaultPassword { get; set; }
        public bool IsActive { get; set; }
    }
}
