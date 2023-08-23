using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BakeryStock.Data;
using BakeryStock.Models;

namespace BakeryStock.Pages.Tabelas
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
        public ProdutoTabela ProdutoTabela { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.ProdutoTabelas == null || ProdutoTabela == null)
            {
                return Page();
            }

            _context.ProdutoTabelas.Add(ProdutoTabela);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
