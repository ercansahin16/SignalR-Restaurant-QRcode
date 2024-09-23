using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalREntityLayer.Entities
{
   public class Category//Kategoriler
   {
      public int CategoryID { get; set; }
      public string? CategoryName { get; set; }
      public bool CategoryStatus { get; set; }
        public List<Product> products{ get; set; }
    }
}
