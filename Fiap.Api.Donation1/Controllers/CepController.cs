﻿using Fiap.Api.Donation1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        [HttpGet("{cep}")]
        public async Task<IActionResult> GetAsync([FromRoute] string cep)
        {
            var url = $"https://viacep.com.br/ws/{cep}/json/";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            if (response != null || response.IsSuccessStatusCode)
            {
                var conteudo = await response.Content.ReadAsStringAsync();
                CepModel cepModel = Newtonsoft.Json.JsonConvert.DeserializeObject<CepModel>(conteudo);
                return Ok(conteudo);
            }
            return Ok();
        }
    }
}
