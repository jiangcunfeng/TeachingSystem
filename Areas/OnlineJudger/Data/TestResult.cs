using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    public class TestResult{
        public string TestResultId { get; set; }
        public string TestPaperId {get; set;}
        public string StudentId {get; set;}
        [Required]
        //QuestionId,Answer
        Dictionary<string, string> QA = new Dictionary<string, string>();
        
    }
}