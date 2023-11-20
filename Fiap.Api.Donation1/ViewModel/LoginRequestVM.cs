using System.ComponentModel.DataAnnotations;

namespace Fiap.Api.Donation1.ViewModel
{
    public class LoginRequestVM
    {
        [Required(ErrorMessage = "O Email é obrigatorio")]
        public string EmailUsuario { get; set; }
        [Required(ErrorMessage = "A senha é obrigatoria")]
        public string Senha { get; set; }

        public LoginRequestVM()
        {

        }
        public LoginRequestVM(string emailUsuario, string senha)
        {
            EmailUsuario = emailUsuario;
            Senha = senha;
        }
    }
}
