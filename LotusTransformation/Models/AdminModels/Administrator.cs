using System.ComponentModel.DataAnnotations;

namespace LotusTransformation.Models
{
    public class Administrator
    {
        [Key]
        [Required]
        public int Key { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }  
    }
}
