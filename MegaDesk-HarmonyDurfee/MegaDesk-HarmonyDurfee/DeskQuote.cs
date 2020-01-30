using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_HarmonyDurfee
{
  public class DeskQuote
  {
    public string CustomerName { get; set; }
    public int Delivery { get; set; }
    Desk desk;
    public int baseDesk = 200;

    static string[] getRushOrderPrices()
    {
      var pricesFile = @"rushOrderPrices.txt";
      string[] prices = File.ReadAllLines(pricesFile);
      return prices;
    }

    decimal CalculateDeskQuote()
    {
      decimal quote = (decimal)this.baseDesk;
      decimal surface = this.desk.Width * this.desk.Depth;
      decimal drawers = this.desk.NumberOfDrawers;
      DesktopMaterial material = this.desk.DesktopMaterial;

      if(surface > 1000M)
      {
        quote += surface - 1000M;
      }

      quote += drawers * 50M;

      if(material.Equals(1))
      {
        quote += 200M;
      } else if (material.Equals(2))
      {
        quote += 100M;
      } else if (material.Equals(3))
      {
        quote += 50M;
      } else if (material.Equals(4))
      {
        quote += 300M;
      } else if (material.Equals(5))
      {
        quote += 125M;
      }

      return quote;
    }

    /* Notes from class
    private void getRushOrderPrices()
    {
      var pricesFile = @"rushOrderPrices.txt";
      string[] prices = File.ReadAllLines(pricesFile);
    }
    */
  }
}
