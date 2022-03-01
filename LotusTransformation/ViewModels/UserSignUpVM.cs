using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LotusTransformation.Data;



namespace LotusTransformation.ViewModels 

{
    public class UserSignUpVM 
    {

        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your first name")]
        [RegularExpression("^((?!^FirstName$)[a-zA-Z '])+$", ErrorMessage = "Please only use letters in your name")]
        [MinLength(2)]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your last name")]
        [RegularExpression("^((?!^LastName$)[a-zA-Z '])+$", ErrorMessage = "Please only use letters in your name")]
        [MinLength(2)]
        [MaxLength(25)]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A valid mailing address is required")]
        public string Address1 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A valid City is required")]
        public string City { get; set; }

        [RegularExpression("^((?!^StateOrProvince$)[a-zA-Z '])+$", ErrorMessage = "Please only use letters in your name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "A valid State, Province or Region is required")]
        public string StateOrProvince { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your ZIP or Postal Code")]
        [MinLength(2)]
        [MaxLength(8)]
        public string ZIPorPostal { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Valid Country is required")]
        public string Country { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a Username")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a Password")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter an email address")]
        [RegularExpression("^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\\.[A-Za-z0-9-]{2,}$",
        ErrorMessage = "Email is required and must be properly formatted.")]
        [EmailAddress]
        public string PrimaryEmail { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please a phone number")]
        [Phone]
        public string PrimaryPhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select phone type")]
        public string PrimaryPhoneType { get; set; }

        // Optional user information, not required
        /// <summary>
        /// Below Fields are optional. They should still have the same Regex restrictions as the above form fields to prevent SQL Injects XSS attacks
        /// </summary>
        [RegularExpression("^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\\.[A-Za-z0-9-]{2,}$",
        ErrorMessage = "Email must be properly formatted.")]
        [EmailAddress]
        public string SecondaryEmail { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Phone]
        public string SecondaryPhoneNumber { get; set; }

        public string SecondaryPhoneType { get; set; }

        public char MiddleInitial { get; set; }

        public string Address2 { get; set; }
    }
}

