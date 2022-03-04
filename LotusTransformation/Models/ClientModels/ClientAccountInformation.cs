using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LotusTransformation.Models
{
   
    public class ClientAccountInformation
    {

        [Required]
        [Key]
        public int ClientID { get; set; }

        [Required]
        public string FirstName { get; set; }

        public char MiddleInitial { get; set; } // Optional

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [ForeignKey("ContactID")]
        public ClientContactInformation Contact { get; set; }

        [ForeignKey("EmploymentID")]
        public ClientWorkInformation Employment { get; set; }

        public ICollection<ClientDocuments> ClientDocuments { get; set; }  

        public ICollection<ClientModels.ClientPreSessionResponses> ClientPreSessionResponses { get; set; }

        public ICollection<ClientModels.ClientPostSessionResponses> ClientPostSessionResponses { get; set; }

        
    }
}
