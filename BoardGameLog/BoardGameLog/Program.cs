using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameLog
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = "";
      var subMenuInput = "";

      while (input != "x")
      {
        DisplayMenu();
        input = Console.ReadLine();

        switch (input)
        {
          case "b":            
            var bgh = new BoardGamesHandler();
            bgh.DisplaySubMenu();
            subMenuInput = Console.ReadLine();
            bgh.Handle(subMenuInput);
            break;
          case "p":
            var ph = new PlayerHandler();
            ph.DisplaySubMenu();
            subMenuInput = Console.ReadLine();
            ph.Handle(subMenuInput);
            break;
          case "g":
            var gph = new GamesPlayedHandler();
            gph.DisplaySubMenu();
            subMenuInput = Console.ReadLine();
            gph.Handle(subMenuInput);
            break;          
        }

        Console.Clear();
      }
    }

    private static void DisplayMenu()
    {
      Console.WriteLine("Welcome to Board Game Log! A place where you can record your board game dominance.");
      Console.WriteLine("Press any of the following keys to proceed:");
      Console.WriteLine("\t'b' for the board games menu");
      Console.WriteLine("\t'p' for the players menu");
      Console.WriteLine("\t'g' for the games played menu");
      Console.WriteLine("\t'x' to exit the program");
    }
  }
}
