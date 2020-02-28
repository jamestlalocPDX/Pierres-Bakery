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
      }

    }
  }
}