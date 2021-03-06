using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ResearchGate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchGate.Data
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auther_Paper>().HasKey(am => new
            {
                am.AutherId,
                am.PaperId
            });

            modelBuilder.Entity<Auther_Paper>().HasOne(m => m.Auther).WithMany(am => am.Authers_Papers).HasForeignKey(m => m.AutherId);
            modelBuilder.Entity<Auther_Paper>().HasOne(m => m.Paper).WithMany(am => am.Authers_Papers).HasForeignKey(m => m.PaperId);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Auther> Authers { get; set; }
        public DbSet<Auther_Paper> Authers_Papers { get; set; }
        public DbSet<Paper> Papers { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }



    }
}
