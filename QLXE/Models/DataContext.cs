using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using QLXE.Areas.Admin.Models;

namespace QLXE.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<AdminMenu> AdminMenus { get; set; }
        public DbSet<view_Cars_Menu> Cars_Menus { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
