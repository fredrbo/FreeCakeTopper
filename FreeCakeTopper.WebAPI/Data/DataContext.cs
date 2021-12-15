using System.Collections.Generic;
using FreeCakeTopper.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FreeCakeTopper.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TopperName> TopperNames { get; set; }
        public DbSet<UserTopper> UserToppers { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserTopper>()
            .HasKey(UT => new {UT.UserId, UT.TopperId});

            builder.Entity<User>()
            .HasData(new List<User>(){
               new User(1,"José","jose@gmail.com","123"),
               new User(2,"Fred","fred@gmail.com","fred13"),
               new User(3,"Bia","bia@gmail.com","suco13"),
        });

            builder.Entity<TopperName>()
            .HasData(new List<TopperName>(){
                new TopperName(1,"João","Arial","Blue",1),
                new TopperName(2,"Leo","Bonita","Orange",1),
                new TopperName(3,"João","Helvetica","Red",2),
                new TopperName(4,"Bale","Helvetica","Blue",2),
                new TopperName(5,"Tarc","Arial","Black",3),
                new TopperName(6,"Jaspin","Bonita","Gray",3),
            });

            builder.Entity<UserTopper>()
            .HasData(new List<UserTopper>(){
                new UserTopper() {UserId = 1, TopperId = 1},
                new UserTopper() {UserId = 1, TopperId = 2},
                new UserTopper() {UserId = 2, TopperId = 3},
                new UserTopper() {UserId = 2, TopperId = 4},
                new UserTopper() {UserId = 3, TopperId = 5},
                new UserTopper() {UserId = 3, TopperId = 6},
            });
        }
}
}