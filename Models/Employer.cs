using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HREntity.Models
{
    public class Employer
    {
        public int Id { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Address ")]
        public string Address { get; set; }

        [Display(Name = "Job Tile ")]
        public string JobTitle { get; set; }

        [Display(Name = "Seats")]
        public string Seats { get; set; }


        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}
