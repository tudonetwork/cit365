using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyScriptureJournal.Pages.Journals
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Journal> Journal { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList BooksList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string JournalBook { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FilterBy { get; set; }

        public async Task OnGetAsync()
        {
            Journal = await _context.Journal.ToListAsync();

            // Use LINQ to get list of genres.
            IQueryable<string> bookQuery = from m in _context.Journal
                                            orderby m.Book
                                            select m.Book;

            var journals = from m in _context.Journal select m;

            if (FilterBy == "date") {
                journals = journals.OrderBy(m => m.InsertDate);
            }
            else {
                journals = journals.OrderBy(m => m.Book);
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                journals = journals.Where(s => s.Scripture.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(JournalBook))
            {
                journals = journals.Where(x => x.Book == JournalBook);
            }

            BooksList = new SelectList(await bookQuery.Distinct().ToListAsync());
            Journal = await journals.ToListAsync();


        }
    }
}
