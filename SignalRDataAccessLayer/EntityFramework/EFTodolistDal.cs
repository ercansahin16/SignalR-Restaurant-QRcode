using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repository;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.EntityFramework
{
	public class EFTodolistDal : GenericRepository<ToDoList>, ITodoListDal
	{
		public EFTodolistDal(SignalRContext context) : base(context)
		{
		}

      public int ToDoMinute()
      {
        
            using var context = new SignalRContext();

            DateTime nowDate = DateTime.Now;

            // En son eklenen kaydın tarihini alıyoruz
            DateTime sqlDate = context.toDoLists.OrderByDescending(x => x.Date).FirstOrDefault().Date;

            // Zaman farkını hesaplıyoruz
            TimeSpan secondDifference = nowDate - sqlDate;
            int realSeconds = (int)secondDifference.TotalSeconds;

            return realSeconds;
         
      }
   }
}
