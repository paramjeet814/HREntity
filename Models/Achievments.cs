using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HREntity.Models
{
    public class Achievments
    {
        public int Id { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }


        [Display(Name = "Description")]
        public string Description { get; set; }


     
    }
}
