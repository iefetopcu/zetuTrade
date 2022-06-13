using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zetutrade_Model.Models;

namespace zetutrade_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductText> ProductTexts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryText> categoryTexts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogText> BlogTexts { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
