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
      [Display(Name = "Number of Drawers")]
      public int NumberOfDrawers { get; set; }
      [Display(Name = "Desktop Material")]
      public int DesktopMaterialID { get; set; }

      /* Navigation Properties */
      public DesktopMaterial DesktopMaterial { get; set; }

   }
}