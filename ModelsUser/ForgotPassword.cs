using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.ModelsUser
{
    public class ForgotPassword
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

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Contraseña")]
        [Compare("Password", ErrorMessage = "La contraseña y la confirmación de contraseña no coinciden.")]
        public string ConfirmPassword { get; set; }
    }
}
