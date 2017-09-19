using Microsoft.EntityFrameworkCore;
using Learn.LearnDbContext;
using System.Collections.Generic;
using System;

namespace Learn.LearnDbContext
{
    
    public class LearnDbContext : DbContext
    {
        public DbSet<Spending> Spending{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HOYU-DELL\SQLEXPRESS;Initial Catalog=LearnDotNet;Integrated Security=True;");
        }
    }

    public class Spending
    {
        public int id { get; set; }
        public string reason { get; set; }
        public DateTime date { get; set; }
        public decimal amount { get; set; }
        public DateTime sys_date { get; set; }
    }

}