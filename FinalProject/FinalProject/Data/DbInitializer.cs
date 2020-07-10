using FinalProject.Models;
using System;
using System.Linq;

namespace FinalProject.Data
{
  public static class DbInitializer
  {
    public static void Initialize(MeetingContext context)
    {
      context.Database.EnsureCreated();

      if (context.Speakers.Any())
      {
        return;
      }

      var speakers = new Speaker[]
      {
            new Speaker{FirstMidName="Henry",LastName="Eyring",TalkTitle="Prayers of Faith"},
            new Speaker{FirstMidName="David",LastName="Bednar",TalkTitle="Let This House Be Built unto My Name"},
            new Speaker{FirstMidName="Dallin",LastName="Oaks",TalkTitle="The Great Plan"},
            new Speaker{FirstMidName="Jeff",LastName="Holland",TalkTitle="A Perfect Brightness of Hope"},
            new Speaker{FirstMidName="Russell",LastName="Nelson",TalkTitle="Opening the Heavens for Help"},
            new Speaker{FirstMidName="Dieter",LastName="Uchtdorf",TalkTitle="Come and Belong"}
      };
      foreach (Speaker s in speakers)
      {
        context.Speakers.Add(s);
      }
      context.SaveChanges();

      var musicalnumbers = new MusicalNumber[]
      {
            new MusicalNumber{GroupName="Tabernacle Choir",Song="Consider the Lilies"},
            new MusicalNumber{GroupName="Provo Stake Choir",Song="I am a Child of God"},
            new MusicalNumber{GroupName="BYUI Men's Chorus",Song="Onward Christian Soldiers"}
      };
      foreach (MusicalNumber c in musicalnumbers)
      {
        context.MusicalNumbers.Add(c);
      }
      context.SaveChanges();

      var meetings = new Meeting[]
      {
            new Meeting{Theme="General Conference", MeetingDate=DateTime.Parse("2020-04-05")},
            new Meeting{Theme="General Conference", MeetingDate=DateTime.Parse("2019-04-05")},
            new Meeting{Theme="General Conference", MeetingDate=DateTime.Parse("2019-04-05")}
      };
      foreach (Meeting e in meetings)
      {
        context.Meetings.Add(e);
      }
      context.SaveChanges();
    }
  }
}