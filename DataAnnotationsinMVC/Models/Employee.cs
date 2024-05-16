using System;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsinMVC.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        [Required(ErrorMessage = "Firstname is mandatory to enter")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is mandatory to enter")]
        [StringLength(30, MinimumLength = 5)]
        public string LastName { get; set; }

        [Range(25, 40, ErrorMessage = "Minimum age is 25 and max is 40")]
        public int Age { get; set; }

        [Range(typeof(DateTime), "01-01-1970", "01-01-2008", ErrorMessage = "DateOfBirth in between 01-01-1970 and 01-01-2008")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }


        [MaxLength(25)]
        [MinLength(5)]
        public string Address { get; set; }

        [RegularExpression("^([0]|\\+91)?\\d{10}")]
        public string Mobile { get; set; }
        public string PostalCode { get; set; }
        [EmailAddress]
        public string EmailId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string Url { get; set; }
    }
}