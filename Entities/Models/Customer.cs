using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Customer 
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        [MaxLength(20)]
        [MinLength(4)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool DefaultPassword { get; set; }
        public bool IsActive { get; set; }

    }
}
