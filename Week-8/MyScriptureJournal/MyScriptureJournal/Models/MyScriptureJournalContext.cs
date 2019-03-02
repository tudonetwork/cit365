using Microsoft.EntityFrameworkCore;

namespace MyScriptureJournal.Models
{
    public class MyScriptureJournalContext : DbContext
    {
        public MyScriptureJournalContext(DbContextOptions<MyScriptureJournalContext> options)
            : base(options)
        {
        }

        public DbSet<MyScriptureJournal.Models.Journal> Journal { get; set; }
    }
}