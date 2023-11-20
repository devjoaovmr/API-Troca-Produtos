using AutoMapper;
using Fiap.Api.Donation1.Models;
using Fiap.Api.Donation1.Repository.Interface;
using Fiap.Api.Donation1.Services;
using Fiap.Api.Donation1.ViewModel;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepository usuarioRepository;
        private readonly IMapper mapper;

        public UsuarioController(IUsuarioRepository _usuarioRepository, IMapper _mapper)
        {
            usuarioRepository = _usuarioRepository;
            mapper = _mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IList<UsuarioResponseVM>>> Get()
        {
            var usuarios = await usuarioRepository.FindAll();
            if (usuarios == null || usuarios.Count == 0)
            {
                return NoContent();
            }
            else
            {
                var resposta = mapper.Map<List<UsuarioResponseVM>>(usuarios);
                return Ok(resposta);
            };
        }

        [HttpGet("{id:int}")]
        public ActionResult<UsuarioResponseVM> GetById(int id)
        {
            var usuario = usuarioRepository.FindById(id);
            if (usuario == null || usuario.UsuarioId == 0)
            {
                return NotFound();
            }
            else
            {
                var resposta = mapper.Map<UsuarioResponseVM>(usuario);
                return Ok(resposta);
            };
        }

        [HttpPost]
        public ActionResult<UsuarioModel> Post([FromBody] UsuarioModel usuarioModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var retorno = usuarioRepository.Insert(usuarioModel);
                var url = Request.GetEncodedUrl().EndsWith("/") ? Request.GetEncodedUrl() : Request.GetEncodedUrl() + "/";
                var location = new Uri(url + usuarioModel.UsuarioId);
                return Created(location, usuarioModel);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }

        }

        [HttpPut("{id:int}")]
        public ActionResult<UsuarioModel> Put([FromRoute] int id, [FromBody] UsuarioModel usuarioModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != usuarioModel.UsuarioId)
            {
                return NotFound();
            }
            usuarioRepository.Update(usuarioModel);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public ActionResult<UsuarioModel> Delete([FromRoute] int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var usuario = usuarioRepository.FindById(id);
            if (usuario == null)
            {
                return NotFound();
            }
            else
            {
                usuarioRepository.Delete(id);
                return NoContent();
            }
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult<LoginResponseVM> Login([FromBody] LoginRequestVM loginRequestVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var usuarioModel = mapper.Map<UsuarioModel>(loginRequestVM);
            var usuario = usuarioRepository.FindByEmailAndSenha(usuarioModel);

            if (usuario != null)
            {
                var response = mapper.Map<LoginResponseVM>(usuario);
                response.Token = AuthenticationServices.GetToken(usuario);

                return Ok(response);
            }
            else
            {
                return NotFound();
            }

        }



    }
}