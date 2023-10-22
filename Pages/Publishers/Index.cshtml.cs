using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Demian_Sabina_Lab2.Data;
using Demian_Sabina_Lab2.Models;

namespace Demian_Sabina_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Demian_Sabina_Lab2.Data.Demian_Sabina_Lab2Context _context;

        public IndexModel(Demian_Sabina_Lab2.Data.Demian_Sabina_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
