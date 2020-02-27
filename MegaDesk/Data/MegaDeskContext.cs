using Microsoft.EntityFrameworkCore;

namespace MegaDesk.Data
{
   public class MegaDeskContext : DbContext
   {
      public MegaDeskContext(
          DbContextOptions<MegaDeskContext> options)
          : base(options)
      {
      }

      public DbSet<MegaDesk.Models.Desk> Desk { get; set; }
      public DbSet<MegaDesk.Models.DeskQuote> DeskQuote { get; set; }
      public DbSet<MegaDesk.Models.DesktopMaterial> DesktopMaterial { get; set; }
   }
}