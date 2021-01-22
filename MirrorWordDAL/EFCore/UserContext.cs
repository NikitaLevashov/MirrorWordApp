using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MirrorWordDAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;



namespace MirrorWordDAL.EFCore
{
    public class UserContext : DbContext
    {
        public DbSet<RegisterUser> RegisterUsers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=polindromdb;Trusted_Connection=True");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<RegisterUser>().HasData(
        //    new RegisterUser[]
        //    {
        //        new RegisterUser { Name = "Nikita", Id = 1, Password = "12345" },
        //        new RegisterUser { Name = "Nikita", Id = 2, Password = "123456" },
        //        new RegisterUser { Name = "Nikita", Id = 3, Password = "1234567" },
        //        new RegisterUser { Name = "Nikita", Id = 4, Password = "12345678" },
        //        new RegisterUser { Name = "Nikita", Id = 5, Password = "123456789" },
        //        new RegisterUser { Name = "Nikita", Id = 6, Password = "1234567890" },
        //        new RegisterUser { Name = "Nikita", Id = 7, Password = "12345678911" },
        //        new RegisterUser { Name = "Nikita", Id = 8, Password = "12345678912" },
        //        new RegisterUser { Name = "Nikita", Id = 9, Password = "12345678912" }

        //    });
        //}
    }
}
