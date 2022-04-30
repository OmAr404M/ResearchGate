using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResearchGate.Models
{
    public class Paper
    {

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        //for Created date
        public DateTime CreatedDate { get; set; }

        //Relationships
        public List<Auther_Paper> Authers_Papers { get; set; }

        //Comment
        public int CinemaId { get; set; }
        [ForeignKey("CommentId")]
        public Comment Comment { get; set; }

        //Like
        public int ProducerId { get; set; }
        [ForeignKey("LikeId")]
        public Like Like { get; set; }




    }
}
