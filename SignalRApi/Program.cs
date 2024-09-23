
using Microsoft.AspNetCore.Cors.Infrastructure;
using SignalRApi.Hubs;
using SignalRApi.Mapping;
using SignalRBusinessLayer.Abstract;
using SignalRBusinessLayer.Concrete;
using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.EntityFramework;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


#region Dependency Injection: Baðýmlýlýk Enjeksiyonu



//Cors Politikasý
builder.Services.AddCors(opt =>
{
   opt.AddPolicy("CorsPolicy", builder =>
   {
      builder.AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed((host) => true).AllowCredentials();
   });
});

builder.Services.AddSignalR();




builder.Services.AddDbContext<SignalRContext>();//Contex eklendi
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());//Categrydeki gibi yapýcý metod duzeni çin bu kod eklendi.

builder.Services.AddScoped<IAboutService,AboutManager>();
builder.Services.AddScoped<IAboutDal, EFAboutDal>();

builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDal,EFBookingDal>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal,EFCategoryDal>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal,EFContactDal>();

builder.Services.AddScoped<IDiscountService, DiscountManager>();
builder.Services.AddScoped<IDiscountDal,EFDiscountDal>();

builder.Services.AddScoped<IFeatureService,FeatureManager>();
builder.Services.AddScoped<IFeatureDal,EFFeatureDal>();

builder.Services.AddScoped<IProductService, ProductManagert>();
builder.Services.AddScoped<IProductDal,EFProductDal>();

builder.Services.AddScoped<ISocialMediaService,SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDal,EFSocialMediaDal>();

builder.Services.AddScoped<ITestimonialService,TestimonialManager>();
builder.Services.AddScoped<ITestimonialDal,EFTestimonialDal>();

builder.Services.AddScoped<IOrderServices, OrderManager>();
builder.Services.AddScoped<IOrderDal, EFOrderDal>();

builder.Services.AddScoped<IOrderDetailServices, OrderDetailManager>();
builder.Services.AddScoped<IOrderDetailDal, EFOrderDetailDal>();


builder.Services.AddScoped<IToDoListService, ToDoListManager>();
builder.Services.AddScoped<ITodoListDal, EFTodolistDal>();

builder.Services.AddScoped<IBrunchServices, BrunchManager>();
builder.Services.AddScoped<IBrunchDal, EFBrunchDal>();

builder.Services.AddScoped<ILauncheServices, LauncheManager>();
builder.Services.AddScoped<ILauncheDal, EFLauncheDal>();

builder.Services.AddScoped<IDinnerServices, DinnerManager>();
builder.Services.AddScoped<IDinnerDal, EFDinnerDal>();


#endregion





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
   app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.MapHub<SignalRHub>("/signalrhub");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
