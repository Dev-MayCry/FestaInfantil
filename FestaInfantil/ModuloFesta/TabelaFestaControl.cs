﻿using FestaInfantil.Dominio.ModuloFesta;
using FestaInfantil.Dominio.ModuloTema;

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
                    Name = "tema",
                    HeaderText= "Tema"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "data",
                    HeaderText= "Data"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "hora",
                    HeaderText= "Horario"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "endereco",
                    HeaderText= "Endereço"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "preco",
                    HeaderText= "Preço"
                },
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Festa> festas)
        {
            grid.Rows.Clear();

            foreach (Festa f in festas)
                grid.Rows.Add(f.id, f.cliente, f.tema, f.data, f.horaInicio, f.endereco, f.valorTotal); ;
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
