using Microsoft.EntityFrameworkCore;
using Person.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.DatabaseContext.DatabaseContext
{
    public class PersonDatabaseContext : DbContext
    {
        public PersonDatabaseContext()
        {

        }
        public PersonDatabaseContext(DbContextOptions<PersonDatabaseContext> options) : base(options)
        {

        }     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-L0SIFSL\SQLEXPRESS;Database=PersonDB;Trusted_Connection=True;");
        }

       public DbSet<Personage> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Personage>()
                .Property(e => e.Name).IsRequired();
            modelBuilder.Entity<Personage>()
                .Property(e => e.PhoneNo).IsRequired();
            modelBuilder.Entity<Personage>()
                .Property(e => e.Email).IsRequired();
            modelBuilder.Entity<Personage>()
                .Property(e => e.Address).IsRequired();
            modelBuilder.Entity<Personage>()
                .Property(e => e.IsActive).IsRequired();
        }

    }
}
