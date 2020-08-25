using Entities.Concrete;
using Entities.DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class CarCreditAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MURAD-PC\SQLEXPRESS;initial catalog=CarCreditAppDb;integrated security=true");
        }

        public DbSet<CarInformation> CarInformations { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Ban> Bans { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Condition> Conditions { get; set; }


    }
}
