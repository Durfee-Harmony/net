using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Data
{
  public class MeetingContext : DbContext
  {
    public MeetingContext(DbContextOptions<MeetingContext> options) : base(options)
    {
    }

    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<MusicalNumber> MusicalNumbers { get; set; }
    public DbSet<Speaker> Speakers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Meeting>().ToTable("Meeting");
      modelBuilder.Entity<MusicalNumber>().ToTable("MusicalNumber");
      modelBuilder.Entity<Speaker>().ToTable("Speaker");
    }
  }
}
