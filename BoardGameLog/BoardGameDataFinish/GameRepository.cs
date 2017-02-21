using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameDataFinish
{
  public class GameRepository
  {
    public GameContext _context;

    public GameRepository()
    {
      _context = new GameContext();
    }

    public void AddGame(Game g)
    {
      _context.GameSet.Add(g);
      _context.SaveChanges();
    }
  }
}
