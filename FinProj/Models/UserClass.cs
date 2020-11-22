using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinProj.Models
{
    public class UserClass
    {
        [Key]
        public int UserId {get;set ;}

        [Required(ErrorMessage ="Please enter your name")]
        [Display(Name ="User name")]
        public string Username { get; set;}

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pword { get; set; }

        [Required(ErrorMessage = "Please enter your confirmation password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Pword")]
        public string CnfPWord { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Email")]
        public string UEmail { get; set; }

        [Required(ErrorMessage = "Select gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Select marital status")]
        [Display(Name = "Marital Status")]
        public string MaritalStat { get; set; }

    }
    
}
