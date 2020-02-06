using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_HarmonyDurfee
{
  public enum DesktopMaterial
  {
    Oak = 1,
    Laminate = 2,
    Pine = 3,
    Rosewood = 4,
    Veneer = 5
  };
  public enum Delivery
  {
    Rush3Days = 3,
    Rush5Days = 5,
    Rush7Days = 7,
    Normal14Days = 14
  }
  public class Desk
  {
    public int Width { get; set; }
    public int Depth { get; set; }
    public int NumberOfDrawers { get; set; }
    public DesktopMaterial DesktopMaterial { get; set; }
  }
}
