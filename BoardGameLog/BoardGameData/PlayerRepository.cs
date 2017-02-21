using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameDataFinish
{
  public class PlayerRepository
  {
    public GameContext _context;
    public PlayerRepository()
    {
      _context = new GameContext();
    }

    public Player GetPlayerById(int id)
    {
      return _context.PlayerSet.Find(id);
    }
  }
}
