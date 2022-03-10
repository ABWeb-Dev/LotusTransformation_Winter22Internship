using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotusTransformation.Models
{
    public class ClientContactInformation
    {
        [Key]
        public long ContactID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string PhoneType { get; set; }

        [Required]
        public string Address1 { get; set; }

        public string Address2 { get; set; } // Optional

        [Required]
        public string City { get; set; }

        [Required]
        public string StateOrProvince { get; set; }

        [Required]
        public string ZIPorPostal { get; set; }

        [Required]
        public string Country { get; set; }

        [ForeignKey("ClientContactID")]
        public ClientAccountInformation Client { get; set; }
    }
}
