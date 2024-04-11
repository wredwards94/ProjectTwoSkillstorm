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

        [ForeignKey(nameof(Plan))]
        public Guid PlanId { get; set; }

        [ForeignKey(nameof(User))]
        public string? UserId { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalAmount { get; set; }

        [DataType(DataType.Date)]
        public DateTime BillingDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public bool IsPaid { get; set; }

        public string? PaymentMethod { get; set; }

        public PhonePlan? Plan { get; set; }

        public User? User { get; set; }
    }
}
