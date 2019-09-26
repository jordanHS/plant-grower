using System;
using System.Collections.Generic;
using PlantGrower.Models;

namespace PlantGrower
{
  public class Program
  {
    public static void Main()
    {
      var rand = new Random();
      int input;
      int randomNum;
      Console.WriteLine("Welcome to the Plant Grower!");
      Console.WriteLine("What would you like to name your plant?");
      string plantName = Console.ReadLine();
      Plant myPlant = new Plant(5, plantName);

      while(myPlant.PlantHealth > 0)
      {
        randomNum = rand.Next(1, 7);
        Console.WriteLine("-------------------------------");
        Console.WriteLine("{0}'s health is {1}", myPlant.PlantName, myPlant.PlantHealth);
        Console.WriteLine("What action would you like to take?");
        Console.WriteLine("1: Water {0}", myPlant.PlantName);
        Console.WriteLine("2: Feed {0}", myPlant.PlantName);
        Console.WriteLine("3: Give Sunshine to {0}", myPlant.PlantName);
        Console.WriteLine("4: Do nothing.");
        Console.WriteLine("5: Exit program");
        input = int.Parse(Console.ReadLine());
        TakeAction(myPlant, input);
        BadStuff(myPlant, randomNum);
      }
      Console.WriteLine("Thanks for visiting the Plant Grower!");
    }
    public static void BadStuff(Plant plant, int chance)
    {
      switch(chance)
      {
        case 1:
          plant.Windstorm();
          Console.WriteLine("-------------------------------");
          Console.WriteLine("A windstorm occured, {0} lost 1 health. Leaving them at {1} health.", plant.PlantName, plant.PlantHealth);
          break;
        case 2:
          plant.AphidAttack();
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Aphids attacked, {0} lost 3 health. Leaving them at {1} health.", plant.PlantName, plant.PlantHealth);
          break;
        case 3:
          plant.SlugBite();
          Console.WriteLine("-------------------------------");
          Console.WriteLine("A slug bit {0}, they lost 2 health. Leaving them at {1} health.", plant.PlantName, plant.PlantHealth);
          break;
        default:
          break;
      }
    }
    public static void TakeAction(Plant plant, int input)
    {
      switch(input)
      {
        case 1:
          plant.Water();
          break;
        case 2:
          plant.Feed();
          break;
        case 3:
          plant.GiveSunshine();
          break;
        case 4:
          break;
        case 5:
          plant.PlantHealth = 0;
          break;
        default:
          Console.WriteLine("Please enter a valid input.");
          break;
      }
    }
  }
}
