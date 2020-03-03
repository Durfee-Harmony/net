using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Data;
using MegaDesk.Models;

namespace MegaDesk.Pages.DeskQuotes
{
   public class DetailsModel : PageModel
   {
      private readonly MegaDesk.Data.MegaDeskContext _context;

      public DetailsModel(MegaDesk.Data.MegaDeskContext context)
      {
         _context = context;
      }


      public DeskQuote DeskQuote { get; set; }
      public Desk Desk { get; set; }
      public DesktopMaterial DesktopMaterial { get; set; }

      public async Task<IActionResult> OnGetAsync(int? id)
      {
         if (id == null)
         {
            return NotFound();
         }

         DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.ID == id);
         Desk = await _context.Desk.FirstOrDefaultAsync(m => m.ID == DeskQuote.DeskID);
         DesktopMaterial = await _context.DesktopMaterial.FirstOrDefaultAsync(m => m.ID == Desk.DesktopMaterialID);

         if (DeskQuote == null)
         {
            return NotFound();
         }
         return Page();
      }
   }
}
