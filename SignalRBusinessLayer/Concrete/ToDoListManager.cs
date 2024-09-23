using SignalRBusinessLayer.Abstract;
using SignalRDataAccessLayer.Abstract;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Concrete
{
	public class ToDoListManager : IToDoListService
	{
	
		private readonly ITodoListDal _todoListDal;

		public ToDoListManager(ITodoListDal todoListDal)
		{
			_todoListDal = todoListDal;
		}

		public void TAdd(ToDoList entity)
		{
			 _todoListDal.Add(entity);
		}

		public void TDelete(ToDoList entity)
		{
			_todoListDal.Delete(entity);
		}

		public ToDoList TGetByID(int id)
		{
			return _todoListDal.GetByID(id);
		}

		public List<ToDoList> TGetListAll()
		{
			return _todoListDal.GetListAll();
		}

      public int TToDoMinute()
      {
       return  _todoListDal.ToDoMinute();
      }

      public void TUpdate(ToDoList entity)
		{
			 _todoListDal.Update(entity);
		}
	}
}
