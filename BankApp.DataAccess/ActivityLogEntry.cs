using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess
{
    public class ActivityLogEntry
    {

        public int LogEntryId { get; set; }       
        public DateTime Timestamp { get; set; }   
        public string? UserOrEntity { get; set; }   
        public string? EventType { get; set; }     
        public string? Details { get; set; }        
        public string? IPAddress { get; set; }      
        public string? SessionID { get; set; }      
        public string? ClientDevice { get; set; }   
        public string? Location { get; set; }      
        public string? Result { get; set; }         
        public TimeSpan Duration { get; set; }     
        public string? RequestData { get; set; }    
        public string? ResponseData { get; set; }   
        public string? EventSource { get; set; }    
        public string? TransactionID { get; set; }  
        public string? UserRole { get; set; }       
        public string? CorrelationID { get; set; }
        public List<string>? Tags { get; set; }


    }
}
