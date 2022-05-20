using DesafioApiCompras.Data;
using DesafioApiCompras.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DesafioApiCompras.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private ProdutoContexto _context;
        public ProdutosController(ProdutoContexto context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Produtos.ToList());
            } catch (Exception ex)
            {
                return StatusCode(400, "Ocorreu um erro desconhecido");
            } 
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var produto = _context.Produtos.SingleOrDefault(p => p.Id.Equals(id));
                if (produto == null) return NotFound();
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return StatusCode(400, "Ocorreu um erro desconhecido");
            }        
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            try
            {
                try
                {
                    _context.Add(produto);
                    _context.SaveChanges();
                    return StatusCode(200, "Produto Cadastrado");
                }
                catch (Exception)
                {
                    return StatusCode(412, "Os valores informados não são válidos");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(400, "Ocorreu um erro desconhecido");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _context.Produtos.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Produtos.Remove(result);
                    _context.SaveChanges();
                    return StatusCode(200, "Produto excluído com sucesso");
                }
                catch (Exception ex)
                {
                    return StatusCode(400, "Ocorreu um erro desconhecido");
                }
            }
            return Ok();
        }
    }
}
