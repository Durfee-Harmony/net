using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDesk.Models
{
   public class DesktopMaterial
   {
      public int ID { get; set; }
      public string MaterialName { get; set; }
      public decimal MaterialPrice { get; set; }


   }
}