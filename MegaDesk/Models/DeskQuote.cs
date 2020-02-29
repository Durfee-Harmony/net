using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDesk.Models
{
   public class DeskQuote
   {
      public int ID { get; set; }
      [Display(Name = "Customer Name")]
      public string CustomerName { get; set; }
      [Display(Name = "Days to Complete")]
      public int DaysToComplete { get; set; }
      [Display(Name = "Final Price")]
      public decimal FinalPrice { get; set; }
      public int DeskID { get; set; }

      /* Navigation Properties */
      public Desk Desk { get; set; }

      // public Delivery DeliveryType { get; set; }

   }
}