using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u23564556_Practical_02.Models
{
	public class studyGroup
	{
        [Key] // Primary key
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Current Age")]
        public int Age { get; set; } = 0;

        [Display(Name = "Living Status")]
        public bool IsAlive { get; set; } = true;

        [Display(Name = "Email Adress")]
        public string EmailAddress { get; set; }

        [Display(Name = "Link")]
        public string myLink { get; set; }

        
    }
}