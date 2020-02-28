using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk.Data;
using MegaDesk.Models;

namespace MegaDesk.Pages.DeskQuotes
{
   public class CreateModel : PageModel
   {
      private readonly MegaDesk.Data.MegaDeskContext _context;

      int Width { get; set; }
      int Depth { get; set; }
      int NumberOfDrawers { get; set; }
      int DesktopMaterialID { get; set; }


      public CreateModel(MegaDesk.Data.MegaDeskContext context)
      {
         _context = context;
      }

      public IActionResult OnGet()
      {
         return Page();
      }

      [BindProperty]
      public DeskQuote DeskQuote { get; set; }

      // To protect from overposting attacks, please enable the specific properties you want to bind to, for
      // more details see https://aka.ms/RazorPagesCRUD.
      public async Task<IActionResult> OnPostAsync()
      {

         if (!ModelState.IsValid)
         {
            return Page();
         }

         this.Width = Width;
         this.Depth = Depth;
         this.NumberOfDrawers = NumberOfDrawers;
         this.DesktopMaterialID = DesktopMaterialID;



         // DO LOGIC
         Desk desk = new Desk(Width, Depth, NumberOfDrawers, DesktopMaterialID);
         _context.Desk.Add(desk);
         DeskQuote deskQuote = new DeskQuote();
         _context.DeskQuote.Add(deskQuote);



         // FINISH LOGIC

         await _context.SaveChangesAsync();

         return RedirectToPage("./Index");
      }
   }
}
