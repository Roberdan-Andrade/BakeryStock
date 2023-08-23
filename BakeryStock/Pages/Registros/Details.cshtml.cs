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
    public class DetailsModel : PageModel
    {
        private readonly BakeryStock.Data.BakeryStockContext _context;

        public DetailsModel(BakeryStock.Data.BakeryStockContext context)
        {
            _context = context;
        }

      public Registro Registro { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Registros == null)
            {
                return NotFound();
            }

            var registro = await _context.Registros.FirstOrDefaultAsync(m => m.Id == id);
            if (registro == null)
            {
                return NotFound();
            }
            else 
            {
                Registro = registro;
            }
            return Page();
        }
    }
}
