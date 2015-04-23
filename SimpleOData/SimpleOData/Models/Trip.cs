using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SimpleOData.Models
{
    public class Trip
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
