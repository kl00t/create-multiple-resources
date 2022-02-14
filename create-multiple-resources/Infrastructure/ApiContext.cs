using create_multiple_resources.Models;
using Microsoft.EntityFrameworkCore;

namespace create_multiple_resources.Infrastructure
{
    public class ApiContext : DbContext
    {
        public DbSet<BookModel> BookModels { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookModel>(entity =>
                entity.Property(p => p.Isbn).IsRequired()
            );
        }
    }
}