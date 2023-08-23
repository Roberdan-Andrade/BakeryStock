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

namespace BakeryStock.Pages.Tabelas
{
    public class EditModel : PageModel
    {
        private readonly BakeryStock.Data.BakeryStockContext _context;

        public EditModel(BakeryStock.Data.BakeryStockContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProdutoTabela ProdutoTabela { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ProdutoTabelas == null)
            {
                return NotFound();
            }

            var produtotabela =  await _context.ProdutoTabelas.FirstOrDefaultAsync(m => m.Id == id);
            if (produtotabela == null)
            {
                return NotFound();
            }
            ProdutoTabela = produtotabela;
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

            _context.Attach(ProdutoTabela).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoTabelaExists(ProdutoTabela.Id))
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

        private bool ProdutoTabelaExists(int id)
        {
          return (_context.ProdutoTabelas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
