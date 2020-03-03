using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Data;
using MegaDesk.Models;

namespace MegaDesk.Pages.DeskQuotes
{
    public class EditModel : PageModel
    {
        private readonly MegaDesk.Data.MegaDeskContext _context;

        public EditModel(MegaDesk.Data.MegaDeskContext context)
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

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            IQueryable<DaysToComplete> daysQuery = from m in _context.DaysToComplete
                                                   orderby m.ID
                                                   select m;

            IQueryable<DesktopMaterial> materialsQuery = from m in _context.DesktopMaterial
                                                         orderby m.ID
                                                         select m;

            DaysToComplete = new SelectList(await daysQuery.Distinct().ToListAsync(), "ID", "Description");
            DesktopMaterials = new SelectList(await materialsQuery.Distinct().ToListAsync(), "ID", "MaterialName");

            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.ID == id);

            if (DeskQuote == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DeskQuote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeskQuoteExists(DeskQuote.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DeskQuoteExists(int id)
        {
            return _context.DeskQuote.Any(e => e.ID == id);
        }
    }
}
