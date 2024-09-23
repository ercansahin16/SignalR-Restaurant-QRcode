﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDtoLayer.BrunchDto
{
   public class GetBrunchtDto
   {
      public int BrunchID { get; set; }
      public string? Title { get; set; }
      public string? Price { get; set; }
      public string? Description { get; set; }
      public string? ImageUrl { get; set; }
   }
}
