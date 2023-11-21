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
            [Required(ErrorMessage = "El campo Correo electrónico es obligatorio.")]
            [EmailAddress(ErrorMessage = "Por favor, introduce una dirección de correo electrónico válida.")]
            [Display(Name = "Correo electrónico")]
            public string Email { get; set; }

            [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
            [StringLength(100, ErrorMessage = "La {0} debe tener al menos {2} y como máximo {1} caracteres.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Contraseña")]
            public string Password { get; set; }

            [Required(ErrorMessage = "El campo Confirmar Contraseña es obligatorio.")]
            [DataType(DataType.Password)]
            [Display(Name = "Confirmar Contraseña")]
            [Compare("Password", ErrorMessage = "La contraseña y la confirmación de contraseña no coinciden.")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet()
        {
            // Método ejecutado cuando se carga la página (GET).
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Lógica de registro aquí
                return RedirectToPage("/Account/Loginn");
            }

            // Si llegamos aquí, hay errores de validación
            return Page();
        }
    }
}
