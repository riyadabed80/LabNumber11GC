using System;
using System.Collections.Generic;

namespace LabNumber11GC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie> { };
            movieList.Add(new Movie("Goodfellas", "Drama"));
            movieList.Add(new Movie("Casino", "Drama"));
            movieList.Add(new Movie("Star Wars", "SciFi"));
            movieList.Add(new Movie("Wedding Crashers", "Comedy"));
            movieList.Add(new Movie("Fast & Furious", "Action"));
            movieList.Add(new Movie("The Transporter", "Action"));
            movieList.Add(new Movie("Alien", "SciFi"));
            movieList.Add(new Movie("Groundhog Day", "Comedy"));
            movieList.Add(new Movie("Mystic River", "Drama"));
            movieList.Add(new Movie("Rush Hour", "Comedy"));
            movieList.Add(new Movie("Nightmare on Elm Street", "Horror"));
            movieList.Add(new Movie("Monsters, Inc.","Animated"));
            movieList.Add(new Movie("Toy Story","Animated"));
            string[] Categories= { "Drama", "SciFi", "Comedy", "Horror", "Animated" };

            Console.WriteLine("Welcome to the Movie List Application!");
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine($"There are {movieList.Count} movies in this list. What category are you interested in? \n(1)Drama  (2)SciFi  (3)Comedy  (4)Horror  (5)Animated");
                int menuInput = ValidateNum();
                foreach (Movie c in movieList)

                    if (c.Category == Categories[menuInput - 1])
                    {
                        c.PrintInfo();
                    }
                repeat = Continue("Continue? y/n");
            }
            Console.WriteLine("Goodbye!");
        }

        private static int ValidateNum()
        {
            int menuInput;
            while (!int.TryParse(Console.ReadLine(), out menuInput) || menuInput < 1 || menuInput > 5)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            }

            return menuInput;
        }



        static bool Continue(string message)
        {
            while(true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine().ToUpper();
                if(input=="N")
                {

                    return false;

                }
                else if (input=="Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }
    }
}
