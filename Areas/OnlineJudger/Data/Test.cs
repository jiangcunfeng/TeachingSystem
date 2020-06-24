using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    public class Test
    {
        [Required]
        public string TestId {get; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        public string className {get; set;}
        [Required]
        public string TestPaperId {get; set;}
        public string start_time {get; set;}
        public string end_time {get; set;}
    }
}