using System.ComponentModel.DataAnnotations;

namespace HttpReplSampleService.Models
{
    public class Fruit
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
