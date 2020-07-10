using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
  public class Music
  {
    public int ID { get; set; }
    public string Song { get; set; }
    public string Composer { get; set; }

    public ICollection<Musician> Musicians { get; set; }
  }
}
