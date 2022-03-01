// TODO: File Upload To DB
using System.ComponentModel.DataAnnotations;

namespace LotusTransformation.Models
{
    public class ClientDocuments
    {
        [Required]
        [Key]
        public int Key { get; set; }   
    }
}
