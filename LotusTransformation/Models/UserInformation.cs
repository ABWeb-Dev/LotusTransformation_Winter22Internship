using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LotusTransformation.Models
{
   
    public class UserInformation
    {

        [Required]
        [Key]
        public long UserID { get; set; }

        [Required]
        public string FirstName { get; set; }

        public char MiddleInitial { get; set; } // Optional

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address1 { get; set; }
        
        public string Address2 { get; set; } // Optional

        [Required]
        public string City { get; set; }

        [Required]
        public string StateOrProvince { get; set; }

        [Required]
        public string ZIPorPostal{ get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PrimaryEmail { get; set; }

        [Required]
        public string PrimaryPhoneNumber { get; set; }

        [Required]
        public string PrimaryPhoneType { get; set; }

        public string SecondaryEmail { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string SecondaryPhoneNumber { get; set; }

        public string SecondaryPhoneType { get; set; }

    }
}
