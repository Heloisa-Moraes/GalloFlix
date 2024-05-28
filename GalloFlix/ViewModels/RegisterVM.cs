using System.ComponentModel.DataAnnotations;

namespace GalloFlix.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Por favor, informe seu nome completo")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Por favor, informe seu email")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Por favor, informe sua data de nascimento")]
        [DataType(DataType.Date, ErrorMessage = "Formato de data inválido")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Por favor, digite sua senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirmação da Senha")]
        [Required(ErrorMessage = "Por favor, confirme sua senha")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas não coincidem")]
        public string ConfirmPassword { get; set; }
    }
}
