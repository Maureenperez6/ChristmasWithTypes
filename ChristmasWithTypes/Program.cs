using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();
    
            var xmasDay = Christmas.Day.Thursday;
        

            //TODO set Santa's name to Kris Kringle
            xmas.Santa = null;
            string santasName = "Kris Kringle";

            //TODO Insert 3 presents you would like for xmas.  They must be strings
            {
                xmas.Presents = new string[3];
                  
            string presentOne =  "Iphone 13";
            string presentTwo = "New Laptop";
            string presentThree = "Earrings";

       
            
            }

            //TODO Set the TreeHeight to 10
    
            int treeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay}");
            Console.WriteLine($"\nOur tree will be {10} feet high");
            Console.WriteLine("\nHere are the presents we would like: \nIphone 13 \nNew Laptop \nEarrings");
            Console.WriteLine($"\n We like to call Santa, {santasName}");
        }
    }
}
