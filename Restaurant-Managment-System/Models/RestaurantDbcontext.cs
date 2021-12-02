using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace Restaurant_Managment_System.Models
{
    public class RestaurantDbcontext : DbContext
    {
        public RestaurantDbcontext(DbContextOptions<RestaurantDbcontext> options): base (options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deal_Detail> Deal_Details { get; set; }
        public DbSet<Deal_Master> Deal_Masters { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Discount_Type> Discount_Types { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Food_Category> Food_Categories  { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet <Measurement_Unit> Measurement_Units { get; set; }
        public DbSet<Opening_Hours> Opening_Hours { get; set; }
        public DbSet<Order_Deal_Details> Order_Deal_Details { get; set; }
        public DbSet <Order_food_Detail> Order_Food_Details { get; set; }
        public DbSet<Order_Master> Order_Masters { get; set; }
        public  DbSet<Order_Table> Order_Tables { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Payment_Type> Payment_Types { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Restaurant_Details> Restaurant_Details { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Table> Tables { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deal_Detail>()
             .HasKey(c => new { c.Deal_Id, c.Food_Id });

            modelBuilder.Entity<Order_Deal_Details>()
            .HasKey(c => new { c.Order_No, c.Deal_Id });

            modelBuilder.Entity<Order_food_Detail>()
           .HasKey(c => new { c.Order_No, c.Food_Id});

            modelBuilder.Entity<Order_Table>()
           .HasKey(c => new { c.Order_No, c.Table_No });

            modelBuilder.Entity<Rating>()
          .HasKey(c => new { c.Order_No, c.Food_Id });

        }


    }


}
