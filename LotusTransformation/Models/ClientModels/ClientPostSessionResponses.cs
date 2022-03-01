using System.ComponentModel.DataAnnotations;

namespace LotusTransformation.Models.ClientModels
{
    public class ClientPostSessionResponses
    {
        [Required]
        [Key]
        public int Key { get; set; }
        public string QuestionOne { get; set; }

        public string QuestionTwo { get; set; }

        public string QuestionThree { get; set; }

        public string QuestionFour { get; set; }

        public string QuestionFive { get; set; }

        public string QuestionSix { get; set; }

        public ClientAccountInformation ClientAccountInformation { get; set; }
    }
}
