using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankApp.DataAccess.Entities
{
    public class User
    {
        [Key] 
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required] 
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        [EmailAddress] 
        public string Email { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();

        public List<Address> Addresses { get; set; } = new List<Address>();

        public string Gender { get; set; }

        [DataType(DataType.Date)] 
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
