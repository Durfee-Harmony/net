using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentMeeting.Data;
using System;
using System.Linq;

namespace SacramentMeeting.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentMeetingContext>>()))
            {
                // Look for any meetings.
                if (context.Meeting.Any())
                {
                    return;   // DB has been seeded
                }

                context.Meeting.AddRange(
                    new Meeting
                    {
                        Date = DateTime.Parse("2018-2-12"),
                        Conductor = "Bishop Priday",
                        OpeningHymn = "2 The Spirit of God",
                        SacramentHymn = "169 As Now We Take The Sacrament",
                        ClosingHymn = "135 My Redeemer Lives",
                        MusicalNumber = "Mary's Lullaby",
                        OpeningPrayer = "Sister Johnson",
                        ClosingPrayer = "Brother Smith"
                    },

                    new Meeting
                    {
                        Date = DateTime.Parse("2018-2-19"),
                        Conductor = "Brother Smith",
                        OpeningHymn = "27 Praise to the Man",
                        SacramentHymn = "172 In Humility, Our Savior",
                        ClosingHymn = "3 Now Let Us Rejoice",
                        MusicalNumber = "If You Could Hie To Kolob",
                        OpeningPrayer = "Sister Lawson",
                        ClosingPrayer = "Brother Jameson"
                    },

                    new Meeting
                    {
                        Date = DateTime.Parse("2018-3-1"),
                        Conductor = "Brother Lawson",
                        OpeningHymn = "5 High on the Mountain Top",
                        SacramentHymn = "180 Father in Heaven, We Do Believe",
                        ClosingHymn = "30 Come, Come Ye Saints",
                        MusicalNumber = "A Poor Wayfaring Stranger",
                        OpeningPrayer = "Brother Johnson",
                        ClosingPrayer = "Sister Priday"
                    },

                    new Meeting
                    {
                        Date = DateTime.Parse("2018-3-8"),
                        Conductor = "Bishop Priday",
                        OpeningHymn = "52 The Day Dawn is Breaking",
                        SacramentHymn = "I Stand All Amazed",
                        ClosingHymn = "6 Redeemer of Israel",
                        MusicalNumber = "Master, the Tempest is Raging",
                        OpeningPrayer = "Sister Jameson",
                        ClosingPrayer = "Brother Lawson"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}