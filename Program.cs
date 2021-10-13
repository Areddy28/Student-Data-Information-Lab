using System;
using System.Collections.Generic;

namespace ListsLab
{
    class Program
    {
        
        static void Main(string[] args)
         
        {
            bool goOn = true;
            while (goOn == true)
                
              {
                string input = GetInput("Which student you would like to learn more about? (enter a number between 0-9)");
                int num = int.Parse(input);

                 

                // Make a list of arrays 0-10 for students, hometowns, and favorite foods: 


                string[] students = new string[10];


                students[0] = "Huy Phan";
                students[1] = "Tommy Waalkes";
                students[2] = "Calyn Greene";
                students[3] = "Marjorie Patton";
                students[4] = "Ramone Lynch";
                students[5] = "Cullin Flynn";
                students[6] = "Cordero Ebberhart";
                students[7] = "Rick Magdeleno";
                students[8] = "James Mitchell";
                students[9] = "Richard Moss";

                string[] hometowns = new string[10];

                hometowns[0] = "Lansing, MI";
                hometowns[1] = "Raleigh, NC";
                hometowns[2] = "Portage, MI";
                hometowns[3] = "Detroit, MI";
                hometowns[4] = "Fort Lauderdale, FL";
                hometowns[5] = "Fowlerville, MI";
                hometowns[6] = "Berkley, Michigan";
                hometowns[7] = "Gilbert, AZ";
                hometowns[8] = "Yap, FSM";
                hometowns[9] = "Canton, MI"; 

                string[] favoritefoods = new string[10];

                favoritefoods[0] = "Korean BBQ";
                favoritefoods[1] = "Curry";
                favoritefoods[2] = "Mac and Cheese";
                favoritefoods[3] = "Lasagna";
                favoritefoods[4] = "Chicken Soup";
                favoritefoods[5] = "Pad Thai";
                favoritefoods[6] = "(Any type of) BBQ";
                favoritefoods[7] = "Hamburger";
                favoritefoods[8] = "Katsu";
                favoritefoods[9] = "Sushi";

                // I made the favorite movie array up to add extra piece of information about students. 

                string[] favoritemovies = new string[10];

                favoritemovies[0] = "X-men movies";
                favoritemovies[1] = "Batman Triology";
                favoritemovies[2] = "Harry Potter";
                favoritemovies[3] = "Legally Blonde";
                favoritemovies[4] = "Hunger Games";
                favoritemovies[5] = "Captain America";
                favoritemovies[6] = "Thor series";
                favoritemovies[7] = "Men in Black";
                favoritemovies[8] = "Finding Nemo";
                favoritemovies[9] = "Lord of the Rings"; 


                //Console.WriteLine(students[num]);
                Console.WriteLine( students[num] + " is from " + hometowns[num] + "." + " Favorite food is " + favoritefoods[num] + " and favoirte movie is " + favoritemovies[num] + ".");


                goOn = Continue(); 
                
                





            }
         //Prompt user to ask which student they like to learn more about
         //Make an array for students with hometown and favorite food
         //make a continue y/n?

        }

        public static string GetInput (string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input; 
        }

        public static bool Continue ()
        {
            string answer = GetInput("\nWould you like to learn about another student? y/n");
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye and thanks!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand");
                Console.WriteLine("Let's try again.");

                // This is recursion, calling a method inside itself
                return Continue();
            }
        }

        
    }
}
