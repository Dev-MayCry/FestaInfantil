using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloFesta;
using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloFesta
{
    public class ControladorFesta : ControladorBase
    {
        private IRepositorioFesta repositorioFesta;
        private IRepositorioTema repositorioTema;
        private IRepositorioCliente repositorioCliente;
        private TabelaFestaControl tabelaFestas;

        public ControladorFesta(IRepositorioFesta repositorioFesta, IRepositorioTema repositorioTema, IRepositorioCliente repositorioCliente)
        {
            this.repositorioFesta = repositorioFesta;
            this.repositorioTema = repositorioTema;
            this.repositorioCliente= repositorioCliente;
        }

        public override string ToolTipInserir => "Inserir Nova Festa";

        public override string ToolTipEditar => "Editar Festa Existente";

        public override string ToolTipExcluir => "Excluir Festa Existente";

        public override string LabelTipoCadastro => "Cadastro de Festas";

        public override bool FecharAluguelHabilitado { get { return true; } }

        public override void Inserir()
        {
            if (VerificarClienteTema()) return;
            
            TelaFestaForm telaFesta = new TelaFestaForm(repositorioTema, repositorioCliente, repositorioFesta);
            DialogResult opcaoEscolhida = telaFesta.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Festa novaFesta = telaFesta.ObterFesta();
                repositorioFesta.Inserir(novaFesta);
                CarregarFestas();
            }
        }

        public override void Editar()
        {
            Festa festaSelecionada = ObterFestaSelecionada();

            if (festaSelecionada == null) {
                MessageBox.Show("Nenhuma Festa Selecionada!", "Editar Festas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaFestaForm telaFesta = new TelaFestaForm(repositorioTema, repositorioCliente, repositorioFesta);

            telaFesta.ConfigurarTela(festaSelecionada);

            DialogResult opcaoEscolhida = telaFesta.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Festa festa = telaFesta.ObterFesta();
                repositorioFesta.Editar(festa.id, festa);
                CarregarFestas();
            }
        }

        public override void Excluir()
        {
            Festa festaSelecionada = ObterFestaSelecionada();

            if (festaSelecionada == null) {
                MessageBox.Show("Nenhuma Festa Selecionada!", "Excluir Festas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir a festa {festaSelecionada.tema} ?", "Exclusão de Festas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioFesta.Excluir(festaSelecionada);
                CarregarFestas();
            }
        }

        private bool VerificarClienteTema()
        {
            if (repositorioTema.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show($"Nenhum tema cadastrado", "Nova Festa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            if (repositorioCliente.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show($"Nenhum cliente cadastrado", "Nova Festa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            bool hasItem = false;

            foreach (Tema t in repositorioTema.SelecionarTodos())
            {
                if (t.itens.Count() > 0) hasItem = true;
            }
            if (hasItem == false)
            {
                MessageBox.Show($"Nenhum tema possui itens cadastrados", "Nova Festa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            return false;
        }

        private Festa ObterFestaSelecionada()
        {
            int id = tabelaFestas.ObterIdSelecionado();
            return repositorioFesta.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaFestas == null)
            {
                tabelaFestas = new TabelaFestaControl();
            }

            CarregarFestas();

            return tabelaFestas;
        }

        private void CarregarFestas()
        {
            List<Festa> festas = repositorioFesta.SelecionarTodos();
            tabelaFestas.AtualizarRegistros(festas);
        }

        public override void FecharAluguel()
        {
            Festa festa = ObterFestaSelecionada();

            if (festa == null) {
                MessageBox.Show("Nenhuma Festa Selecionada!", "Encerrar Aluguel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Encerrar o Aluguel {festa.tema} ?", "Encerramento de Aluguel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                festa.EncerrarFesta();
            }
            repositorioFesta.Editar(festa.id,festa);
            CarregarFestas();
        }
    }
}
