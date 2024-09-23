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
   public class ProductManagert : IProductService
   {
      private readonly IProductDal _productDal;

      public ProductManagert(IProductDal productDal)
      {
         _productDal = productDal;
      }

      public void TAdd(Product entity)
      {
         _productDal.Add(entity);
      }

      public void TDelete(Product entity)
      {
         _productDal.Delete(entity);
      }

      public Product TGetByID(int id)
      {
       return  _productDal.GetByID(id);
      }

        public void TGetCtg(int id)
        {
            _productDal.GetCtg(id);
        }

        public List<Product> TGetListAll()
      {
       return _productDal.GetListAll();
      }

      public List<Product> TGetProductsWithCategories()
      {
         return _productDal.GetProductsWithCategories();
      }

		public int TProductCount()
		{
			return _productDal.ProductCount();
		}

		public int TProductCountByCategoryNameDrink()
		{
			return _productDal.ProductCountByCategoryNameDrink();
		}

		public int TProductCountByCategoryNameHamburger()
		{
         return _productDal.ProductCountByCategoryNameHamburger();
		}

		public decimal TProductHamburgerAvg()
		{
			return _productDal.ProductHamburgerAvg();
		}

		public string TProductNamePriceMax()
		{
			return _productDal.ProductNamePriceMax();
		}

		public decimal TProductPriceAvg()
		{
			return _productDal.ProductPriceAvg();
		}

		public void TUpdate(Product entity)
      {
         _productDal.Update(entity);   
      }
   }
}
