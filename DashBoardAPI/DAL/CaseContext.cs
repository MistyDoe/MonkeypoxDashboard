using DashBoardAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DashBoardAPI.DAL
{
    public class CaseContext : DbContext
    {
        public CaseContext (DbContextOptions<CaseContext> options) : base(options) { }
        public DbSet<Case> Cases { get; set; }


    }

}

