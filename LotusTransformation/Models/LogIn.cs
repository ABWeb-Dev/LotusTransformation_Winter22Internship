using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LotusTransformation.Models
{
    [Table("LogIn")]
    
    
    public class LogIn
    {

        [Required]
        [ForeignKey("UserID")]
        [Key()]
        public long UserID{ get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual UserInformation UserInformation { get; set; }


    }
}
