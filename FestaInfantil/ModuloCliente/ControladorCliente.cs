using e_Agenda.WinApp.ModuloContato;
using FestaInfantil.Dominio.ModuloCliente;

namespace FestaInfantil.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {

        private IRepositorioCliente repositorioCliente;
        private TabelaClienteControl tabelaCliente;
        
        public ControladorCliente(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir => "Inserir novo Cliente";

        public override string ToolTipEditar => "Editar Cliente Existente";

        public override string ToolTipExcluir => "Excluir Cliente Existente";

        public override string LabelTipoCadastro => "Cadastro De Clientes";

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new TelaClienteForm(repositorioCliente);
            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente novoCliente = telaCliente.ObterCliente();
                repositorioCliente.Inserir(novoCliente);
                CarregarCliente();
            }
        }

        public override void Editar()
        {
            Cliente clienteSelecionado = ObterClienteSelecionado();

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Nenhum Cliente Selecionado!", "Editar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaClienteForm telaCliente = new TelaClienteForm(repositorioCliente);
            telaCliente.ConfigurarTela(clienteSelecionado);

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = telaCliente.ObterCliente();

                repositorioCliente.Editar(cliente.id, cliente);

                CarregarCliente();
            }
        }

        public override void Excluir()
        {
            Cliente clienteSelecionado = ObterClienteSelecionado();

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Nenhum Cliente Selecionado!", "Excluir Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o Cliente {clienteSelecionado.nome} ?", "Exclusão de Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Excluir(clienteSelecionado);
                CarregarCliente();
            }
        }

        private Cliente ObterClienteSelecionado()
        {
            int id = tabelaCliente.ObterIdSelecionado();
            return repositorioCliente.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
            {
                tabelaCliente = new TabelaClienteControl();
            }

            CarregarCliente();

            return tabelaCliente;
        }
        private void CarregarCliente()
        {
            List<Cliente> cliente = repositorioCliente.SelecionarTodos();
            tabelaCliente.AtualizarRegistros(cliente);
            TelaPrincipal.Instancia.AtualizarRodape("Visualizando Clientes");
        }
    }
}
