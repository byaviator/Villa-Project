using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.MVC.DAL.Models;

namespace Villa.MVC.DAL.Contexts
{
    public class AppDbContext :DbContext
    {
        private readonly string _connectionString = @"Server=DESKTOP-GTVND9D\SQLEXPRESS;Database=VillaDb;Trusted_Connection=True;TrustServerCertificate=True;";
        public DbSet<VillaModel> VillaModels { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
