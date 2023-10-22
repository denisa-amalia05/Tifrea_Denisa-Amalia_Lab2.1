﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tifrea_Denisa_Amalia_Lab2._1.Data;
using Tifrea_Denisa_Amalia_Lab2._1.Models;

namespace Tifrea_Denisa_Amalia_Lab2._1.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Tifrea_Denisa_Amalia_Lab2._1.Data.Tifrea_Denisa_Amalia_Lab2_1Context _context;

        public DetailsModel(Tifrea_Denisa_Amalia_Lab2._1.Data.Tifrea_Denisa_Amalia_Lab2_1Context context)
        {
            _context = context;
        }

      public Book Book { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
