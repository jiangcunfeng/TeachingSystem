using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    public class Question
    {
        [Required]
        public string QuestionId {get; set;}
        [Required]
        public string Type {get; set;}  // "TrueOrFalse", "SingleChoice", "MultipleChoice"
        public string Name {get; set;}
        [Required]
        public string Content {get; set;}
        public string ChoiceA {get; set;}
        public string ChoiceB {get; set;}
        public string ChoiceC {get; set;}
        public string ChoiceD {get; set;}
        [Required]
        public string Answer {get; set;}  // e.g. "T","F","A","B","C","D","AC","ABCD"
        public string Course {get; set;}  // Which course this question belong to
        public string Point {get; set;}  // Knowledge point
    }
}