using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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



        public ClientContactInformation Contact { get; set; }


        public ClientWorkInformation Employment { get; set; }


        public ICollection<ClientDocuments> Documents { get; set; }


        [Required]
        public ICollection<ClientModels.ClientPreSessionResponses> PreSessionResponses { get; set; }


        [Required]
        public ICollection<ClientModels.ClientPostSessionResponses> PostSessionResponses { get; set; }
    }
}
