using System;

class Program 
{
  static void Main()
  {
    //display title
    Console.WriteLine("************************************");
    Console.WriteLine("* The Stars Shine in Greenville. *");
    Console.WriteLine("************************************");

    //display menu
    Console.WriteLine("\nPlease Enter the following number below from the following menu: \n");
    Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
    Console.WriteLine("2. Exit");

    //User choice
    string choicmenu = Console.ReadLine();

    //switch case for different user choices
    switch (choicmenu)
    {
    case "1":
      //input for last years contestants
      Console.WriteLine("\nPlease enter the number of contestants in the previous year: ");
      int lastYearContestants = Convert.ToInt32(Console.ReadLine());

      //input for current years contestants
      Console.WriteLine("\nPlease enter the number of contestants in the current year: ");
      int currentYearContestants = Convert.ToInt32(Console.ReadLine());

      //calcuate revenue for current year
      int currentYearRevenue = currentYearContestants * 25;

      //output results
      Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {currentYearContestants} contestants");
      Console.WriteLine($"\nRevenue expected this year is ${currentYearRevenue}");

      //check if competition if bigger than last year
      if (currentYearContestants > 2 * lastYearContestants)
      {
        Console.WriteLine("The competition is more than twice as big this year!");
      }
      else if (currentYearContestants > lastYearContestants)
      {
        Console.WriteLine("The competition is bigger than ever!");
      }
      else
      {
        Console.WriteLine("A tighter race this year! Come out and cast your vote!");
      }
      break;

    case "2":
      Console.WriteLine("\nThank you for using the Greenville Revenue App, good-bye!");
      break;






    }



  }
}

