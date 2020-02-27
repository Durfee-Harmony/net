using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDesk.Models
{
   public class Desk
   {
      public int ID { get; set; }
      public int Width { get; set; }
      public int Depth { get; set; }
      public int NumberOfDrawers { get; set; }
      public int DesktopMaterialID { get; set; }
   }
}