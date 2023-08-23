using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BakeryStock.Data;
using BakeryStock.Models;

namespace BakeryStock.Pages.Tabelas
{
    public class DeleteModel : PageModel
    {
        private readonly BakeryStock.Data.BakeryStockContext _context;

        public DeleteModel(BakeryStock.Data.BakeryStockContext context)
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

            var produtotabela = await _context.ProdutoTabelas.FirstOrDefaultAsync(m => m.Id == id);

            if (produtotabela == null)
            {
                return NotFound();
            }
            else 
            {
                ProdutoTabela = produtotabela;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ProdutoTabelas == null)
            {
                return NotFound();
            }
            var produtotabela = await _context.ProdutoTabelas.FindAsync(id);

            if (produtotabela != null)
            {
                ProdutoTabela = produtotabela;
                _context.ProdutoTabelas.Remove(ProdutoTabela);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
