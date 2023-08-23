using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BakeryStock.Data;
using BakeryStock.Models;

namespace BakeryStock.Pages.Registros
{
    public class IndexModel : PageModel
    {
        private readonly BakeryStock.Data.BakeryStockContext _context;

        public IndexModel(BakeryStock.Data.BakeryStockContext context)
        {
            _context = context;
        }

        public IList<Registro> Registro { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Registros != null)
            {
                Registro = await _context.Registros.ToListAsync();
            }
        }
    }
}
