using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Data
{
  public class MeetingContext : DbContext
  {
    public MeetingContext(DbContextOptions<MeetingContext> options) : base(options)
    {
    }

    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<Music> MusicalNumbers { get; set; }
    public DbSet<Musician> Musicians { get; set; }
    public DbSet<Speaker> Speakers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Meeting>().ToTable("Meeting");
      modelBuilder.Entity<Music>().ToTable("MusicalNumber");
      modelBuilder.Entity<Musician>().ToTable("Musician");
      modelBuilder.Entity<Speaker>().ToTable("Speaker");
    }
  }
}
