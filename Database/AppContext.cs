using Microsoft.EntityFrameworkCore;

public class AppContext : LÜCKE1
{
    public DbSet<Schueler> Schueler { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=LÜCKE2");
}