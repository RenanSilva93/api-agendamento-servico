using System.ComponentModel.DataAnnotations;

namespace api_agendamento_servico.ViewModels.Usuarios
{
    public class CriarUsuariosViewModel
    {
        
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        public string Senha { get; set; }

 
    }
}
