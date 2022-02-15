using H01.NullMovies.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01.NullMovies.Core
{
    public static class MovieRepository
    {
        //static method
        public static IEnumerable<Movie> GetMovies()
        {
            return new List<Movie> { 
                new Movie {Id=null, Title = "Indiana Jones 1"
                ,Director = null, Sequel = new Movie {Title="Indy 2" } },
                null,
                new Movie {Id=13, Title = "Avengers 1"}
            };
        }
    }
}
