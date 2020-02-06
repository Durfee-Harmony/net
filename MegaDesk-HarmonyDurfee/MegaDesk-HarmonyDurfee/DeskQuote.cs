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
    public Desk Desk { get; set; }
    public decimal FinalPrice { get; set; }
    public string[] PRICES { get; set; }

    public int baseDesk = 200;

    public string[] getRushOrderPrices()
    {
      var pricesFile = @"rushOrderPrices.txt";
      string[] prices = File.ReadAllLines(pricesFile);
      this.PRICES = prices;
      return prices;
    }

    public decimal CalculateDeskQuote()
    {
      decimal quote = (decimal)this.baseDesk;
      decimal surface = this.Desk.Width * this.Desk.Depth;
      decimal drawers = this.Desk.NumberOfDrawers;
      int material = (int)this.Desk.DesktopMaterial;

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

      if (this.Delivery == 3)
      {
        if (surface < 1000)
        {
          quote += System.Convert.ToDecimal(PRICES[0]);
        } else if (surface <= 2000)
        {
          quote += System.Convert.ToDecimal(PRICES[1]);
        } else
        {
          quote += System.Convert.ToDecimal(PRICES[2]);
        }
      } else if (this.Delivery == 5)
      {
        if (surface < 1000)
        {
          quote += System.Convert.ToDecimal(PRICES[3]);
        }
        else if (surface <= 2000)
        {
          quote += System.Convert.ToDecimal(PRICES[4]);
        }
        else
        {
          quote += System.Convert.ToDecimal(PRICES[5]);
        }
      } else if (this.Delivery == 7)
      {
        if (surface < 1000)
        {
          quote += System.Convert.ToDecimal(PRICES[6]);
        }
        else if (surface <= 2000)
        {
          quote += System.Convert.ToDecimal(PRICES[7]);
        }
        else
        {
          quote += System.Convert.ToDecimal(PRICES[8]);
        }
      }
      this.FinalPrice = quote;
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
