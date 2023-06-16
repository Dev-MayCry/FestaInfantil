using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloTema {
    public class ControladorTema : ControladorBase {

        private IRepositorioTema repositorioTema;
        private TabelaTemaControl tabelaTemas;
        
        public ControladorTema(IRepositorioTema repositorioTema) {
            this.repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir => "Inserir novo Tema";

        public override string ToolTipEditar => "Editar Tema Existente";

        public override string ToolTipExcluir => "Excluir Tema Existente";

        public override string LabelTipoCadastro => "Cadastro de Temas";

        public override string ToolTipAdicionarItensTema => "Adicionar Itens no Tema Selecionado";

        public override string ToolTipExcluirItensTema => "Excluir Itens no Tema Selecionado";

        public override bool AdicionarItensTemaHabilitado => true;
        public override bool ExcluirItensTemaHabilitado => true;

        public override void Inserir() {
            TelaTemaForm telaTema = new TelaTemaForm();
            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {
                Tema novoTema = telaTema.ObterTema();
                repositorioTema.Inserir(novoTema);
                CarregarTemas();
            }
        }

        public override void Editar() {

            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null) {
                MessageBox.Show("Nenhum Tema Selecionado!", "Editar Temas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaTemaForm telaTema = new TelaTemaForm();
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

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o tema {tema.nome} ?", "Exclusão de Temas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {

                repositorioTema.Excluir(tema);
                CarregarTemas();
            }
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

                    CarregarTemas();
                }
            }
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
