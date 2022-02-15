using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H01.NullMovies.Core.Entities
{
    public class Movie
    {
        public long? Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public Movie Sequel { get; set; }
    }
}
