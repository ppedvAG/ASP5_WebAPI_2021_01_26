using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_with_EFCore.Models
{

    // EF Core 5.0! Neues Featur -> N:M Abbildungen 
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public GenreTyp Genre { get; set; }

        public decimal Price { get; set; }


        //N:Fache Angabe
        public ICollection<Actor> Actors { get; set; } = new HashSet<Actor>();
    }



    public enum GenreTyp { Adventure, Comedy, Thriller, Fantasy, Horror, Action, Documentation, Western }
}
