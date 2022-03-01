using System.ComponentModel.DataAnnotations;

namespace LotusTransformation.ViewModels.AdminLogIn
{
    public class AdministratorLogIn
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int MyProperty { get; set; }
    }
}
