using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCodeFirstWithMigrations;

namespace DataLayer
{
    public class SalesModelContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        //public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ContactDetail>().HasKey(c => c.CustomerId);
            //modelBuilder.Entity<ContactDetail>().Property(c => c.MobilePhone).HasColumnName("CellPhone");
            ////modelBuilder.Entity<ContactDetail>().
            ////  HasRequired(c => c.Customer).WithOptional(cu => cu.ContactDetail);
            //modelBuilder.Entity<Customer>().
            //  HasOptional(cu => cu.ContactDetail).WithRequired(cd => cd.Customer);
            modelBuilder.Configurations.Add(new ContactDetailMappings());
            modelBuilder.Ignore<Category>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
