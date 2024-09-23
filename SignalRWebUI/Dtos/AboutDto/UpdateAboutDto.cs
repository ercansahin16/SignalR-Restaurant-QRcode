﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.AboutDto
{
   public class UpdateAboutDto
   {
      public int AboutID { get; set; }
      public string? ImageURL { get; set; }
      public string? Title { get; set; }
      public string? Description { get; set; }
   }
}
