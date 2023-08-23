using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BakeryStock.Data;
using BakeryStock.Models;

namespace BakeryStock.Pages.Produtos
{
    public class DetailsModel : PageModel
    {
        private readonly BakeryStock.Data.BakeryStockContext _context;

        public DetailsModel(BakeryStock.Data.BakeryStockContext context)
        {
            _context = context;
        }

      public Produto Produto { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            else 
            {
                Produto = produto;
            }
            return Page();
        }
    }
}
