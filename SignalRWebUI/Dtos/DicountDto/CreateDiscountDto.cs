using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.DicountDto
{
   public class CreateDiscountDto
   {
      public string? Title { get; set; }
      public string? Amount { get; set; }//İndirim oranı
      public string? Description { get; set; }
      public string? ImageUrl { get; set; }
   }
}
