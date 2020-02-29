using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDesk.Models
{
   public class DaysToComplete
   {
       public int ID { get; set; }
       public string Description { get; set; }
       public int Days { get; set; }
   }
}