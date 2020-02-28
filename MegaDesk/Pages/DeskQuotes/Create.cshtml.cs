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

      int DeskWidth { get; set; }
      int DeskDepth { get; set; }
      int DeskNumberOfDrawers { get; set; }
      int DeskDesktopMaterialID { get; set; }
      int BASE_PRICE = 200;
      decimal FinalPrice;
      int DaysToComplete;


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

         this.DeskWidth = DeskWidth;
         this.DeskDepth = DeskDepth;
         this.DeskNumberOfDrawers = DeskNumberOfDrawers;
         this.DeskDesktopMaterialID = DeskDesktopMaterialID;




         Desk desk = new Desk(DeskWidth, DeskDepth, DeskNumberOfDrawers, DeskDesktopMaterialID);
         DeskQuote deskQuote = new DeskQuote();


         decimal deskPrice = (decimal)this.BASE_PRICE;
         decimal surfaceArea = desk.Width * desk.Depth;
         decimal numberOfDrawers = desk.NumberOfDrawers;
         DesktopMaterial material = desk.DesktopMaterial;
         int[] PRICES = { 60, 70, 80, 40, 50, 60, 30, 35, 40 };

         deskPrice += numberOfDrawers * 50M;

         if (surfaceArea > 1000M)
         {
            deskPrice += surfaceArea - 1000M;
         }

         if (material.Equals(1))
         {
            deskPrice += 200M;
         }
         else if (material.Equals(2))
         {
            deskPrice += 100M;
         }
         else if (material.Equals(3))
         {
            deskPrice += 50M;
         }
         else if (material.Equals(4))
         {
            deskPrice += 300M;
         }
         else if (material.Equals(5))
         {
            deskPrice += 125M;
         }

         if (DaysToComplete == 3)
         {
            if (surfaceArea < 1000)
            {
               deskPrice += System.Convert.ToDecimal(PRICES[0]);
            }
            else if (surfaceArea <= 2000)
            {
               deskPrice += System.Convert.ToDecimal(PRICES[1]);
            }
            else
            {
               deskPrice += System.Convert.ToDecimal(PRICES[2]);
            }
         }
         else if (DaysToComplete == 5)
         {
            if (surfaceArea < 1000)
            {
               deskPrice += System.Convert.ToDecimal(PRICES[3]);
            }
            else if (surfaceArea <= 2000)
            {
               deskPrice += System.Convert.ToDecimal(PRICES[4]);
            }
            else
            {
               deskPrice += System.Convert.ToDecimal(PRICES[5]);
            }
         }
         else if (DaysToComplete == 7)
         {
            if (surfaceArea < 1000)
            {
               deskPrice += System.Convert.ToDecimal(PRICES[6]);
            }
            else if (surfaceArea <= 2000)
            {
               deskPrice += System.Convert.ToDecimal(PRICES[7]);
            }
            else
            {
               deskPrice += System.Convert.ToDecimal(PRICES[8]);
            }
         }
         deskQuote.FinalPrice = deskPrice;


         // DO LOGIC
         _context.Desk.Add(desk);
         _context.DeskQuote.Add(deskQuote);


         // FINISH LOGIC

         await _context.SaveChangesAsync();

         return RedirectToPage("./Index");
      }
   }
}
