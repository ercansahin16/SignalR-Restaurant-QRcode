using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDtoLayer.LauncheDto
{
   public class CreateLauncheDto
   {
      public int LaunchID { get; set; }
      public string? Title { get; set; }
      public string? Price { get; set; }
      public string? Description { get; set; }
      public string? ImageUrl { get; set; }
   }
}
