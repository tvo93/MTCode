using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student : Person
    {
     
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        // Check point: A Student "has a" CreditsEarned property 
        [Display(Name = "Credits Earned")]
        public int CreditsEarned { get; set; }

        // Check point: A Student "has a" Gpa property that can express overall grades with exactly
        // 2 decimal points, such as 3.87, etc.
        [Display(Name = "Overall GPA")]
        [Range(0.7, 4.0, ErrorMessage = "Please enter a GPA between 0.7 and 4.00")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public Double Gpa { get;set;
             
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}