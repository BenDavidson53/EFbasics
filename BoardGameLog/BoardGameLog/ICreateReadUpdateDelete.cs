using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameLog
{
  public interface ICreateReadUpdateDelete
  {
    string Create();
    string Read();
    string Update();
    string Delete();
  }
}
