
using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloTema
{
    public partial class TelaTemaForm : Form
    {

        private IRepositorioTema temas;
        public TelaTemaForm(IRepositorioTema temas)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.temas = temas;
        }

        public Tema ObterTema()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;

            return new Tema(id, nome);
        }

        internal void ConfigurarTela(Tema tema)
        {
            txtId.Text = tema.id.ToString();
            txtNome.Text = tema.nome;
            txtValorTotal.Text = tema.valorTotal.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Tema tema = ObterTema();

            //if (VerificarNomeTema(tema)) {
            //    MessageBox.Show("Já existe um tema com esse nome!", "Novo Temas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private bool VerificarNomeTema(Tema Novotema) {
            List<Tema> listaTemas = temas.SelecionarTodos();

            return listaTemas.Any(tema => tema.nome.Equals(Novotema.nome));
        }
    }
}
