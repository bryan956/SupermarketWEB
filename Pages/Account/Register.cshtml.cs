using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.ModelsUser;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;


namespace SupermarketWEB.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public User User { get; set; }
        public InputModel Input { get; set; }

        public class InputModel : User
        {
            [Required(ErrorMessage = "El campo Correo electr�nico es obligatorio.")]
            [EmailAddress(ErrorMessage = "Por favor, introduce una direcci�n de correo electr�nico v�lida.")]
            [Display(Name = "Correo electr�nico")]
            public string Email { get; set; }

            [Required(ErrorMessage = "El campo Contrase�a es obligatorio.")]
            [StringLength(100, ErrorMessage = "La {0} debe tener al menos {2} y como m�ximo {1} caracteres.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Contrase�a")]
            public string Password { get; set; }

            [Required(ErrorMessage = "El campo Confirmar Contrase�a es obligatorio.")]
            [DataType(DataType.Password)]
            [Display(Name = "Confirmar Contrase�a")]
            [Compare("Password", ErrorMessage = "La contrase�a y la confirmaci�n de contrase�a no coinciden.")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet()
        {
            // M�todo ejecutado cuando se carga la p�gina (GET).
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // L�gica de registro aqu�
                return RedirectToPage("/Account/Loginn");
            }

            // Si llegamos aqu�, hay errores de validaci�n
            return Page();
        }
    }
}
