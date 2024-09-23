using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalREntityLayer.Entities
{
   public class Brunch
    {
      public int BrunchID { get; set; }
      public string? Title { get; set; }
      public Decimal Price { get; set; }
      public string? Description { get; set; }
      public string? ImageUrl { get; set; }
   }
}
