using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.JournalEntries
{
  public class IndexModel : PageModel
  {
    private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

    public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
    {
      _context = context;
    }

    public IList<JournalEntry> JournalEntry { get; set; }

    [BindProperty(SupportsGet = true)]
    public string BookSearchString { get; set; }
    [BindProperty(SupportsGet = true)]
    public string KeywordSearchString { get; set; }
    [BindProperty(SupportsGet = true)]
    public string OrderBy { get; set; }

    public async Task OnGetAsync()
    {
      IQueryable<string> bookQuery = from j in _context.JournalEntry orderby j.Book select j.Book;
      var journalEntries = from j in _context.JournalEntry select j;
      if(!string.IsNullOrEmpty(BookSearchString)){
        journalEntries = journalEntries.Where(s => s.Book.ToUpper().Contains(BookSearchString.ToUpper()));
      }
      if(!string.IsNullOrEmpty(KeywordSearchString)){
        journalEntries = journalEntries.Where(s => s.Note.ToUpper().Contains(KeywordSearchString.ToUpper()));
      }
      if(OrderBy == "book"){
        journalEntries = journalEntries.OrderBy(s => s.Book);
      } else {
        journalEntries = journalEntries.OrderBy(s => s.DateAdded);
      }

      JournalEntry = await journalEntries.ToListAsync();
    }
  }
}
