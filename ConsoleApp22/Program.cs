using System;

namespace ConsoleApp2
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("Enter the month number: ");
            string season = Console.ReadLine();
            switch (season)
            {
                case "one": Console.WriteLine("Winter!"); break;
                case "two": Console.WriteLine("Winter!"); break;
                case "three": Console.WriteLine("Spring!"); break;
                case "four": Console.WriteLine("Spring!"); break;
                case "five": Console.WriteLine("Spring!"); break;
                case "six": Console.WriteLine("Summer!"); break;
                case "seven": Console.WriteLine("Summer!"); break;
                case "eight": Console.WriteLine("Summer!"); break;
                case "nine": Console.WriteLine("Autumn!"); break;
                case "ten": Console.WriteLine("Autumn!"); break;
                case "eleven": Console.WriteLine("Autumn!"); break;
                case "twelve": Console.WriteLine("Winter!"); break;
            }
            Console.ReadKey();
        }
    }
}

