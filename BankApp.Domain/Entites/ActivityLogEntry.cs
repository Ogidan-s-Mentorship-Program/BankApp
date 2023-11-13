using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entites
{
    public class ActivityLogEntry
    {
            public Guid Id { get; set; } = Guid.NewGuid();
            public Guid LogEntryId { get; set; }
            public DateTime Timestamp { get; set; }
            public string? User { get; set; }
            public EventType EventType { get; set; }
            public string? Details { get; set; }
            public LogResult Result { get; set; } 
            public TimeSpan Duration { get; set; }
            public string? RequestData { get; set; }
            public string? ResponseData { get; set; }
            public string? EventSource { get; set; }
            public TransactionType? TransactionType { get; set; }

        }

        public enum EventType
        {
            Login,
            Logout,
            FileUpload,
        }

        public enum LogResult
        {
            Success,
            Failure,
            Incomplete,
        }

        public enum TransactionType
        {
            Deposit,
            Withdrawal,
            Transfer,
        }

      

    }

