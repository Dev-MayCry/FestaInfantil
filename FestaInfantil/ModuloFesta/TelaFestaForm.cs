using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloFesta;
using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloFesta
{
    public partial class TelaFestaForm : Form
    {
        private IRepositorioFesta festas;

        public TelaFestaForm(IRepositorioTema temas, IRepositorioCliente clientes, IRepositorioFesta festas)
        {
            InitializeComponent();

            CarregarInformacoes(temas, clientes);

            this.festas = festas;
        }

        private void CarregarInformacoes(IRepositorioTema temas, IRepositorioCliente clientes)
        {
            txtData.MinDate = DateTime.Now.AddDays(1);

            foreach (Tema t in temas.SelecionarTodos())
            {
                if (t.itens.Count > 0)
                    cmbBoxTema.Items.Add(t);
            }

            cmbBoxTema.SelectedItem = cmbBoxTema.Items[0];

            foreach (Cliente c in clientes.SelecionarTodos())
            {
                cmbBoxCliente.Items.Add(c);
            }

            cmbBoxCliente.SelectedItem = cmbBoxCliente.Items[0];
        }

        private void cmbBoxTema_SelectedValueChanged(object sender, EventArgs e)
        {
            listaItens.Items.Clear();

            Tema tema = (Tema)cmbBoxTema.SelectedItem;

            foreach (ItemTema item in tema.itens)
            {
                listaItens.Items.Add(item);
                listaItens.SetItemChecked(listaItens.Items.Count - 1, true);
                AtualizaValores();
            }

        }

        private decimal desconto = 1;

        private void AtualizaValores()
        {
            decimal valorTotal = 0;
            List<ItemTema> itensSelecionados = ObterItensMarcados();
            foreach (ItemTema item in itensSelecionados)
            {
                valorTotal += item.valor;
            }

            valorTotal *= desconto;

            txtValorTotal.Text = valorTotal.ToString();

            decimal valorEntrada = valorTotal * (decimal)0.4;

            txtValorEntrada.Text = valorEntrada.ToString();
        }

        private void listaItens_SelectedValueChanged(object sender, EventArgs e)
        {
            AtualizaValores();
        }

        private bool VerificarCliente(Cliente cliente)
        {
            if (cliente.antigo)
                return true;
            return false;
        }

        private void cmbBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = cmbBoxCliente.SelectedItem as Cliente;

            if (VerificarCliente(cliente))
            {
                desconto = (decimal)0.9;
            }

        }

        public Festa ObterFesta()
        {
            int id = Convert.ToInt32(txtId.Text);
            Cliente cliente = (Cliente)cmbBoxCliente.SelectedItem;

            Tema tema = (Tema)cmbBoxTema.SelectedItem;

            string endereco = txtEndereco.Text;

            DateTime data = txtData.Value;
            TimeSpan horaInicio = txtHoraInicio.Value.TimeOfDay;
            TimeSpan horaFim = txtHoraFim.Value.TimeOfDay;

            decimal valorTotal = Convert.ToDecimal(txtValorTotal.Text);
            decimal valorEntrada = Convert.ToDecimal(txtValorEntrada.Text);

            List<ItemTema> itensSelecionados = ObterItensMarcados();

            Festa festa = new Festa(id, cliente, tema, data, horaInicio, horaFim, endereco, valorTotal, valorEntrada, itensSelecionados, false);

            if (id > 0) festa.id = id;

            return festa;
        }

        public List<ItemTema> ObterItensMarcados()
        {
            return listaItens.CheckedItems.Cast<ItemTema>().ToList();
        }

        public bool VerificarTemaDisponivelNaData(Festa festa)
        {
            List<Festa> listaFestas = festas.SelecionarTodos();
            return listaFestas.Any(f => f.tema == festa.tema && f.data.DayOfYear == festa.data.DayOfYear && f.id != festa.id);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Festa festa = ObterFesta();

            string[] erros = festa.Validar();

            if (erros.Length > 0 || VerificarTemaDisponivelNaData(festa))
            {
                if (VerificarTemaDisponivelNaData(festa))
                {
                    MessageBox.Show($"O tema {festa.tema} já está reservado na data selecionada. ", "Nova Festa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    TelaPrincipal.Instancia.AtualizarRodape(erros[0]);
                }

                DialogResult = DialogResult.None;
            }
        }

        internal void ConfigurarTela(Festa festa)
        {
            txtId.Text = festa.id.ToString();
            cmbBoxTema.SelectedItem = festa.tema;
            cmbBoxCliente.SelectedItem = festa.cliente;
            txtEndereco.Text = festa.endereco;
            txtData.MinDate = festa.data;
            txtData.Value = festa.data;
            txtHoraInicio.Value = DateTime.Now.Date.Add(festa.horaInicio);
            txtHoraFim.Value = DateTime.Now.Date.Add(festa.horaFim);
            txtValorTotal.Text = festa.valorTotal.ToString();
            txtValorEntrada.Text = festa.valorEntrada.ToString();

            int i = 0;

            for (int j = 0; j < listaItens.Items.Count; j++)
            {
                var item = (ItemTema)listaItens.Items[j];
                if (festa.itensSelecionados.Contains(item))
                    listaItens.SetItemChecked(i, true);

                i++;
            }
        }
    }
}
