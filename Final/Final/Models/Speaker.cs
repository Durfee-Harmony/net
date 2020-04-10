using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
  public class Speaker
  {
    public int ID { get; set; }
    public string LastName { get; set; }
    public string FirstMidName { get; set; }
    public DateTime SpeakingDate { get; set; }

    public ICollection<Meeting> Meetings { get; set; }
  }
}
