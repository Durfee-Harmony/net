using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Data;
using MegaDesk.Models;

namespace MegaDesk.Pages_CompletionDays
{
    public class DeleteModel : PageModel
    {
        private readonly MegaDesk.Data.MegaDeskContext _context;

        public DeleteModel(MegaDesk.Data.MegaDeskContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DaysToComplete DaysToComplete { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DaysToComplete = await _context.DaysToComplete.FirstOrDefaultAsync(m => m.ID == id);

            if (DaysToComplete == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DaysToComplete = await _context.DaysToComplete.FindAsync(id);

            if (DaysToComplete != null)
            {
                _context.DaysToComplete.Remove(DaysToComplete);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
