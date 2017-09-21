using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using LearnDotNet.Model;

namespace LearnDotNet.Dal
{

    public class LearnDbContext : DbContext
    {
        public DbSet<Spending> Spending { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=HOYU-DELL\SQLEXPRESS;Initial Catalog=LearnDotNet;Integrated Security=True;");
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LearnDotNet;Integrated Security=True;");
        }
    }

}