using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.ToDoListDto
{
   public class ResultToDoListDto
   {
		public int ID { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }

		public DateTime Date { get; set; }
	}
}
