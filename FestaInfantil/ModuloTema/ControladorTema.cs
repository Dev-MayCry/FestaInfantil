using FestaInfantil.Dominio.ModuloFesta;
using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloTema {
    public class ControladorTema : ControladorBase {

        private IRepositorioTema repositorioTema;
        private IRepositorioFesta repositorioFesta;
        private TabelaTemaControl tabelaTemas;
        
        public ControladorTema(IRepositorioTema repositorioTema, IRepositorioFesta repositorioFesta) {
            this.repositorioTema = repositorioTema;
            this.repositorioFesta = repositorioFesta;
        }

        public override string ToolTipInserir => "Inserir novo Tema";

        public override string ToolTipEditar => "Editar Tema Existente";

        public override string ToolTipExcluir => "Excluir Tema Existente";

        public override string LabelTipoCadastro => "Cadastro de Temas";

        public override string ToolTipAdicionarItensTema => "Adicionar Itens no Tema Selecionado";

        public override string ToolTipExcluirItensTema => "Excluir Itens do Tema Selecionado";
        public override string ToolTipVisualizarItensTema => "Visualziar Itens do Tema Selecionado";

        public override bool AdicionarItensTemaHabilitado => true;
        public override bool ExcluirItensTemaHabilitado => true;
        public override bool VisualizarItensTemaHabilitado => true;


        public override void Inserir() {
            TelaTemaForm telaTema = new TelaTemaForm(repositorioTema);
            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {

                Tema novoTema = telaTema.ObterTema();

                if (VerificarNomeTema(novoTema)) {
                    MessageBox.Show("Já existe um tema com esse nome!", "Novo Tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Inserir();
                } 
                else {
                    repositorioTema.Inserir(novoTema);
                    CarregarTemas();
                }
            }
        }

        private bool VerificarNomeTema(Tema novoTema) {
            List<Tema> listaTemas = repositorioTema.SelecionarTodos();

            return listaTemas.Any(tema => tema.nome.Equals(novoTema.nome));
        }

        public override void Editar() {

            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null) {
                MessageBox.Show("Nenhum Tema Selecionado!", "Editar Temas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaTemaForm telaTema = new TelaTemaForm(repositorioTema);
            telaTema.ConfigurarTela(temaSelecionado);

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {

                Tema tema = telaTema.ObterTema();

                repositorioTema.Editar(tema.id, tema);

                CarregarTemas();
            }
        }

        public override void Excluir() {
            Tema tema = ObterTemaSelecionado();

            if (tema == null)
            {
                MessageBox.Show("Nenhum Tema Selecionado!", "Excluir Temas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TemaComAluguelAberto(tema)) {
                MessageBox.Show("Não é possível excluir um tema que possua uma festa em aberto!", "Excluir Temas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o tema {tema.nome} ?", "Exclusão de Temas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {

                repositorioTema.Excluir(tema);
                CarregarTemas();
            }
        }

        private bool TemaComAluguelAberto(Tema tema) {

            List<Festa> festasAbertas =  ListaFestasAbertas();

            return festasAbertas.Any(f => f.tema == tema);
        }

        private List<Festa> ListaFestasAbertas() {

            List<Festa> festasAbertas = new List<Festa>();
            List<Festa> festas = repositorioFesta.SelecionarTodos();

            foreach (Festa f in festas) {
                if (f.encerrado == false) {
                    festasAbertas.Add(f);
                }
            }
            return festasAbertas;
        }

        public override void AdicionarItensTema() {

            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null) {
                MessageBox.Show("Nenhuma Tema Selecionado!", "Adição de itens do Tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroItensTemaForm telaCadastroItensTemaForm = new TelaCadastroItensTemaForm(temaSelecionado);

            DialogResult opcao = telaCadastroItensTemaForm.ShowDialog();

            if (opcao == DialogResult.OK) {
                List<ItemTema> itensParaAdicionar = telaCadastroItensTemaForm.ObterItensCadastrados();
                temaSelecionado.LimparListaItens();

                foreach (ItemTema item in itensParaAdicionar)
                    temaSelecionado.AdicionarItem(item);

                repositorioTema.Editar(temaSelecionado.id, temaSelecionado);

                temaSelecionado.AtualizarValorTotal();

                CarregarTemas();
            }
        }

        public override void ExcluirItensTema() {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null) {
                MessageBox.Show("Nenhuma Tema Selecionado!", "Exclusão de itens do Tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaExclusaoItensTemaForm telaExclusao = new TelaExclusaoItensTemaForm(temaSelecionado);

            if(temaSelecionado.itens.Count == 0) 
            {
                MessageBox.Show("O Tema selecionado não possui nenhum item cadastrado!", "Exclusão de itens do Tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            } 
            else 
            {
                DialogResult opcao = telaExclusao.ShowDialog();

                if (opcao == DialogResult.OK) 
                {

                    List<ItemTema> itensMarcados = telaExclusao.ObterItensMarcados();

                    foreach (ItemTema item in itensMarcados) 
                        temaSelecionado.RemoverItem(item);

                    repositorioTema.Editar(temaSelecionado.id, temaSelecionado);

                    temaSelecionado.AtualizarValorTotal();

                    CarregarTemas();
                }
            }
        }

        public override void VisualizarItensTema() {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null) {
                MessageBox.Show("Nenhuma Tema Selecionado!", "Visualização de itens do Tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaVisualizacaoItensForm telaVisualizacaoItens = new TelaVisualizacaoItensForm(temaSelecionado);

            telaVisualizacaoItens.ShowDialog();


        }

        private Tema ObterTemaSelecionado() {
            int id = tabelaTemas.ObterIdSelecionado();
            return repositorioTema.SelecionarPorId(id);
        }

        public override UserControl ObterListagem() {
            if (tabelaTemas == null) {
                tabelaTemas = new TabelaTemaControl();
            }

            CarregarTemas();

            return tabelaTemas;
        }

        private void CarregarTemas() {
            
            List<Tema> temas = repositorioTema.SelecionarTodos();
            tabelaTemas.AtualizarRegistros(temas);
            
        }
    }
}
