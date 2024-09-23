using Microsoft.EntityFrameworkCore;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.Concrete
{
   public class SignalRContext : DbContext
   {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer("Server=LENOVA20VE\\SQLEXPRESS;initial Catalog=SignalRDb;integrated Security=true");
      }

      public DbSet<About> abouts { get; set; }
      public DbSet<Booking> bookings { get; set; }
      public DbSet<Category> categories { get; set; }
      public DbSet<Contact> contacts { get; set; }
      public DbSet<Discount> discounts { get; set; }
      public DbSet<Feature> features { get; set; }
      public DbSet<Product> products { get; set; }
      public DbSet<SocialMedia> socialMedias { get; set; }
      public DbSet<Testimonial> testimonials { get; set; }
      public DbSet<Order> orders { get; set; }
      public DbSet<OrderDetail> orderDetails { get; set; }
      public DbSet<ToDoList> toDoLists { get; set; }
      public DbSet<Brunch> brunches { get; set; }
      public DbSet<Launch> launches { get; set; }
      public DbSet<Dinner> dinners { get; set; }
      public DbSet<Basket> baskets { get; set; }


   }
}
