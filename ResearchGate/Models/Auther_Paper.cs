using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchGate.Models
{
    public class Auther_Paper
    {
        public int AutherId { get; set; }
        public Auther Movie { get; set; }

        public int PaperId { get; set; }
        public Paper Paper { get; set; }
    }
}
