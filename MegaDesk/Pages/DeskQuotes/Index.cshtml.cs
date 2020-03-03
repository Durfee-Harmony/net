using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Data;
using MegaDesk.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDesk.Pages.DeskQuotes
{
   public class IndexModel : PageModel
   {
      private readonly MegaDesk.Data.MegaDeskContext _context;

      public IndexModel(MegaDesk.Data.MegaDeskContext context)
      {
         _context = context;
      }

      public IList<DeskQuote> DeskQuote { get; set; }

      public string SortCustomer { get; set; }
      public string SortDate { get; set; }

      public string CurrentFilter { get; set; }
      public string CurrentSort { get; set; }
      [BindProperty(SupportsGet = true)]
      public string SearchString { get; set; }
      public SelectList Desk { get; set; }
      [BindProperty(SupportsGet = true)]
      public string SearchDesk { get; set; }

      public DaysToComplete DaysToComplete { get; set; }


      public async Task OnGetAsync(string sortOrder, string searchString)
      {
         SortCustomer = String.IsNullOrEmpty(sortOrder) ? "CustomerName" : "";
         SortDate = sortOrder == "DAdded_Asc_Sort" ? "DAdded_Desc_Sort" : "DAdded_Asc_Sort";

         IQueryable<string> nameListQuery = from d in _context.DeskQuote
                                            orderby d.CustomerName
                                            select d.CustomerName;

         CurrentFilter = searchString;

         IQueryable<DeskQuote> nameQuery = from d in _context.DeskQuote select d;
         IQueryable<DaysToComplete> daysToCompleteQuery = from d in _context.DaysToComplete select d;


         if (!string.IsNullOrEmpty(searchString))
         {
            nameQuery = nameQuery.Where(s => s.CustomerName.Contains(SearchString));
         }

         if (!string.IsNullOrEmpty(SearchDesk))
         {
            nameQuery = nameQuery.Where(x => x.CustomerName == SearchDesk);
         }

         switch (sortOrder)
         {
            case "CustomerName":
               nameQuery = nameQuery.OrderByDescending(s => s.CustomerName);
               break;
            case "DAdded_Asc_Sort":
               nameQuery = nameQuery.OrderBy(s => s.Date);
               break;
            case "DAdded_Desc_Sort":
               nameQuery = nameQuery.OrderByDescending(s => s.Date);
               break;
            default:
               nameQuery = nameQuery.OrderBy(s => s.CustomerName);
               break;
         }

         Desk = new SelectList(await nameListQuery.Distinct().ToListAsync());
         DeskQuote = await nameQuery.AsNoTracking()
               .Include(a => a.DaysToComplete)
               .ToListAsync();

      }
   }
}
