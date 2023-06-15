using FestaInfantil.Dominio.ModuloCliente;
using System.Collections.Generic;
using System.Linq;

namespace FestaInfantil.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private IRepositorioCliente clientes;
        public TelaClienteForm(IRepositorioCliente clientes)
        {
            InitializeComponent();

            this.ConfigurarDialog();
            this.clientes = clientes;
        }


        public Cliente ObterCliente()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;

            string telefone = txtTelefone.Text;

            Cliente cliente = new Cliente(nome, telefone);

            if (id > 0)
                cliente.id = id;

            return cliente;

        }
        private bool VerificarDisponibilidadeCliente(Cliente cliente)
        {
            List<Cliente> listaCliente = clientes.SelecionarTodos();
            return listaCliente.Any(c => c.nome == cliente.nome);
        }


        public void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = ObterCliente();

            string[] erros = cliente.Validar();

            if (erros.Length > 0 || VerificarDisponibilidadeCliente(cliente))
            {
                if (VerificarDisponibilidadeCliente(cliente))
                {
                    MessageBox.Show($"O Cliente {cliente.nome} ja esta cadastrado.", "Novo cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    TelaPrincipal.Instancia.AtualizarRodape(erros[0]);
                }
                DialogResult = DialogResult.None;
            }

        }

        internal void ConfigurarTela(Cliente cliente)
        {
            txtId.Text = cliente.id.ToString();
            txtNome.Text = cliente.nome;
            txtTelefone.Text = cliente.telefone;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
