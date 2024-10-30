using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMAmvc.Models.enums;

namespace TMAmvc.Models.entities
{
    public class User : BaseEntity
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string PhoneNumber {get; set;}
        public string Role {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public decimal Wallet {get; set;}
        public Gender Gender {get; set;}
        public int Age {get; set;}
        public DateTime DateOfBirth {get; set;}
        public string ProfilePicturePath {get; set;}
    }
}