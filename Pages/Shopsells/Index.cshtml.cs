using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Shopsells
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }
        public IList<ShopSell> Shopsells { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Shopsells != null)
            {
                Shopsells = await _context.Shopsells.ToListAsync();
            }
        }
    }
}
