using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Abstract
{
    public interface IProductService : IGenericServis<Product>
    {
        List<Product> TGetProductsWithCategories();
        public void TGetCtg(int id);

      int TProductCount();
		int TProductCountByCategoryNameHamburger();
		int TProductCountByCategoryNameDrink();
		decimal TProductPriceAvg();
		string TProductNamePriceMax();
		decimal TProductHamburgerAvg();
	}
}
