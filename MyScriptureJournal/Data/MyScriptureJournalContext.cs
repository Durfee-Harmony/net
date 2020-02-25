using Microsoft.EntityFrameworkCore;

namespace MyScriptureJournal.Data
{
    public class MyScriptureJournalContext : DbContext{
      public MyScriptureJournalContext (
        DbContextOptions<MyScriptureJournalContext> options)
        : base(options)
      {}
      public DbSet<MyScriptureJournal.Models.JournalEntry> JournalEntry{get; set;}
    }
}