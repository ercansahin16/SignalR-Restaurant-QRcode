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
   public class EFCategoryDal : GenericRepository<Category>, ICategoryDal
   {
      public EFCategoryDal(SignalRContext context) : base(context)
      {
      }

		public int ActiveCategoryCount()
		{
		using var context=new SignalRContext();
		var values=context.categories.Where(x=>x.CategoryStatus==true).Count();
			return values;
		}

		public int CategoryCount()
		{
			using var context = new SignalRContext();
			return context.categories.Count();
		}

		public int PassiveCategoryCount()
		{
			using var context=new SignalRContext();
			var values=context.categories.Where(x=>x.CategoryStatus==false).Count();
			return values;
		}
	}
}
