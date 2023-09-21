using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MohaliAssignment.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "PLease Enter Your Name")]
        public string Key { get; set; }

        [Required]
        public string Value { get; set; }
        [Required]
        public string Value2 { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IsDeleted { get; set; }

    }
}
