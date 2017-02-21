using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameLog
{
  public abstract class GameComponent : IHandleInput
  {
    public void Handle(string command)
    {      
      switch (command)
      {
        case "c":
          Create();
          break;
        case "r":
          Read();
          break;
        case "u":
          Update();
          break;
        case "d":
          Delete();
          break;
      }

      Console.WriteLine("Press any key to continue");
      Console.ReadKey();
    }

    public abstract void DisplaySubMenu();
    protected abstract void Create();
    protected abstract void Read();
    protected abstract void Update();
    protected abstract void Delete();

    protected int GetNumberFromUser()
    {
      var isNumber = false;
      var theNumber = 0;

      while (!isNumber)
      {
        var input = Console.ReadLine();        
        isNumber = int.TryParse(input, out theNumber);

        if (!isNumber)
        {
          Console.WriteLine(input + " is not a number! Try again.");
        }
      }

      return theNumber;
    }
  }
}
