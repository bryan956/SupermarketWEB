using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Compras
{
    public class DeleteModel : PageModel
    {
        public readonly SupermarketContext _context;

        public DeleteModel(SupermarketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Compra Compra { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Compras == null)
            {
                return NotFound();
            }

            var compra = await _context.Compras.FirstOrDefaultAsync(m => m.Id == id);

            if (compra == null)
            {
                return NotFound();
            }
            else
            {
                Compra = compra;
            }
            return Page();
        }



        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Compras == null)
            {
                return NotFound();
            }
            var compra = await _context.Compras.FindAsync(id);

            if (compra != null)
            {
                Compra = compra;
                _context.Compras.Remove(compra);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}
