using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloFesta;
using FestaInfantil.Dominio.ModuloTema;
using System.Collections;

namespace FestaInfantil.ModuloFesta
{
    public partial class TelaFestaForm : Form
    {
        private IRepositorioFesta festas;
        private IRepositorioCliente clientes;


        public TelaFestaForm(IRepositorioTema temas, IRepositorioCliente clientes, IRepositorioFesta festas)
        {
            InitializeComponent();

            this.festas = festas;
            this.clientes = clientes;

            CarregarInformacoes(temas, clientes);
        }

        private void ConfereSeClienteTemDesconto()
        {
            Cliente? cliente = cmbBoxCliente.SelectedItem as Cliente;

            CalculaDesconto(cliente);
            AtualizaValores();
        }

        private void CarregarInformacoes(IRepositorioTema temas, IRepositorioCliente clientes)
        {
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

        private double desconto = 1;

        private void AtualizaValores()
        {
            double valorTotal = 0;
            List<ItemTema> itensSelecionados = ObterItensMarcados();
            foreach (ItemTema item in itensSelecionados)
            {
                valorTotal += (double)item.valor;
            }

            valorTotal *= desconto;
            txtValorTotal.Text = valorTotal.ToString("N2");

            double valorEntrada = valorTotal - (valorTotal * (double)txtDesconto.Value / 100.0);

            txtValorEntrada.Text = valorEntrada.ToString("N2");
        }

        private void listaItens_SelectedValueChanged(object sender, EventArgs e)
        {
            AtualizaValores();
        }

        private void CalculaDesconto(Cliente cliente)
        {
            int tetoDesconto = 5;
            int nDesconto = 2;

            if (festas.SelecionarTodos().Any(f => f.cliente.nome == cliente.nome))
            {
                int contadorCliente = 0;
                foreach (Festa f in festas.SelecionarTodos())
                    if (f.cliente.nome == cliente.nome) contadorCliente++;

                if (contadorCliente * nDesconto > tetoDesconto) desconto = 0.95;
                else desconto = 1 - (contadorCliente * nDesconto / 100.0);
            }
            else desconto = 1;
        }

        private void cmbBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfereSeClienteTemDesconto();
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

            double valorTotal = Convert.ToDouble(txtValorTotal.Text);
            double valorEntrada = Convert.ToDouble(txtValorEntrada.Text);

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
            ConfereSeClienteTemDesconto();

            Festa festa = ObterFesta();

            string[] erros = festa.Validar();

            bool valorNulo = false;

            if (listaItens.CheckedItems.Count == 0) valorNulo = true;
            
            if (erros.Length > 0 || VerificarTemaDisponivelNaData(festa) || valorNulo)
            {
                if (VerificarTemaDisponivelNaData(festa))
                {
                    MessageBox.Show($"O tema {festa.tema} já está reservado na data selecionada. ", "Nova Festa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (valorNulo)
                {
                    MessageBox.Show($"Nenhum Item do tema {festa.tema} selecionado. ", "Nova Festa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txtDesconto_ValueChanged(object sender, EventArgs e)
        {
            AtualizaValores();
        }
    }
}
