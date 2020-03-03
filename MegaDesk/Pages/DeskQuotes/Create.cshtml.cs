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


      public CreateModel(MegaDesk.Data.MegaDeskContext context)
      {
         _context = context;
      }


      [BindProperty]
      public DeskQuote DeskQuote { get; set; }

      [BindProperty(SupportsGet = true)]
      public Desk Desk { get; set; }



      public SelectList DaysToComplete { get; set; }


      public SelectList DesktopMaterials { get; set; }



      [BindProperty(SupportsGet = true)]
      public string selectedMaterial { get; set; }

      [BindProperty(SupportsGet = true)]
      public string selectedDays { get; set; }



      public async Task OnGetAsync()
      {
         IQueryable<DaysToComplete> daysQuery = from m in _context.DaysToComplete
                                                orderby m.ID
                                                select m;

         IQueryable<DesktopMaterial> materialsQuery = from m in _context.DesktopMaterial
                                                      orderby m.ID
                                                      select m;

         DaysToComplete = new SelectList(await daysQuery.Distinct().ToListAsync(), "ID", "Description");
         DesktopMaterials = new SelectList(await materialsQuery.Distinct().ToListAsync(), "ID", "MaterialName");

      }






      // To protect from overposting attacks, please enable the specific properties you want to bind to, for
      // more details see https://aka.ms/RazorPagesCRUD.
      public async Task<IActionResult> OnPostAsync()
      {


         // if (!ModelState.IsValid)
         // {
         //    return Page();
         // }

         decimal deskPrice = (decimal)this.BASE_PRICE;
         decimal surfaceArea = Desk.Width * Desk.Depth;
         int[] PRICES = { 60, 70, 80, 40, 50, 60, 30, 35, 40 };

         // Begin Calculations
         deskPrice += Desk.NumberOfDrawers * 50M;

         if (surfaceArea > 1000M)
         {
            deskPrice += surfaceArea - 1000M;
         }

         if (selectedMaterial == "Oak")
         {
            deskPrice += 200M;
         }
         else if (selectedMaterial == "Laminate")
         {
            deskPrice += 100M;
         }
         else if (selectedMaterial == "Pine")
         {
            deskPrice += 50M;
         }
         else if (selectedMaterial == "Rosewood")
         {
            deskPrice += 300M;
         }
         else if (selectedMaterial == "Veneer")
         {
            deskPrice += 125M;
         }

         if (selectedDays == "3 days (rush)")
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
         else if (selectedDays == "5 days (rush)")
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
         else if (selectedDays == "7 days (rush)")
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


         Desk.DesktopMaterialID = Convert.ToInt16(selectedMaterial);
         DeskQuote.DaysToCompleteID = Convert.ToInt16(selectedDays);

         var returnedEntity = _context.Desk.Add(Desk);
         DeskQuote.DeskID = returnedEntity.Entity.ID;
         DeskQuote.Desk = Desk;
         _context.DeskQuote.Add(DeskQuote);
         await _context.SaveChangesAsync();

         return RedirectToPage("./Index");
      }
   }
}
