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
                [Required(ErrorMessage = "El campo Correo electr�nico es obligatorio.")]
                [EmailAddress(ErrorMessage = "Por favor, introduce una direcci�n de correo electr�nico v�lida.")]
                [Display(Name = "Correo electr�nico")]
                public string Email { get; set; }
            }

            public void OnGet()
            {
                // M�todo ejecutado cuando se carga la p�gina (GET).
            }

            public IActionResult OnPost()
            {
                // M�todo ejecutado cuando se env�a el formulario (POST).
                if (ModelState.IsValid)
                {
                    // Aqu� deber�as manejar la l�gica para enviar el enlace de restablecimiento de contrase�a.
                    // Normalmente, esto implica generar un token, enviar un correo electr�nico al usuario, etc.

                    // Despu�s de enviar el enlace, podr�as redirigir al usuario a una p�gina de confirmaci�n.
                    // Por ejemplo:
                    return RedirectToPage("/Account/Loginn");
                }

                // Si llegamos a este punto, significa que ha habido errores de validaci�n.
                // Volveremos a mostrar el formulario con los mensajes de error.
                return Page();
            }
        }
    }
