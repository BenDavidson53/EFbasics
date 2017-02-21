using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameLog
{
  public class GamesPlayedHandler : GameComponent
  {
    public override void DisplaySubMenu()
    {
      Console.WriteLine("Welcome to the Games Played menu.");
      Console.WriteLine("Press any of the following keys to proceed:");
      Console.WriteLine("\t'c' to record a game played");
      Console.WriteLine("\t'r' to see all games played");
      Console.WriteLine("\t'u' to change a recorded game");
      Console.WriteLine("\t'd' to delete a recorded game");
    }

    protected override void Create()
    {
      Console.Write("Enter the game id of the game you played: ");
      var gameId = GetNumberFromUser();
      // call to get the game

      Console.Write("Enter the player id of the player that won: ");
      var playerId = GetNumberFromUser();
      // call to get the player

      // call to create a game played record
      Console.WriteLine();
      Console.WriteLine("It has been recorded that player id " + playerId + " has won a game of game id " + gameId);
    }

    protected override void Delete()
    {
      Console.Write("Enter the game played id of the game played you would like to delete: ");
      var gamePlayedId = GetNumberFromUser();
      // call to delete from the db
      Console.WriteLine();
      Console.WriteLine("Game played id " + gamePlayedId + " has been deleted!");
    }

    protected override void Read()
    {
      Console.WriteLine("This is a list of games played and who won each game: ");

      /*      
      var result = call to get all games played from the db
      foreach(var r in result)
      {
        Console.WriteLine(r);
      }
      */
    }

    protected override void Update()
    {
      Console.Write("Enter the game played id of the game played you would like to update: ");
      var gamePlayedId = GetNumberFromUser();
      // call to get a single game played by id
      Console.WriteLine();
      Console.Write("Enter the id of the player that ACTUALLY won the game: ");
      var playerId = GetNumberFromUser();
      // call to get a player by id
      // call to update the game played
      Console.WriteLine();
      Console.WriteLine("Game played id " + gamePlayedId + " has been updated!");
    }
  }
}
