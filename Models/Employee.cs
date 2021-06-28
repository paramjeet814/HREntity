using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HREntity.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Address ")]
        public string Address { get; set; }


        [Display(Name = "Email")]
        public string Email { get; set; }


        [Display(Name = "Contact ")]
        public string Contact { get; set; }

        [Display(Name = "Qualification")]
        public string Qualification { get; set; }


    }
}
