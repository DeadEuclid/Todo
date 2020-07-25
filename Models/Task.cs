using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Task
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        public StatusTask Status { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
