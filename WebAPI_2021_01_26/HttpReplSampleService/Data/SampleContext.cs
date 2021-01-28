using Microsoft.EntityFrameworkCore;
using HttpReplSampleService.Models;

namespace HttpReplSampleService.Data
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options)
            : base(options)
        {
        }

        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
