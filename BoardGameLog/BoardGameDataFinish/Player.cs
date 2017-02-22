﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameDataFinish
{
  public class Player
  {
    public int PlayerId { get; set; }
    public string Description { get; set; }
    public bool IsCool { get; set; }
  }
}
