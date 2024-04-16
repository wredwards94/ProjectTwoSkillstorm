using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Billing
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(UserPlan))]
        public Guid UserPlanId { get; set; }

        [ForeignKey(nameof(User))]
        public string? UserId { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }

        [DataType(DataType.Date)]
        public DateTime BillingDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public bool IsPaid { get; set; }

        public string? PaymentMethod { get; set; }
        
        // public UserPlan UserPlan { get; set; }
        
        // public User? User { get; set; }
    }
}
