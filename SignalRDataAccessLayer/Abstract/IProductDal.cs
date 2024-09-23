using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.Abstract
{
   public interface IProductDal:IGenericDal<Product>
   {
      List<Product> GetProductsWithCategories();
        public string GetCtg(int id);
       int ProductCount();
		int ProductCountByCategoryNameHamburger();
		int ProductCountByCategoryNameDrink();

      decimal ProductPriceAvg();
      string ProductNamePriceMax();

      decimal ProductHamburgerAvg();

        
        
   }
}
