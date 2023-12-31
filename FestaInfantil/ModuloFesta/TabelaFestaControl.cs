﻿using FestaInfantil.Dominio.ModuloFesta;

namespace FestaInfantil.ModuloFesta
{
    public partial class TabelaFestaControl : UserControl
    {
        public TabelaFestaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn(){
                    Name = "id",
                    HeaderText= "ID",
                },
                new DataGridViewTextBoxColumn(){
                    Name = "nome",
                    HeaderText= "Cliente"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "telefone",
                    HeaderText= "Telefone"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "tema",
                    HeaderText= "Tema"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "data",
                    HeaderText= "Data"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "preco",
                    HeaderText= "Preço"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "valorAPagar",
                    HeaderText= "Valor a Pagar"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "aberto",
                    HeaderText= "Em Aberto"
                },
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Festa> festas)
        {
            grid.Rows.Clear();

            foreach (Festa f in festas)
                if (f.encerrado) grid.Rows.Add(f.id, f.cliente, f.cliente.telefone, f.tema, f.data.ToShortDateString(), f.valorTotal, f.valorRestante, "Encerrado");
                else grid.Rows.Add(f.id, f.cliente, f.cliente.telefone, f.tema, f.data.ToShortDateString(), f.valorTotal, f.valorRestante, "Em Aberto");
        }

        public int ObterIdSelecionado()
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
