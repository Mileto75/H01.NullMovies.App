using H01.NullMovies.Core;
using H01.NullMovies.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace H01.NullMovies.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get the movies
            var movies = MovieRepository.GetMovies();
            //print the movies

            Console.WriteLine("Our movies!");
            PrintMovies(movies);
        }
        private static string BuildMovieLine(Movie movie)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Id: {movie?.Id ?? 0}");
            stringBuilder.AppendLine($"Title: {movie?.Title ?? "<NoTitle>"}");
            stringBuilder.AppendLine($"Director: {movie?.Director ?? "<NoTitle>"}");
            stringBuilder.AppendLine($"Sequel: {movie?.Sequel?.Title ?? "<NoSequelTitle>"}");
            return stringBuilder.ToString();
        }
        private static void PrintMovies(IEnumerable<Movie> movies)
        {
            foreach(var movie in movies)
            {
                Console.WriteLine(BuildMovieLine(movie));
            }
        }
    }
}
