using FestaInfantil.Dominio.ModuloCliente;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
        {
            InitializeComponent();
            ConfigurarColunas();

            gridCliente.ConfigurarGridZebrado();

            gridCliente.ConfigurarGridSomenteLeitura();
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "ID"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
                },

            };

            gridCliente.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            gridCliente.Rows.Clear();

            foreach (Cliente cliente in clientes)
            {
                gridCliente.Rows.Add(cliente.id, cliente.nome, cliente.telefone);
            }
        }

        public int ObterIdSelecionado()
        {
            if (gridCliente.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridCliente.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
