using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_pthoma24.Models
{
    // Create Getters and Setters for each label in the from
    public class GradeModel
    {
        // Create validation methods to require inputs that are between 0 and 100
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public string Assignments { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public string Projects { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public string Quizzes { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public string Midterm { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public string Final { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public string INTEX { get; set; }
    }
}

        /*
        // Assignments model expanded
        public void setFrom(string input)
        {
            this.Assignments = input
        }

        // This is the Getter
        public string getFrom ()
        {
            return this.From;
        }
        */

