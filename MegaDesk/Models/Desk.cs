using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
  public enum DesktopMaterial
  {
    Oak = 1,
    Laminate = 2,
    Pine = 3,
    Rosewood = 4,
    Veneer = 5
  }
  public class Desk
  {
    public int Width { get; set; }
    public int Depth { get; set; }
    public int NumberOfDrawers { get; set; }
    public DesktopMaterial DesktopMaterial { get; set; }

  }
}
