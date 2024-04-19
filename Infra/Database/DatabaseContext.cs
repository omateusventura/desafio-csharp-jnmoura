using API.Infra.Map;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Infra.Database
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<PeopleEntity> Peoples { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PeopleMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}