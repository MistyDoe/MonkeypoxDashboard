using DashBoardAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DashBoardAPI.DAL
{
    public class CaseContext : DbContext
    {
        public DbSet<Case> Cases { get; set; }

        protected override void OnConfiguring (
            DbContextOptionsBuilder optionsBuilder) => optionsBuilder
            .LogTo(Console.WriteLine)
            .UseSqlite("Data Source=cases.db");


    }

}

