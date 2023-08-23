using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BakeryStock.Data;
using BakeryStock.Models;

namespace BakeryStock.Pages.Registros
{
    public class EditModel : PageModel
    {
        private readonly BakeryStock.Data.BakeryStockContext _context;

        public EditModel(BakeryStock.Data.BakeryStockContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Registro Registro { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Registros == null)
            {
                return NotFound();
            }

            var registro =  await _context.Registros.FirstOrDefaultAsync(m => m.Id == id);
            if (registro == null)
            {
                return NotFound();
            }
            Registro = registro;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Registro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistroExists(Registro.Id))
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

        private bool RegistroExists(int id)
        {
          return (_context.Registros?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
