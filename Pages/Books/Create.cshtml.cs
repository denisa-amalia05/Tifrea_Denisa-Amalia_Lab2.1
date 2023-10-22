using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tifrea_Denisa_Amalia_Lab2._1.Data;
using Tifrea_Denisa_Amalia_Lab2._1.Models;

namespace Tifrea_Denisa_Amalia_Lab2._1.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Tifrea_Denisa_Amalia_Lab2._1.Data.Tifrea_Denisa_Amalia_Lab2_1Context _context;

        public CreateModel(Tifrea_Denisa_Amalia_Lab2._1.Data.Tifrea_Denisa_Amalia_Lab2_1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Book == null || Book == null)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
