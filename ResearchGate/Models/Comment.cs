using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchGate.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Body")]
        [Required(ErrorMessage = "Body is required")]
        public string Body { get; set; }
        
        //Relationships
        public List<Paper> Papers { get; set; }

    }
}
