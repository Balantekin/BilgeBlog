using BilgeBlog.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BilgeBlog.Models.ORM.Context
{
    public class BlogContext:DbContext
    {
        public BlogContext()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-DKPOAUGK\\SQLEXPRESS;Database=BilgeBlog;UID=sa;PWD=12345";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<SiteMenu> SiteMenus { get; set; }



    }
}