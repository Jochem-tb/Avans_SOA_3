using System.Diagnostics;
using Microsoft.VisualBasic;
using CasusBioscoop.Domain.Entities;
using System.Runtime.CompilerServices;

namespace CasusBioscoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Casus Bioscoop Starting...");

            Console.WriteLine("Creating Movies...");
            var movies = initializeMovies();

            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine("Creating Tickets...");
            var tickets = initializeMoviesTickets(movies);

            foreach (var ticket in tickets)
            {
                Console.WriteLine(ticket);
            }

            Console.WriteLine("Creating Order...");
            var order = new Order(1, false);
            order.AddSeatReservation(tickets[0]);
            order.AddSeatReservation(tickets[1]);

            Console.WriteLine($"Total price order: {order.CalculatePrice():C2}");

            var order1 = new Order(1, false);
            order1.AddSeatReservation(tickets[2]);
            order1.AddSeatReservation(tickets[3]);

            Console.WriteLine($"Total price order1: {order1.CalculatePrice():C2}");
        }

        static List<Movie> initializeMovies() {
            var movies = new List<Movie>
            {
                new Movie("Inception"),
                new Movie("The Matrix"),
                new Movie("Interstellar"),
            };

            new MovieScreening(movies[0], DateTime.Parse("2026-01-01 18:00"), 10.0);
            new MovieScreening(movies[0], DateTime.Parse("2026-01-02 20:00"), 12.0);

            new MovieScreening(movies[1], DateTime.Parse("2026-01-03 11:00"), 15.0);
            new MovieScreening(movies[1], DateTime.Parse("2026-01-04 13:00"), 11.0);

            new MovieScreening(movies[2], DateTime.Parse("2026-01-05 22:00"), 12.0);
            new MovieScreening(movies[2], DateTime.Parse("2026-01-06 13:00"), 14.0);

            return movies;
        }

        static List<MovieTicket> initializeMoviesTickets(List<Movie> movies) {
            var tickets = new List<MovieTicket>
            {
                new MovieTicket(movies[0].getScreenings()[0], true, 1, 0),
                new MovieTicket(movies[0].getScreenings()[1], false, 2, 0),
                
                new MovieTicket(movies[1].getScreenings()[1], false, 5, 2),
                
                new MovieTicket(movies[2].getScreenings()[0], false, 2, 10),
            };

            return tickets;
        }
    }
}
