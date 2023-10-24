using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Transactions
    {
        [Key] 
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public decimal Amount { get; set; }

        public string Description { get; set; }

        [DataType(DataType.DateTime)] 
        public DateTime TransactionDate { get; set; }

        public TransactionType Type { get; set; }

        [EnumDataType(typeof(Status))] 
        public Status Status { get; set; }

        [EnumDataType(typeof(ActionType))] 
        public ActionType ActionType { get; set; }

        public string SenderAccountName { get; set; }
        public string SenderAccountNumber { get; set; }
        public string ReceiverAccountName { get; set; }
        public string ReceiverAccountNumber { get; set; }

        [MaxLength(255)] // Specifies a maximum length of 255 characters for ReferenceNumber.
        public string ReferenceNumber { get; set; }

        public decimal Charges { get; set; }

        public Guid UserId { get; set; }

        [MaxLength(255)] // Specifies a maximum length of 255 characters for Narration.
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
