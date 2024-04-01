using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities 
{
    public class PhonePlan 
    {
        [Column("PlanId")]
        public Guid Id {get; set;}
        public string? Title {get; set;}
        public int DeviceLimit {get; set;}
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Price {get; set;}
    }
}