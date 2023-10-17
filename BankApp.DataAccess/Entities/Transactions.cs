using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Entities
{
    public class Transactions
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType Type { get; set; }
        public string Status { get; set; }
        public string ActionType { get; set; }
        public string SenderAccountName { get; set; }
        public string SenderAccountNumber { get; set; }
        public string ReceiverAccountName { get; set; }
        public string ReceiverAccountNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public decimal Charges { get; set; }
        public Guid UserId { get; set; }
        public string Narration { get; set; }

    }


    public enum TransactionType
    {
        Buy,
        Sell,
        Dividend,
        Interest
    }
    public enum Status
    {
        Pending,
        Succesful,
        Failed
    }

    public enum ActionType
    {
        Withdrawal,
        Deposit,
        Transfer
    }
}
