using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameLog
{
  public interface IHandleInput
  {
    void Handle(string command);
  }
}
