using HT_13_07.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_13_07.Data
{
    public class HT_13_DB : DbContext
    {
        private readonly string connectionString = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=devnur; Database=HT_13_DB;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Person> Persons { get; set; }

    }
}
