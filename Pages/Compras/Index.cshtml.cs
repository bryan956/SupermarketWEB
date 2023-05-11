using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Compras
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<Compra> Compras { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Compras != null)
            {
                Compras = await _context.Compras.ToListAsync();
            }
        }
    }
}
