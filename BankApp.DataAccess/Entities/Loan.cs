using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Entities
{
    public class Loan
    {
       public Guid Id { get; set; }
       public Guid UserId { get; set; }
        public string LoanType { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal OutstandingBalance { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime NextPaymentDueDate { get; set; }

    }

    public enum LoanType
    {
        PersonalLoan,
        MortgageLoan,
        AutoLoan
    }
}

