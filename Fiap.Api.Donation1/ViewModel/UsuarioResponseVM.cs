namespace Fiap.Api.Donation1.ViewModel
{
    public class UsuarioResponseVM
    {
        public string EmailUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public int UsuarioId { get; set; }
        public string? Regra { get; set; }

        public UsuarioResponseVM()
        {

        }
        public UsuarioResponseVM(string emailUsuario, string nomeUsuario, int usuarioId, string regra)
        {
            EmailUsuario = emailUsuario;
            NomeUsuario = nomeUsuario;
            UsuarioId = usuarioId;
            Regra = regra;
        }
    }
}

