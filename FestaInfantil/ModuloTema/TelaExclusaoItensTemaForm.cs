using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloTema {
    public partial class TelaExclusaoItensTemaForm : Form {
        public TelaExclusaoItensTemaForm(Tema tema) {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarTela(tema);
        }

        private void ConfigurarTela(Tema tema) {
            txtId.Text = tema.id.ToString();
            txtTitulo.Text = tema.nome;
            listItensTema.Items.Clear();
            foreach (ItemTema item in tema.itens) {
                listItensTema.Items.Add(item);
            }
        }

        public List<ItemTema> ObterItensMarcados() {
            return listItensTema.CheckedItems.Cast<ItemTema>().ToList();
        }
    }
}
