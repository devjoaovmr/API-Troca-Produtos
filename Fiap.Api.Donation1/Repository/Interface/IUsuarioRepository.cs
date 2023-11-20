using Fiap.Api.Donation1.Models;

namespace Fiap.Api.Donation1.Repository.Interface
{
    public interface IUsuarioRepository
    {
        public UsuarioModel FindByEmailAndSenha(UsuarioModel usuarioModel);
        public UsuarioModel FindById(int id);
        public Task<IList<UsuarioModel>> FindAll();
        public int Insert(UsuarioModel usuarioModel);
        public void Update(UsuarioModel usuarioModel);
        public void Delete(int id);
    }
}
