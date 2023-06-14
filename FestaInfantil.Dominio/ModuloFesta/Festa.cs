using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.Dominio.ModuloFesta
{
    [Serializable]
    public class Festa : EntidadeBase<Festa>
    {
        public Cliente cliente;
        public Tema tema;
        public DateTime data;
        public TimeSpan horaInicio;
        public TimeSpan horaFim;
        public string endereco;
        public decimal valorTotal;
        public decimal valorEntrada;
        public decimal valorRestante;
        public List<ItemTema> itensSelecionados;
        public bool encerrado = false;

        public void EncerrarFesta() {
            encerrado = true;
            valorRestante = 0;
            cliente.antigo = true;
        }

        public Festa() { }

        public Festa(Cliente cliente, Tema tema, DateTime data, TimeSpan horaInicio, TimeSpan horaFim, string endereco, decimal valorTotal, decimal valorEntrada, List<ItemTema> itensSelecionados, bool encerrado)
        {
            this.cliente = cliente;
            this.tema = tema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
            this.endereco = endereco;
            this.valorTotal = valorTotal;
            this.valorEntrada = valorEntrada;
            this.itensSelecionados = itensSelecionados;
            valorRestante = this.valorTotal - this.valorEntrada;
            this.encerrado = encerrado;
        }

        public Festa(int id, Cliente cliente, Tema tema, DateTime data, TimeSpan horaInicio, TimeSpan horaFim, string endereco, decimal valorTotal, decimal valorEntrada, List<ItemTema> itensSelecionados, bool encerrado)
        {
            this.id = id;
            this.cliente = cliente;
            this.tema = tema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
            this.endereco = endereco;
            this.valorTotal = valorTotal;
            this.valorEntrada = valorEntrada;
            this.itensSelecionados = itensSelecionados;
            valorRestante = this.valorTotal - this.valorEntrada;
            this.encerrado = encerrado;
        }

        public override void AtualizarInformacoes(Festa registroAtualizado)
        {
            cliente = registroAtualizado.cliente;
            tema = registroAtualizado.tema;
            data = registroAtualizado.data;
            horaInicio = registroAtualizado.horaInicio;
            horaFim = registroAtualizado.horaFim;
            endereco = registroAtualizado.endereco;
            valorTotal = registroAtualizado.valorTotal;
            valorEntrada = registroAtualizado.valorEntrada;
            itensSelecionados = registroAtualizado.itensSelecionados;
            valorRestante = registroAtualizado.valorRestante;
            encerrado = registroAtualizado.encerrado;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(endereco))
                erros.Add("O campo 'endereço' é obrigatório");

            return erros.ToArray();
        }
    }
}
