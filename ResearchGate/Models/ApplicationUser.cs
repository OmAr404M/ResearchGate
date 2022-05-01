using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ResearchGate.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Fisrt name")]
        public string FisrtName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }
    }
}
