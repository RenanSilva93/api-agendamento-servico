using api_agendamento_servico.Data;
using api_agendamento_servico.Models;
using api_agendamento_servico.ViewModels;
using api_agendamento_servico.ViewModels.Usuarios;
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
            try
            {
                return Ok(new ResultadoViewModel<List<Usuario>>(context.Usuarios.ToList()));
            }
            catch (Exception ex) 
            {
                return StatusCode(500, new ResultadoViewModel<Usuario>("01X01 - Não foi possível obter a lista de usuários!"));
            }
            
        }

        [HttpGet("v1/usuarios/{id:int}")]
        public async Task<IActionResult> GetUsuarioAsync([FromServices] AgendamentoServicoDataContext context,
            [FromRoute] int id)
        {
            try
            {
                var usuario = await context
                    .Usuarios
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (usuario == null)
                    return NotFound(new ResultadoViewModel<Usuario>("Conteúdo não encontrado"));

                return Ok(new ResultadoViewModel<Usuario>(usuario));

            }
            catch (Exception ex) 
            {
                return StatusCode(500, new ResultadoViewModel<Usuario>("01X02 - Não foi possível obter usuário!"));
            }
            
        }

        [HttpPost("v1/usuarios")]
        public async Task<IActionResult> PostAsync(
            [FromBody] CriarUsuariosViewModel model,
            [FromServices] AgendamentoServicoDataContext context)
        {
            
            try
            {
                var usuario = new Usuario
                {
                    Nome = model.Nome,
                    Email = model.Email.ToLower(),
                    Senha = model.Senha
                };
                await context.Usuarios.AddAsync(usuario);
                await context.SaveChangesAsync();

                return Created($"v1/categories/{usuario.Id}", new ResultadoViewModel<Usuario>(usuario));
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, new ResultadoViewModel<Usuario>("01X03 - Não foi possível incluir usuário!"));
            }
            catch
            {
                return StatusCode(500, new ResultadoViewModel<Usuario>("01X04 - Falha interna no servidor"));
            }
        }

        [HttpPut("v1/usuarios")]
        public async Task<IActionResult> PutAsync(
            [FromBody] EditorUsuariosViewModel model,
            [FromServices] AgendamentoServicoDataContext context)
        {
            try
            {
                var usuario = await context
                    .Usuarios
                    .FirstOrDefaultAsync(x => x.Id == model.Id);

                if (usuario == null)
                    return NotFound(new ResultadoViewModel<Usuario>("Conteúdo não encontrado"));

                usuario.Nome = model.Nome;
                usuario.Email = model.Email;

                context.Usuarios.Update(usuario);
                await context.SaveChangesAsync();

                return Ok(new ResultadoViewModel<Usuario>(usuario));

            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, new ResultadoViewModel<Usuario>("01X05 - Não foi possível atualizar usuário!"));
            }
            catch
            {
                return StatusCode(500, new ResultadoViewModel<Usuario>("01X06 - Falha interna no servidor"));
            }
        }

    }
}
