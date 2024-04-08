using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OCoast.Data.DBEntities;
using OCost.Data.DBEntities;
using Ointernalata.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCoast.Data
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder Builder)
        {
            //GUID
            string Admin_Role_Id = "6472ca7d-4acb-4550-9b9f-2d03321ad5e6";
            string Admin_User_Id = "f1446937-109c-4e1a-97ce-0560442484f5";

            //Add Roles
            Builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = Admin_Role_Id,
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
                ConcurrencyStamp = Admin_Role_Id
            });

            //create object of Application USer
            var adminUser = new ApplicationUser
            {
                Id = Admin_User_Id,
                FullName = "Mahmoud Sameer",
                Email = "mahmoud@admin.com",
                NormalizedEmail = "MAHMOUD@ADMIN.COM",
                UserName = "Mahmoud_Sameer",
                UserType = Enums.UserType.Administrator,
                Gender = Enums.Gender.male,
            };

            //Password Hasher
            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "123456");
            Builder.Entity<ApplicationUser>().HasData(adminUser);

            //Add Role To AdminUser
            Builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = Admin_Role_Id,
                    UserId = Admin_User_Id
                }
                );
            base.OnModelCreating(Builder);

        }

        //Entities Dbset
        public DbSet<SystemAdministrator> SystemAdministrators { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<RequestLine> RequestLines { get; set; }
        public DbSet<RequestSupplier> RequestSuppliers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}
