using Microsoft.Extensions.Hosting;
using System.Data;

namespace api_agendamento_servico.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CPF_CNPJ { get; set; }
        public string Celular { get; set; }
    }
}
