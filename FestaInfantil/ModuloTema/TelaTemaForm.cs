using FestaInfantil.Compartilhado;
using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        public TelaTemaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Tema tema = ObterTema();

            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
