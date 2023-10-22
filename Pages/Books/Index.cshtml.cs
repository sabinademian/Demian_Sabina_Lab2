using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Demian_Sabina_Lab2.Data;
using Demian_Sabina_Lab2.Models;

namespace Demian_Sabina_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Demian_Sabina_Lab2.Data.Demian_Sabina_Lab2Context _context;

        public IndexModel(Demian_Sabina_Lab2.Data.Demian_Sabina_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .ToListAsync();
            }
        }
    }
}
