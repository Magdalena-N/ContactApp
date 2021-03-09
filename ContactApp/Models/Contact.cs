using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApp.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [UniqueEmail]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Password { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string MobilePhone { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public ContactCategory Category { get; set; }
    }

    public enum ContactCategory
    {
        Business,
        Private,
        Other
    }

    public class UniqueEmail : ValidationAttribute
    {
        public UniqueEmail()
        {
            ErrorMessage = "Email is already in use.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var contact = (Contact)validationContext.ObjectInstance;
            var email = (string)value;
            if (contact.Email.Equals(email))
            {
                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
