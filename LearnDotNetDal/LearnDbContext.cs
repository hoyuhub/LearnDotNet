using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using LearnDotNet.Model;

namespace LearnDotNet.Dal
{

    public class LearnDotNetDbContext<T> : DbContext where T : class, new()
    {
        public DbSet<T> Spending { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=HOYU-DELL\SQLEXPRESS;Initial Catalog=LearnDotNet;Integrated Security=True;");
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LearnDotNet;Integrated Security=True;");
        }
    }

}