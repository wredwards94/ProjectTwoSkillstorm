using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Billing
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public Guid UserId { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalAmount { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsPaid { get; set; }
        public string? PaymentMethod { get; set; }
        public PhonePlan? Plan { get; set; }
        public User? User { get; set; }
    }
}
