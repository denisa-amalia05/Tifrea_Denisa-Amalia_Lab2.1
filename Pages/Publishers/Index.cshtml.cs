using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tifrea_Denisa_Amalia_Lab2._1.Data;
using Tifrea_Denisa_Amalia_Lab2._1.Models;

namespace Tifrea_Denisa_Amalia_Lab2._1.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Tifrea_Denisa_Amalia_Lab2._1.Data.Tifrea_Denisa_Amalia_Lab2_1Context _context;

        public IndexModel(Tifrea_Denisa_Amalia_Lab2._1.Data.Tifrea_Denisa_Amalia_Lab2_1Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
            Book = await_context.Book.Include(b => b.Publisher).ToListAsync();     
        }
    }
}
