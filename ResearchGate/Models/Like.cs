using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchGate.Models
{
    public class Like
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; }
        
         //Relationships
        public List<Paper> Papers { get; set; }


    }
}
