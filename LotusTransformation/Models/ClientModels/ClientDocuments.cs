// TODO: File Upload To DB
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotusTransformation.Models
{
    public class ClientDocuments
    {
        [Required]
        [Key]
        public int Key { get; set; }

        [ForeignKey("DocumentID")]
        public ClientAccountInformation Client { get; set; }
    }
}
