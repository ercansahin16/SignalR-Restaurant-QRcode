using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalREntityLayer.Entities;

namespace SignalREntityLayer.Entities
{
   public class Launch
   {
      public int LaunchID { get; set; }
      public string? Title { get; set; }
      public Decimal Price { get; set; }
      public string? Description { get; set; }
      public string? ImageUrl { get; set; }
   }
}
