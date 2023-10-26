﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class Address
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string PostalCode { get; set; } = string.Empty;
        public string MainAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
    }
}