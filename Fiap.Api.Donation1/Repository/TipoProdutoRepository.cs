using Fiap.Api.Donation1.Data;
using Fiap.Api.Donation1.Models;
using Fiap.Api.Donation1.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.Donation1.Repository
{
    public class TipoProdutoRepository : ITipoProdutoRepository
    {
        private readonly DataContext dataContext;

        public TipoProdutoRepository(DataContext ctx)
        {
            dataContext = ctx;
        }
        public async void Delete(TipoProdutoModel tipoProdutoModel)
        {
            dataContext.TipoProdutos.Remove(tipoProdutoModel);
            dataContext.SaveChanges();
        }

        public async void Delete(int id)
        {
            var tipoProdutoModel = new TipoProdutoModel()
            {
                TipoProdutoId = id
            };

            Delete(tipoProdutoModel);
        }

        public async Task<IList<TipoProdutoModel>> FindAll()
        {
            var tipos = await dataContext.TipoProdutos.AsNoTracking().ToListAsync();
            return tipos == null ? new List<TipoProdutoModel>() : tipos;
        }

        public async Task<TipoProdutoModel> FindById(int id)
        {
            var tipoProduto = await dataContext.TipoProdutos.AsNoTracking().FirstOrDefaultAsync(u => u.TipoProdutoId == id);
            return tipoProduto;
        }

        public async Task<int> Insert(TipoProdutoModel tipoProdutoModel)
        {
            dataContext.TipoProdutos.Add(tipoProdutoModel);
            dataContext.SaveChanges();
            return tipoProdutoModel.TipoProdutoId;
        }

        public async void Update(TipoProdutoModel tipoProdutoModel)
        {
            dataContext.TipoProdutos.Update(tipoProdutoModel);
            dataContext.SaveChanges();
        }
    }
}
