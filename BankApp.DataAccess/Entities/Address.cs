﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DataAccess.Entities
{
    public class Address
    {
        public string PostalCode { get; set; } = string.Empty;
        public string MainAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
    }
}
