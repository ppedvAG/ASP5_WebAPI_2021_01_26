using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_with_EFCore.Models;

namespace WebAPI_with_EFCore.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebAPI_with_EFCoreContext(serviceProvider.GetRequiredService<DbContextOptions<WebAPI_with_EFCoreContext>>()))
            {
                IList<Movie> movieList = new List<Movie>();

                movieList.Add(new Movie { Title = "Marsianer", Genre = GenreTyp.Adventure, Price = 10.44m });
                movieList.Add(new Movie { Title = "Once Upon a Time", Genre = GenreTyp.Comedy, Price = 12.00m });
                movieList.Add(new Movie { Title = "Texas Chainsaw Massacer", Genre = GenreTyp.Horror, Price = 10.44m });
                movieList.Add(new Movie { Title = "Le Mans 66", Genre = GenreTyp.Documentation, Price = 10.44m });
                movieList.Add(new Movie { Title = "Departed – Unter Feinden", Genre = GenreTyp.Comedy, Price = 10.44m });
                movieList.Add(new Movie { Title = "The Revenant – Der Rückkehrer", Genre = GenreTyp.Comedy, Price = 10.44m });
                movieList.Add(new Movie { Title = "Django Unchained", Genre = GenreTyp.Documentation, Price = 10.44m });

                if (!context.Actor.Any())
                {
                    context.Actor.Add(new Actor
                    {
                        Gender = GenderType.Male,
                        FirstName = "Matt",
                        LastName = "Damon",
                        Movies = new List<Movie> { movieList[0], movieList[3], movieList[4] }
                    });

                    context.Actor.Add(new Actor
                    {
                        Gender = GenderType.Male,
                        FirstName = "Leonardo",
                        LastName = "Di Caprio",
                        Movies = new List<Movie> { movieList[1], movieList[4], movieList[5], movieList[6] }
                    });

                    context.Actor.Add(new Actor
                    {
                        Gender = GenderType.Female,
                        FirstName = "Jessica",
                        LastName = "Biehl",
                        Movies = new List<Movie> { movieList[2] }
                    });
                }

                context.SaveChanges();
            }
        }
    }
}
