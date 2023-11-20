using Fiap.Api.Donation1.Models;

namespace Fiap.Api.Donation1.Repository.Interface
{
    public interface ITipoProdutoRepository
    {
        public Task<TipoProdutoModel> FindById(int id);
        public Task<IList<TipoProdutoModel>> FindAll();
        public Task<int> Insert(TipoProdutoModel tipoProdutoModel);
        public void Update(TipoProdutoModel tipoProdutoModel);
        public void Delete(TipoProdutoModel tipoProdutoModel);
        public void Delete(int id);
    }
}
