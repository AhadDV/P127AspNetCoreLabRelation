using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
