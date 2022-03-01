using System.ComponentModel.DataAnnotations;

namespace LotusTransformation.ViewModels.ClientResponses
{
    public class ClientResponsesPreSessionViewModel
    {
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

        [Required]
        public string QuestionSeven { get; set; }
    }
}
