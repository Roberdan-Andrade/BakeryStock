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
    public class IndexModel : PageModel
    {
        private readonly BakeryStock.Data.BakeryStockContext _context;

        public IndexModel(BakeryStock.Data.BakeryStockContext context)
        {
            _context = context;
        }

        public IList<ProdutoTabela> ProdutoTabela { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ProdutoTabelas != null)
            {
                ProdutoTabela = await _context.ProdutoTabelas.ToListAsync();
            }
        }
    }
}
