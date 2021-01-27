using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieDBService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDBService.Data
{
    public class DataGenerator
    {
        public static void Init(IServiceProvider serviceProvider)
        {
            using (MovieDBContext context = new MovieDBContext(serviceProvider.GetRequiredService<DbContextOptions<MovieDBContext>>()))
            {
                context.Movies.Add(new Movie { Title = "Once Upon a Time Hollywood", Price=12.99m });
                context.Movies.Add(new Movie { Title = "Marsianer", Price = 9.99m });
                context.Movies.Add(new Movie { Title = "Django Unchained", Price = 15.99m });
                context.Movies.Add(new Movie { Title = "Le Mans 66", Price = 13.99m });
                context.Movies.Add(new Movie { Title = "The Revenant – Der Rückkehrer", Price = 14.99m });
                context.SaveChanges();
            } 
        }
    }
}
