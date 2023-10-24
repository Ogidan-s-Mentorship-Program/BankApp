using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Loan
    {
        [Key] 
        public Guid Id { get; set; }

        [Required] 
        public Guid UserId { get; set; }

        [Required] 
        public string LoanType { get; set; }

        [Required] 
        public decimal LoanAmount { get; set; }

        [Required] 
        public decimal OutstandingBalance { get; set; }

        [Required]
        public decimal InterestRate { get; set; }

        [Required] 
        [DataType(DataType.DateTime)] 
        public DateTime NextPaymentDueDate { get; set; }
    }
}
