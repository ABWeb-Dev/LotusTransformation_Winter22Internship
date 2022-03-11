using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotusTransformation.Models.ClientModels
{
    public class ClientPostSessionResponses
    {
        [Required]
        [Key]
        public long Key { get; set; }

        [Required]
        public string QuestionOne { get; set; }

        [Required]
        public string QuestionTwo { get; set; }

        [Required]
        public string QuestionThree { get; set; }

        [Required]
        public string QuestionFour { get; set; }

        [Required]
        public string QuestionFive { get; set; }

        [Required]
        public string QuestionSix { get; set; }

        [ForeignKey("PostSessionID")]
        public ClientAccountInformation Client { get; set; }
    }
}
