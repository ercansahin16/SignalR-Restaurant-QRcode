﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDtoLayer.TestimonialDto
{
   public class CreateTestimonialDto
	{
      public string? Name { get; set; }
      public string? Tittle { get; set; }
      public string? Comment { get; set; }
      public bool TestimonialStatus { get; set; }
      public string? ImageURL { get; set; }
   }
}
