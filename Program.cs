using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Bread hearty = new Bread (5, 0, 0);
      Pastry tasty = new Pastry (2, 0, 0);

      Console.WriteLine("Hello, world! Welcome to Pierre's Bakery! Are you interested in buying some of our hearty loaves of bread, or any of our tasty pastries today? (Yes/No)");
      string userResponse = Console.ReadLine().ToLower();

      if (userResponse == "no")
      {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Thank you for stopping by Pierre's Bakery!");
        Console.WriteLine("We hope to see you back soon. Have a nice Day!");
      }
      else
      {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Wonderful! Here are today's specials:");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Bread: Buy 1 for $5, or buy 2 hearty loaves, and you get 1 for free!");
        Console.WriteLine("Pastry: Buy 1 tasty pastry for $2, or 3 for $5!");
        Console.WriteLine("-------------------------------------");
        
        Console.WriteLine("How many loaves of hearty bread would you like?");
        int customerBreadAmount = int.Parse(Console.ReadLine());
        hearty.Amount = customerBreadAmount;

        Console.WriteLine("How many tasty pastries would you like?");
        int customerPastryAmount = int.Parse(Console.ReadLine());
        tasty.Amount = customerPastryAmount;

        tasty.pastryBag();
        hearty.breadBag();

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Your order is ready! You have received:");
        Console.WriteLine(hearty.Amount + " hearty loaves for $" + hearty.Total);
        Console.WriteLine(tasty.Amount + " tasty pastries for $" + tasty.Total);
        Console.WriteLine("Your order total is: $" + (tasty.Total + hearty.Total));
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Your business is greatly appreciated here at Pierre's Bakery!");
        Console.WriteLine("Thank you, and have a nice day!");
      }
    }
  }
}