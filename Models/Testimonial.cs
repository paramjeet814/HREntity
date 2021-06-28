using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HREntity.Models
{
    public class Testimonial
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Email")]
        public string Email { get; set; }


        [Display(Name = "Comment ")]
        public string Comment { get; set; }


    }
}
