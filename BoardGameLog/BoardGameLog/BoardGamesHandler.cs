using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameLog
{
  public class BoardGamesHandler : GameComponent
  {
    public override void DisplaySubMenu()
    {
      Console.WriteLine("Welcome to the Board Game menu.");
      Console.WriteLine("Press any of the following keys to proceed:");
      Console.WriteLine("\t'c' to add a new board game");
      Console.WriteLine("\t'r' to see a list of board games");
      Console.WriteLine("\t'u' to edit a board game");
      Console.WriteLine("\t'd' to delete a board game");
    }

    protected override void Create()
    {
      Console.Write("Enter the name of the boardgame you would like to add: ");
      var gameName = Console.ReadLine();
      // call to add to the db
      Console.WriteLine(gameName + " has been added to the library!");
      Console.WriteLine();
    }

    protected override void Delete()
    {
      Console.Write("Enter the game id of the game you would like to delete: ");
      var gameId = GetNumberFromUser();
      // call to delete from the db
      Console.WriteLine();
      Console.WriteLine("Game id " + gameId + " has been deleted!");
    }

    protected override void Read()
    {
      Console.WriteLine("These are the games in your library: ");

      /*      
      var result = call to get all games from the db
      foreach(var r in result)
      {
        Console.WriteLine(r);
      }
      */
    }

    protected override void Update()
    {
      Console.Write("Enter the game id of the game you would like to update: ");
      var gameId = GetNumberFromUser();
      // call to get a single game by id
      Console.WriteLine();
      Console.Write("Enter a new name for the game id "+ gameId + ": ");
      var newName = Console.ReadLine();
      // call to update a game by id
      Console.WriteLine();
      Console.WriteLine("Game id " + gameId + " has been updated!");
    }
  }
}
