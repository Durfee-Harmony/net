using Microsoft.EntityFrameworkCore;
using SacramentMeeting.Models;

namespace SacramentMeeting.Data
{
    public class SacramentMeetingContext : DbContext
    {
        public SacramentMeetingContext(DbContextOptions<SacramentMeetingContext> options)
            : base(options)
        {
        }

        public DbSet<Meeting> Meeting { get; set; }
    }
}