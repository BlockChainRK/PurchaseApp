using PurchaseApp.Data;
using Microsoft.EntityFrameworkCore;

namespace PurchaseApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public DbSet<Value> Values {get; set;}
    }
}