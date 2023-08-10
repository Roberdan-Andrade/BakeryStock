using Microsoft.EntityFrameworkCore;

namespace BakeryStock.Data
{
    public class BakeryStockContext : DbContext
    {
        public BakeryStockContext(DbContextOptions <BakeryStockContext> options) : base(options) { }
    }
}
