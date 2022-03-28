using System.ComponentModel.DataAnnotations;

namespace LotusTransformation.ViewModels.ClientResponses
{
    public class ClientResponsesPreSessionViewModel
    {
        [Required]
        public string PreSessionQuestionOne { get; set; }

        [Required]
        public string PreSessionQuestionTwo { get; set; }

        [Required]
        public string PreSessionQuestionThree { get; set; }

        [Required]
        public string PreSessionQuestionFour { get; set; }

        [Required]
        public string PreSessionQuestionFive { get; set; }

        [Required]
        public string PreSessionQuestionSix { get; set; }

    }
}
