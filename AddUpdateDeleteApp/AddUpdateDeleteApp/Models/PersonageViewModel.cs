using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddUpdateDeleteApp.Models
{
    public class PersonageViewModel
    {
        public int PersonageViewModelId { get; set; }
        [Required(ErrorMessage ="Enter Person's Name")]
        public string Name { get; set; }
        [StringLength(maximumLength : 11)]
        [Display(Name ="Phone Number")]
        [Required(ErrorMessage = "Enter Person's Phone Number")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage ="Enter Email Address")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter correct email address")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Enter Person Address")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Select IsActive")]
        public bool  IsActive { get; set; }


    }
}
