using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteIdentity.Model;
using TesteIdentity.Model.Extensions;
using TesteIdentity.Model.Services.Interfaces;

namespace ApiGestaoProdutos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult BuscaProdutos([FromQuery]ProdutoFiltro produtoFiltro, 
                                           [FromQuery]Ordem ordem)
        {
            var listaProdutos = _service.BuscaProdutos(produtoFiltro, ordem).ToList();

            if (listaProdutos.Count > 0) return Ok(listaProdutos);

            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult BuscaProdutoId(long id)
        {
            var produto = _service.BuscaPorId(id);

            if (produto != null) return Ok(produto);

            return NotFound();
        }

        [HttpPost]
        public IActionResult InsereProduto([FromBody]Produto produto)
        {
            _service.CriaProduto(produto);

            return Ok();
        }

        [HttpPut]
        public IActionResult AtualizaProduto([FromBody]Produto produto)
        {
            _service.AtualizaProduto(produto);

            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveProduto([FromBody]Produto p)
        {
            _service.RemoveProduto(p);

            return Ok();
        }
    }
}