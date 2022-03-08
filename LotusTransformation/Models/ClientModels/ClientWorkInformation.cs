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

        public string CompanyStreetAddress1 { get; set; }

        public string CompanyStreetAddress2 { get; set; }

        public string CompanyCity { get; set; }

        public string CompanyState { get; set; }

        public string CompanyPostal { get; set; }

        public string WorkEmail { get; set; }

        public string CompnayCountry { get; set; }

        [ForeignKey("EmploymentID")]
        public ClientAccountInformation Client { get; set; }
    }
}
