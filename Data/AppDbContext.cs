using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Reflection.Emit;
using TaskManager.Entities;

namespace TaskManager.Data
{

        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<User> Users { get; set; }
            public DbSet<Role> Roles { get; set; }
            public DbSet<Entities.Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {


                modelBuilder.Entity<User>()
                 .Property(l => l.CreatedAt)
                 .HasDefaultValueSql("GETDATE()");


            modelBuilder.Entity<Entities.Task>()
                .Property(l => l.CreatedAt)
                .HasDefaultValueSql("GETDATE()");



            base.OnModelCreating(modelBuilder);

            }



        }

}
