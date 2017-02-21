using BoardGameDataFinish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameLog
{
  public class PlayerHandler : GameComponent
  {
    private PlayerRepository _repo;
    public PlayerHandler()
    {
      _repo = new PlayerRepository();
    }

    public override void DisplaySubMenu()
    {
      Console.WriteLine("Welcome to the Players menu.");
      Console.WriteLine("Press any of the following keys to proceed:");
      Console.WriteLine("\t'c' to add a new player");
      Console.WriteLine("\t'r' to see a list of all players");
      Console.WriteLine("\t'u' to edit a player");
      Console.WriteLine("\t'd' to delete a player");
    }

    protected override void Create()
    {
      Console.Write("Enter the name of the player you would like to add: ");
      var playerName = Console.ReadLine();

      var newPlayer = new Player { Description = playerName };
      _repo.AddPlayer(newPlayer);

      Console.WriteLine();
      Console.WriteLine(playerName + " has been added to the pool of players!");
    }

    protected override void Delete()
    {
      Console.Write("Enter the player id of the player you would like to delete: ");
      var playerId = GetNumberFromUser();

      var playerToKill = _repo.GetPlayerById(playerId);

      if (playerToKill != null)
      {
        _repo.RemovePlayer(playerToKill);
        Console.WriteLine();
        Console.WriteLine("Player id " + playerId + " has been deleted!");
      } 
      else
      {
        Console.WriteLine();
        Console.WriteLine("Player id " + playerId + " not found.");
      }     
    }

    protected override void Read()
    {
      Console.WriteLine("These are the players in the pool of players: ");

      var allPlayers = _repo.GetAllPlayers();
      foreach (var player in allPlayers)
      {
        Console.WriteLine("Player ID " + player.PlayerId + " is " + player.Description);
      }
    }

    protected override void Update()
    {
      Console.Write("Enter the player id of the player you would like to update:");
      var playerId = GetNumberFromUser();

      var playerToUpdate = _repo.GetPlayerById(playerId);

      if (playerToUpdate != null)
      {
        Console.WriteLine();
        Console.Write("Enter a new name for player id " + playerId + ": ");
        var playerName = Console.ReadLine();

        _repo.UpdatePlayerDescription(playerToUpdate, playerName);

        Console.WriteLine();
        Console.WriteLine("Player id " + playerId + " has been updated!");
      }      
    }
  }
}
