using BoardGameDataFinish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameLog
{
  public class BoardGamesHandler : GameComponent
  {
    private GameRepository _gameRepo;
    public BoardGamesHandler()
    {
      _gameRepo = new GameRepository();
    }
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
      var newGame = new Game();
      newGame.Description = gameName;
      _gameRepo.Add(newGame);
      Console.WriteLine(gameName + " has been added to the library!");
      Console.WriteLine();
    }

    protected override void Delete()
    {
      Console.Write("Enter the game id of the game you would like to delete: ");
      var gameId = GetNumberFromUser();
      var gameToRemove = _gameRepo.GetGameById(gameId);

      if (gameToRemove != null)
      {
        _gameRepo.DeleteGame(gameToRemove);
        Console.WriteLine();
        Console.WriteLine("Game id " + gameId + " has been deleted!");
      }      
    }

    protected override void Read()
    {
      Console.WriteLine("These are the games in your library: ");

      var result = _gameRepo.GetAllGames();
      foreach(var r in result)
      {
        Console.WriteLine("Game ID: " + r.GameId + " Description: " + r.Description);
      }
    }

    protected override void Update()
    {
      Console.Write("Enter the game id of the game you would like to update: ");
      var gameId = GetNumberFromUser();
      var gameToUpdate = _gameRepo.GetGameById(gameId);

      if (gameToUpdate != null)
      {
        Console.WriteLine();
        Console.Write("Enter a new name for the game id " + gameId + ": ");
        var newName = Console.ReadLine();

        gameToUpdate.Description = newName;
        _gameRepo.SaveChanges();

        Console.WriteLine();
        Console.WriteLine("Game id " + gameId + " has been updated!");
      }
    }
  }
}
