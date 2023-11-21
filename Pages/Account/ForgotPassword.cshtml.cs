using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.ModelsUser;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace SupermarketWEB.Pages.Account
{
    public class ForgotPasswordModel : PageModel
        {
            [BindProperty]
            public InputModel Input { get; set; }

            public class InputModel
            {
                [Required(ErrorMessage = "El campo Correo electrónico es obligatorio.")]
                [EmailAddress(ErrorMessage = "Por favor, introduce una dirección de correo electrónico válida.")]
                [Display(Name = "Correo electrónico")]
                public string Email { get; set; }
            }

            public void OnGet()
            {
                // Método ejecutado cuando se carga la página (GET).
            }

            public IActionResult OnPost()
            {
                // Método ejecutado cuando se envía el formulario (POST).
                if (ModelState.IsValid)
                {
                    // Aquí deberías manejar la lógica para enviar el enlace de restablecimiento de contraseña.
                    // Normalmente, esto implica generar un token, enviar un correo electrónico al usuario, etc.

                    // Después de enviar el enlace, podrías redirigir al usuario a una página de confirmación.
                    // Por ejemplo:
                    return RedirectToPage("/Account/Loginn");
                }

                // Si llegamos a este punto, significa que ha habido errores de validación.
                // Volveremos a mostrar el formulario con los mensajes de error.
                return Page();
            }
        }
    }
