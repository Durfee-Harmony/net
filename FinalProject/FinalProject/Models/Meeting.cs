using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
  public class Meeting
  {
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int MeetingID { get; set; }
    public string Theme { get; set; }
    public DateTime MeetingDate { get; set; }

    public ICollection<Speaker> Speakers { get; set; }
    public ICollection<MusicalNumber> MusicalNumbers { get; set; }
  }
}
