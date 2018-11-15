using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
namespace ent.Models
{
    public class EntContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public EntContext(DbContextOptions<EntContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Atendee> Atendees { get; set; }
        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is TimeStampedModel && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((TimeStampedModel)entity.Entity).CreatedAt = DateTime.Now;
                }
                ((TimeStampedModel)entity.Entity).UpdatedAt = DateTime.Now;
            }
            return base.SaveChanges();
        }
    }
}