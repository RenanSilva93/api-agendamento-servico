using static System.Runtime.InteropServices.JavaScript.JSType;

namespace api_agendamento_servico.ViewModels
{
    public class ResultadoViewModel<T>
    {
        public ResultadoViewModel(T dados, List<string> erros)
        {
            Resultado = dados;
            Erros = erros;
        }

        public ResultadoViewModel(T dados)
        {
            Resultado = dados;
        }

        public ResultadoViewModel(List<string> erros)
        {
            Erros = erros;
        }

        public ResultadoViewModel(string erros)
        {
            Erros.Add(erros);
        }

        public T Resultado { get; private set; }
        public List<string> Erros { get; private set; } = new();
    }
}
