using DotNetHtmxTypescriptTemplate.Movies;
using Microsoft.EntityFrameworkCore;

namespace DotNetHtmxTypescriptTemplate.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<MovieModel> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./Data/App.db");
        }
    }
}
