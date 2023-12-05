using BankApp.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.DTOs.RequestDTOs
{
    public class UpdateUserRequestDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public PhoneNumber PhoneNumbers { get; set; }
        public Address Addresses { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

    }
}
