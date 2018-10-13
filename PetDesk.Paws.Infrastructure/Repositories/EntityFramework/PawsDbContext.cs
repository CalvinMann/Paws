using Microsoft.EntityFrameworkCore;
using PetDesk.Paws.Infrastructure.Repositories.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Infrastructure.Repositories.EntityFramework
{

    public class PawsDbContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }

        public PawsDbContext(DbContextOptions<PawsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed the database with data here
          

            base.OnModelCreating(modelBuilder);
        }
    }
}
