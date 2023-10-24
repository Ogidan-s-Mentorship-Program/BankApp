using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class BillPayment
    {
        [Key] 
        public Guid Id { get; set; }

        [Required] 
        public Guid UserId { get; set; }

        [Required] 
        public decimal Amount { get; set; }

        public string Status { get; set; }

        [Required] 
        public Guid TransactionId { get; set; }

        [Required] 
        public decimal Charges { get; set; }

        [Required] 
        [DataType(DataType.DateTime)] 
        public DateTime PaymentDate { get; set; }
    }
}
