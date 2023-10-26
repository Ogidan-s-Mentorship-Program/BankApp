using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class BillPayment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public Guid TransactionId { get; set; }
        public decimal Charges { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
