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

        public int UserID { get; set; }

        [Required(ErrorMessage = "Please Enter Your Username..")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Your Password..")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string PWord { get; set; }

        [Required(ErrorMessage = "Please Enter Your Password Confirmation..")]
        [DataType(DataType.Password)]
        [Display(Name = "Password Confirmation: ")]
        [Compare("PWord")]
        public string CnfPword { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email..")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email: ")]
        public string UEmail { get; set; }

        [Required(ErrorMessage = "Please Enter Your Gender..")]
        [Display(Name = "Gender: ")]
        public char Gender { get; set; }

        [Required(ErrorMessage = "Please Enter Your Marital Status..")]
        [Display(Name = "Marital Status: ")]
        public string MaritalStat { get; set; }

        
    }
}
