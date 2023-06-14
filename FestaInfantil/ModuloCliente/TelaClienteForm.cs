﻿using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestaInfantil.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        public TelaClienteForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
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

        public void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cliente cliente = ObterCliente();

            string[] erros = cliente.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        public void ConfigurarTela(Cliente cliente)
        {
            txtId.Text = cliente.id.ToString();
            txtNome.Text = cliente.nome;
            txtTelefone.Text = cliente.telefone;
        }
    }
}
