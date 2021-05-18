using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;




namespace OrderApi.Models
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options):base(options)
        {
            this.Database.EnsureCreated();//自动创建数据库、表
        }
                
        public DbSet<Order> Orders { get; set; }
    }
}