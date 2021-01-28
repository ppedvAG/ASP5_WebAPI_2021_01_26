using System.ComponentModel.DataAnnotations;

namespace HttpReplSampleService.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
