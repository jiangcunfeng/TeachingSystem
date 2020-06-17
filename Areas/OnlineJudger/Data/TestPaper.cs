using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    public class TestPaper
    {
        [Required]
        public string TestPaperId {get; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        public List<Question> Content {get; set;}
        public string Course {get; set;}  // Which course this test paper belongs to
    }
}