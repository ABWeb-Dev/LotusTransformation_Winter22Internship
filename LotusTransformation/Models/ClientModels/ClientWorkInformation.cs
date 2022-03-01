using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotusTransformation.Models
{
    public class ClientWorkInformation
    {
        [Required]
        [Key]
        public int Key { get; set; }

        public string Occupation { get; set; }

        public string Company { get; set; }

        public string CompanyStreetAddress { get; set; }

        public string CompanyCity { get; set; }

        public string CompanyState { get; set; }

        public string CompanyPostal { get; set; }

        public string WorkEmail { get; set; }

        [ForeignKey("ClientID")]
        public ClientAccountInformation ClientAccountInformation { get; set; }
    }
}
