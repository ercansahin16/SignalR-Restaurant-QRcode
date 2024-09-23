using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.LauncheDto
{
   public class ResultLauncheDto
   {
      public int LaunchID { get; set; }
      public string? Title { get; set; }
      public string? Price { get; set; }
      public string? Description { get; set; }
      public string? ImageUrl { get; set; }
   }
}
