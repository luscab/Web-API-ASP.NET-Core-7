using Microsoft.EntityFrameworkCore;

namespace WebAPI.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Model.Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=postgres;" +
                "User Id=postgres;" +
                "Password=lucas1234;");
        }
    }
}
