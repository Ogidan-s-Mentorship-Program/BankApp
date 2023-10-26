﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Account
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
        public string BVN { get; set; }
        public string NIN { get; set; }
        public string AccountName { get; set; }
        public string HolderAddress { get; set; }
        public bool IsActive { get; set; }
        public Guid UserId { get; set; }
    }
}
