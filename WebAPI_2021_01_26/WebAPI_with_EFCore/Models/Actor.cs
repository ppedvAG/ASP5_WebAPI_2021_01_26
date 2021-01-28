using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_with_EFCore.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public GenderType Gender { get; set; }

        //Data Annotations
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public virtual ICollection<Movie> Movies { get; set; } = new HashSet<Movie>();
    }
    public enum GenderType
    {
        Male,
        Female,
        Other
    }
}
