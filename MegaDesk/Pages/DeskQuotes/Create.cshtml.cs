using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk.Data;
using MegaDesk.Models;
using Microsoft.EntityFrameworkCore;

namespace MegaDesk.Pages.DeskQuotes
{
   public class CreateModel : PageModel
   {
      private readonly MegaDesk.Data.MegaDeskContext _context;

      public int BASE_PRICE = 200;
      public decimal FinalPrice;

      public List<int> Days;


      public CreateModel(MegaDesk.Data.MegaDeskContext context)
      {
         _context = context;
      }

      // public IActionResult OnGet()
      // {
      //    var list = new List<SelectListItem>
      // {
      //    new SelectListItem{ Text="14 days (standard)", Value = "14", Selected = true },
      //    new SelectListItem{ Text="7 days (rush)", Value = "7" },
      //    new SelectListItem{ Text="5 days (rush)", Value = "5" },
      //    new SelectListItem{ Text="3 days (rush)", Value = "3" }
      // };

      //    ViewData["daysToCompleteList"] = list;
      //    return Page();
      // }


      [BindProperty]
      public DeskQuote DeskQuote { get; set; }

      [BindProperty(SupportsGet = true)]
      public Desk Desk { get; set; }

      [BindProperty(SupportsGet = true)]
      public SelectList DaysToComplete { get; set; }

      [BindProperty(SupportsGet = true)]
      public DesktopMaterial DesktopMaterial { get; set; }



      public async Task OnGetAsync()
      {
         IQueryable<string> daysQuery = from m in _context.DaysToComplete
                                        orderby m.ID
                                        select m.Description;

         DaysToComplete = new SelectList(await daysQuery.Distinct().ToListAsync());

      }






      // To protect from overposting attacks, please enable the specific properties you want to bind to, for
      // more details see https://aka.ms/RazorPagesCRUD.
      public async Task<IActionResult> OnPostAsync()
      {


         // if (!ModelState.IsValid)
         // {
         //    return Page();
         // }

         Days = (List<int>)ViewData["daysToCompleteList"];

         decimal deskPrice = (decimal)this.BASE_PRICE;
         decimal surfaceArea = Desk.Width * Desk.Depth;
         int[] PRICES = { 60, 70, 80, 40, 50, 60, 30, 35, 40 };

         // Begin Calculations
         deskPrice += Desk.NumberOfDrawers * 50M;

         if (surfaceArea > 1000M)
         {
            deskPrice += surfaceArea - 1000M;
         }

         if (DesktopMaterial.MaterialName == "Oak")
         {
            deskPrice += 200M;
         }
         else if (DesktopMaterial.MaterialName == "Laminate")
         {
            deskPrice += 100M;
         }
         else if (DesktopMaterial.MaterialName == "Pine")
         {
            deskPrice += 50M;
         }
         else if (DesktopMaterial.MaterialName == "Rosewood")
         {
            deskPrice += 300M;
         }
         else if (DesktopMaterial.MaterialName == "Veneer")
         {
            deskPrice += 125M;
         }

         if (DaysToComplete.SelectedValue.Equals(3))
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
         else if (DaysToComplete.SelectedValue.Equals(5))
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
         else if (DaysToComplete.SelectedValue.Equals(7))
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
         DeskQuote.FinalPrice = deskPrice;


         // DO LOGIC
         _context.Desk.Add(Desk);
         _context.DeskQuote.Add(DeskQuote);


         // FINISH LOGIC

         await _context.SaveChangesAsync();

         return RedirectToPage("./Index");
      }
   }
}
