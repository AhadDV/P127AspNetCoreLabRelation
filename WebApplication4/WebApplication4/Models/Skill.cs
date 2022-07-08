using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Percent { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
