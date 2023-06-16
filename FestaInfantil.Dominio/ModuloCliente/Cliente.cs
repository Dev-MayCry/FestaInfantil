using System.Text.RegularExpressions;

namespace FestaInfantil.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nome { get; set; }
        public string telefone;
        public bool antigo = false;
        public Cliente()
        {

        }
        public Cliente(int id, string nome, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;

        }

        public Cliente(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;

        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.telefone = registroAtualizado.telefone;

        }
        public override string ToString()
        {
            return nome;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");

            if (string.IsNullOrEmpty(telefone) || telefone.Count(char.IsDigit) < 9)
                erros.Add("O campo 'telefone' é obrigatório e deve conter os digitos corretos");

            return erros.ToArray();
        }

        public override bool Equals(object? obj)
        {
            return obj is Cliente cliente && id == cliente.id && nome == cliente.nome && telefone == cliente.telefone;
        }
    }
}
