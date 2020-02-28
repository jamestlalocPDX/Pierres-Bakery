using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello, world! Welcome to Pierre's Bakery! Are you interested in buying any of our scrumptious loaves of bread, or any of our fine pastries today? (Yes/No)");
      string userResponse = Console.ReadLine().ToLower();

      if (userResponse == "no")
      {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Thank you for stopping by!");
        Console.WriteLine("See you next time!");
      }
      else{
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Wonderful! Here are today's specials.");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Bread: Buy 2 hearty loaves, and you get 1 for free!");
        Console.WriteLine("Pastry: Buy 1 mouth-watering pastry for $2, or 3 for $5!");
      }

    }
  }
}