﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDtoLayer.CategoryDto
{
   public class UpdateCategoryDto
   {
      public int CategoryID { get; set; }
      public string? CategoryName { get; set; }
      public bool CategoryStatus { get; set; }
   }
}
