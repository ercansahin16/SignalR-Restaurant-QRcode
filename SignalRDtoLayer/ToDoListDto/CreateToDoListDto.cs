using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDtoLayer.ToDoListDto
{
   public class CreateToDoListDto
   {
		public int ID { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }

		public DateTime Date { get; set; }
	}
}
