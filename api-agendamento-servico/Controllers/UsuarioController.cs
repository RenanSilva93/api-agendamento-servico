using api_agendamento_servico.Data;
using api_agendamento_servico.Models;
using api_agendamento_servico.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_agendamento_servico.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("v1/usuarios")]
        public IActionResult GetUsuarios([FromServices] AgendamentoServicoDataContext context)
        {
            return Ok(new ResultadoViewModel<List<Usuario>>(context.Usuarios.ToList()));
        }

        [HttpGet("v1/usuarios/{id:int}")]
        public async Task<IActionResult> GetUsuarioAsync([FromServices] AgendamentoServicoDataContext context,
            [FromRoute] int id)
        {
            var usuario = await context
                    .Usuarios
                    .FirstOrDefaultAsync(x => x.Id == id);

            if (usuario == null)
                return NotFound(new ResultadoViewModel<Usuario>("Conteúdo não encontrado"));

            return Ok(new ResultadoViewModel<Usuario>(usuario));
        }

    }
}
