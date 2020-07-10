using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
  public class SpeakingAssignment
  {
    public int ID { get; set; }
    public int MeetingID { get; set; }
    public int SpeakerID { get; set; }
    public string Subject { get; set; }

    // navigation properties
    public Meeting Meeting { get; set; }
    public Speaker Speaker { get; set; }
  }
}