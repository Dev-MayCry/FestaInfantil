

using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloTema {
    public partial class TelaVisualizacaoItensForm : Form {
        public TelaVisualizacaoItensForm(Tema tema) {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarTela(tema);
        }

        private void ConfigurarTela(Tema tema) {
            txtId.Text = tema.id.ToString();
            txtTitulo.Text = tema.nome;
            txtValor.Text = tema.valorTotal.ToString();
            listItens.Items.Clear();
            foreach (ItemTema item in tema.itens) {
                listItens.Items.Add(item);
            }
        }
    }
}
