using Microsoft.EntityFrameworkCore;
using Proje.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class ProjeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=DESKTOP-8DJ1JG0\\MICROSOFTSQL;Database=aspnetcoreexampleDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new WorkMap());

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Work> Works{ get; set; }

    }
}
