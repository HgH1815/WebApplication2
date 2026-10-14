using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Friend
    {
        public string Name { get; set; }
        [Key]
        public int Number { get; set; }
        public string ImageUrl { get; set; }

    }
}
