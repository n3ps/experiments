using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SplitDateDemo.Models
{
    public class RegisterViewModel
    {
        public int Id { get; set; }
        
        
        public string Name { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
    }
}