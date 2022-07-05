using Microsoft.EntityFrameworkCore;

public class CaseDatabase : DbContext
{
    public DbSet<Case> Cases { get; set; }

    protected override void OnConfi  
}