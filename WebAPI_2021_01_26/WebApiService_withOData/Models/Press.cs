using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService_withOData.Models
{
    // Press
    public class Press
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Category Category { get; set; }
    }

    // Category
    public enum Category
    {
        Book,
        Magazine,
        EBook
    }
}
