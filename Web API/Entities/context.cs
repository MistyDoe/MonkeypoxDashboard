
public class CaseDatabase : DbContext
{
    public CaseDb() : base("CaseDatabase")
    {
        Database.SetInitializer(new DropCreateDatabaseAlways<CodeFirstContext>());
    }
    public DbSet<Case> Cases { get; set; }

}