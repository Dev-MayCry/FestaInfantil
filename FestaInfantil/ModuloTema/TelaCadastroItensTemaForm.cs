using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloTema
{
    public partial class TelaCadastroItensTemaForm : Form
    {
        public TelaCadastroItensTemaForm(Tema tema)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tema);
        }

        private void ConfigurarTela(Tema tema)
        {
            txtId.Text = tema.id.ToString();
            txtTitulo.Text = tema.nome;

            listItens.Items.Clear();

            foreach (ItemTema item in tema.itens)
            {
                listItens.Items.Add(item);
            }
        }

        public List<ItemTema> ObterItensCadastrados()
        {
            return listItens.Items.Cast<ItemTema>().ToList();
        }

        private ItemTema ObterItemTema()
        {
            string nome = txtDescricao.Text;

            decimal valor;
            if (txtValor.Text == "")
                 valor = 0;
            else
                valor = Convert.ToDecimal(txtValor.Text);

            ItemTema itemTema = new ItemTema(nome, valor);

            listItens.Items.Add(itemTema);

            txtDescricao.Text = "";
            txtValor.Text = "";

            return itemTema;
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            ItemTema item = ObterItemTema();

            string[] erros = item.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);

                listItens.Items.RemoveAt(listItens.Items.Count - 1);
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
