using Microsoft.AspNetCore.SignalR;
using SignalRBusinessLayer.Abstract;

namespace SignalRApi.Hubs
{
   public class SignalRHub : Hub
   {
      private readonly ICategoryService _categoryService;
      private readonly IProductService _productService;
      private readonly IOrderServices _orderServices;
      private readonly IBookingService _bookingService;
      public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderServices orderServices, IBookingService bookingService)
      {
         _categoryService = categoryService;
         _productService = productService;
         _orderServices = orderServices;
         _bookingService = bookingService;
      }

      public async Task SendStatistik()//Kategori Sayısı
      {
         var value = _categoryService.TCategoryCount();
         await Clients.All.SendAsync("ReceiveCategoryCount", value);

         var value2 = _productService.TProductCount();
         await Clients.All.SendAsync("ReceiveProductCount", value2);

         var value3 = _categoryService.TActiveCategoryCount();
         await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

         var value4 = _categoryService.TPassiveCategoryCount();
         await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);

         var value5 = _productService.TProductCountByCategoryNameHamburger();
         await Clients.All.SendAsync("ReceiveProductCountByCategoryNameHamburger", value5);

         var value6 = _productService.TProductCountByCategoryNameDrink();
         await Clients.All.SendAsync("ReceiveProductCountByCategoryNameDrink", value6);

         var value7 = _productService.TProductPriceAvg();
         await Clients.All.SendAsync("ReceiveProductPriceAvg", value7.ToString("C"));

         var value8 = _productService.TProductNamePriceMax();
         await Clients.All.SendAsync("ReceiveProductNamePriceMax", value8);

         var value9 = _productService.TProductHamburgerAvg();
         await Clients.All.SendAsync("ReceiveProductHamburgerAvg", value9.ToString("C"));

         var value10 = _orderServices.TOrderCountTotal();
         await Clients.All.SendAsync("ReceiveOrderCountTotal", value10);

         var value11 = _orderServices.TActiveTable();
         await Clients.All.SendAsync("ReceiveActiveTable", value11);

         var value12 = _orderServices.TLastOrderPrice();
         await Clients.All.SendAsync("ReceiveLastOrderPrice", value12.ToString("C"));

         var value13 = _orderServices.TSafeByTotalPrice();
         await Clients.All.SendAsync("ReceiveSafeByTotalPrice", value13.ToString("C"));

         var value14 = _orderServices.TTotalPriceToday();
         await Clients.All.SendAsync("ReceiveTotalPriceToday", value14.ToString("C"));

         var value15 = _orderServices.TTableCount();
         await Clients.All.SendAsync("ReceiveTableCount", value15);

         var value16 = _bookingService.TTotalRezervision();
         await Clients.All.SendAsync("ReceiveTotalRezervision", value16);






      }

      public async Task SendProgress()
      {
         var value = _orderServices.TSafeByTotalPrice();
         await Clients.All.SendAsync("ReceiveSafeByTotalPrice", value.ToString("C"));

         var value2 = _orderServices.TTotalPriceToday();
         await Clients.All.SendAsync("ReceiveTotalPriceToday", value2.ToString("C"));

         var value3 = _orderServices.TOrderByTodayCount();
         await Clients.All.SendAsync("ReceiveOrderCountTotal", value3);


      }


   }
}
