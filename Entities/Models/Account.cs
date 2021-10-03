using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Account 
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int AccountNumber { get; set; }

        [Column(TypeName = "decimal(38,2)")]
        public decimal Balance { get; set; }
   
    }

}
