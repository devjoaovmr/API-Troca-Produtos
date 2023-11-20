using Fiap.Api.Donation1.Models;
using Fiap.Api.Donation1.Repository.Interface;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoProdutoController : ControllerBase
    {
        private readonly ITipoProdutoRepository tipoProdutoRepository;

        public TipoProdutoController(ITipoProdutoRepository _tipoProdutoRepository)
        {
            tipoProdutoRepository = _tipoProdutoRepository;
        }

        // GET: api/TipoProduto       
        [HttpGet]
        public async Task<ActionResult<IList<TipoProdutoModel>>> Get()
        {
            var tipos = await tipoProdutoRepository.FindAll();
            if (tipos == null || tipos.Count == 0)
            {
                return NoContent();
            }
            else return Ok(tipos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TipoProdutoModel>> GetTipoProdutoModel(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            else
            {
                var tipoProdutos = await tipoProdutoRepository.FindById(id);
                if (tipoProdutos == null)
                {
                    return NotFound(id);
                }
                else
                {
                    return Ok(tipoProdutos);
                }
            }
        }

        // PUT: api/TipoProduto/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoProdutoModel(int id, TipoProdutoModel tipoProdutoModel)
        {
            if (id != tipoProdutoModel.TipoProdutoId)
            {
                return BadRequest();
            }
            else
            {
                var tipoProdutoConsulta = await tipoProdutoRepository.FindById(id);

                if (tipoProdutoConsulta == null)
                {
                    return NotFound();
                }
                else
                {
                    tipoProdutoRepository.Update(tipoProdutoModel);
                    return NoContent();
                }
            }
        }

        // POST: api/TipoProduto
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoProdutoModel>> PostTipoProdutoModel(TipoProdutoModel tipoProdutoModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                await tipoProdutoRepository.Insert(tipoProdutoModel);

                var url = Request.GetEncodedUrl().EndsWith("/") ? Request.GetEncodedUrl() : Request.GetEncodedUrl() + "/";
                var location = new Uri(url + tipoProdutoModel.TipoProdutoId);
                return Created(location, tipoProdutoModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/TipoProduto/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoProdutoModel(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var tipoProduto = await tipoProdutoRepository.FindById(id);
            if (tipoProduto == null)
            {
                return NotFound();
            }
            else
            {
                tipoProdutoRepository.Delete(id);
                return NoContent();
            }
        }
    }
}
