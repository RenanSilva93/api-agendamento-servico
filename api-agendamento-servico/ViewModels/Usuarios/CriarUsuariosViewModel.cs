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
        
        [Required(ErrorMessage = "A senha é obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "CPF/CNPJ é obrigatório")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "Este campo deve conter entre 11 e 14 caracteres")]
        public string CPF_CNPJ { get; set; }

        [Required(ErrorMessage = "O celular é obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve conter 11 caracteres")]
        public string Celular { get; set; }
    }
}
