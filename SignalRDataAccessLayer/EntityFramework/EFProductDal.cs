using Microsoft.EntityFrameworkCore;
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
	public class EFProductDal : GenericRepository<Product>, IProductDal
	{
		public EFProductDal(SignalRContext context) : base(context)
		{
		}

		public string GetCtg(int id)
		{
			var context = new SignalRContext();

			var categoryName = context.products
	  .Include(p => p.Category)
	  .Where(p => p.CategoryID == id)
	  .Select(p => p.Category.CategoryName)
	  .FirstOrDefault();
			return categoryName;
		}

		public List<Product> GetProductsWithCategories()
		{
			var context = new SignalRContext();
			var values = context.products.Include(x => x.Category).ToList();
			return values;
		}

		public int ProductCount()
		{
			using var context = new SignalRContext();
			return context.products.Count();
		}

		public int ProductCountByCategoryNameDrink()
		{
			using var context = new SignalRContext();
			var values = context.products.Where(x => x.CategoryID == (context.categories.Where(y => y.CategoryName == "İçecek").Select(z => z.CategoryID).FirstOrDefault())).Count();
			return values;
		}

		public int ProductCountByCategoryNameHamburger()
		{
			using var context = new SignalRContext();
			var values = context.products.Where(x => x.CategoryID == (context.categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
			return values;
		}

		public decimal ProductHamburgerAvg()
		{
			using var context = new SignalRContext();
			var totalSum = context.products
								 .Where(y => y.CategoryID == 1)
								 .Average(z => z.Price);
			return totalSum;
		}

		public string ProductNamePriceMax()
		{
			using var context = new SignalRContext();
			var values = context.products.OrderByDescending(x => x.Price).FirstOrDefault().ProductName;
			return values;
		}

		public decimal ProductPriceAvg()
		{
			using var context = new SignalRContext();
			var values = context.products.Select(x => x.Price).Average();
			return values;
		}
	}
}
