﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ResearchGate.Models
{
    public class Paper
    {

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        //for Created date
        public DateTime CreatedDateTime { get; set; }
       
        

    }
}
