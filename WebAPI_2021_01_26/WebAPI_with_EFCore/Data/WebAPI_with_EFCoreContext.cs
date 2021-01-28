using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI_with_EFCore.Models;

namespace WebAPI_with_EFCore.Data
{
    public class WebAPI_with_EFCoreContext : DbContext
    {
        public WebAPI_with_EFCoreContext (DbContextOptions<WebAPI_with_EFCoreContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Als Alternative zu DataAnnotationen kann man mit FluentAPI das selbe abbilden. 

            //modelBuilder.Entity<Blog>()
            //    .Property(b => b.Url)
            //    .IsRequired();
            

            //Fluent Pattern -> 
            // Interface IConfiguration 
            // IConfiguration IchConfig
        }


        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor> Actor { get; set; }
    }
}
