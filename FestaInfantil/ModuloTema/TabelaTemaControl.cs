using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloTema {
    public partial class TabelaTemaControl : UserControl {
        public TabelaTemaControl() {
            InitializeComponent();
            ConfigurarColunas();
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        private void ConfigurarColunas() {
            DataGridViewColumn[] colunas = new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn(){
                    Name = "id",
                    HeaderText= "ID",
                },
                new DataGridViewTextBoxColumn(){
                    Name = "nome",
                    HeaderText= "Tema"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "valorTotal",
                    HeaderText= "Valor Total"
                },
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Tema> temas) {

            grid.Rows.Clear();

            foreach (Tema t in temas) 
                grid.Rows.Add(t.id, t.nome,t.valorTotal);
        }

        public int ObterIdSelecionado() {

            int id = 0;
            try {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            } catch {
                id = -1;
            }

            return id;
        }
    }
}
