﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entites
{
    public class NextOfKin 
    {
        public new Guid Id { get; set; } 
        public new string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string AccountId { get; set; }
        public Guid UserId { get; set; }
    }
}
