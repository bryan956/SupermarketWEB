using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Compras
{
    public class Create2Model : PageModel
    {
        private readonly SupermarketContext _context;

        public Create2Model(SupermarketContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Compra Compra { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Compras == null || Compra == null)
            {
                return Page();
            }

            _context.Compras.Add(Compra);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
