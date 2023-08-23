using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BakeryStock.Data;
using BakeryStock.Models;

namespace BakeryStock.Pages.Registros
{
    public class CreateModel : PageModel
    {
        private readonly BakeryStock.Data.BakeryStockContext _context;

        public CreateModel(BakeryStock.Data.BakeryStockContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Registro Registro { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Registros == null || Registro == null)
            {
                return Page();
            }

            _context.Registros.Add(Registro);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
