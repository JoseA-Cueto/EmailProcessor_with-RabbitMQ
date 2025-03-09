using Microsoft.EntityFrameworkCore;

public class EmailMessage
{
    public int Id { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string Status { get; set; } = "Pending";
}

public class DatabaseContext : DbContext
{
    public DbSet<EmailMessage> Emails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=emaildb.db");
    }
}
