namespace FestaInfantil
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            menuStrip1 = new MenuStrip();
            tpMenuCadastros = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            temasToolStripMenuItem = new ToolStripMenuItem();
            festaToolStripMenuItem = new ToolStripMenuItem();
            panelRegistros = new Panel();
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnExcluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnAdicionarItensTema = new ToolStripButton();
            btnVisualizarItens = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnExcluirItensTema = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnFecharAluguel = new ToolStripButton();
            labelTipoCadastro = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            lbRodape = new ToolStripStatusLabel();
            txtProcurar = new ToolStripTextBox();
            toolStripSeparator6 = new ToolStripSeparator();
            btnBuscar = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tpMenuCadastros });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tpMenuCadastros
            // 
            tpMenuCadastros.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, temasToolStripMenuItem, festaToolStripMenuItem });
            tpMenuCadastros.Name = "tpMenuCadastros";
            tpMenuCadastros.Size = new Size(71, 20);
            tpMenuCadastros.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(116, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // temasToolStripMenuItem
            // 
            temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            temasToolStripMenuItem.Size = new Size(116, 22);
            temasToolStripMenuItem.Text = "Temas";
            temasToolStripMenuItem.Click += temasToolStripMenuItem_Click;
            // 
            // festaToolStripMenuItem
            // 
            festaToolStripMenuItem.Name = "festaToolStripMenuItem";
            festaToolStripMenuItem.Size = new Size(116, 22);
            festaToolStripMenuItem.Text = "Festa";
            festaToolStripMenuItem.Click += festaToolStripMenuItem_Click;
            // 
            // panelRegistros
            // 
            panelRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRegistros.AutoSize = true;
            panelRegistros.Location = new Point(0, 53);
            panelRegistros.MaximumSize = new Size(99999999, 999999999);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(1264, 601);
            panelRegistros.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Enabled = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, toolStripSeparator3, btnEditar, toolStripSeparator1, btnExcluir, toolStripSeparator2, btnAdicionarItensTema, btnVisualizarItens, toolStripSeparator4, btnExcluirItensTema, toolStripSeparator5, btnFecharAluguel, toolStripSeparator6, labelTipoCadastro, txtProcurar, btnBuscar });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1264, 31);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnInserir.Image = (Image)resources.GetObject("btnInserir.Image");
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(28, 28);
            btnInserir.Click += btnInserir_Click_1;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 31);
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(28, 28);
            btnEditar.Click += btnEditar_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(28, 28);
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // btnAdicionarItensTema
            // 
            btnAdicionarItensTema.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarItensTema.Image = (Image)resources.GetObject("btnAdicionarItensTema.Image");
            btnAdicionarItensTema.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionarItensTema.ImageTransparentColor = Color.Magenta;
            btnAdicionarItensTema.Name = "btnAdicionarItensTema";
            btnAdicionarItensTema.Size = new Size(28, 28);
            btnAdicionarItensTema.Click += btnAdicionarItensTema_Click;
            // 
            // btnVisualizarItens
            // 
            btnVisualizarItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizarItens.Image = Properties.Resources.visibility_FILL0_wght500_GRAD0_opsz24;
            btnVisualizarItens.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizarItens.ImageTransparentColor = Color.Magenta;
            btnVisualizarItens.Name = "btnVisualizarItens";
            btnVisualizarItens.Size = new Size(28, 28);
            btnVisualizarItens.Click += btnVisualizarItens_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 31);
            // 
            // btnExcluirItensTema
            // 
            btnExcluirItensTema.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluirItensTema.Image = (Image)resources.GetObject("btnExcluirItensTema.Image");
            btnExcluirItensTema.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluirItensTema.ImageTransparentColor = Color.Magenta;
            btnExcluirItensTema.Name = "btnExcluirItensTema";
            btnExcluirItensTema.Size = new Size(28, 28);
            btnExcluirItensTema.Click += btnExcluirItensTema_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 31);
            // 
            // btnFecharAluguel
            // 
            btnFecharAluguel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFecharAluguel.Image = (Image)resources.GetObject("btnFecharAluguel.Image");
            btnFecharAluguel.ImageScaling = ToolStripItemImageScaling.None;
            btnFecharAluguel.ImageTransparentColor = Color.Magenta;
            btnFecharAluguel.Name = "btnFecharAluguel";
            btnFecharAluguel.Size = new Size(28, 28);
            btnFecharAluguel.Click += btnFecharAluguel_Click;
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(0, 28);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbRodape });
            statusStrip1.Location = new Point(0, 659);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1264, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbRodape
            // 
            lbRodape.Name = "lbRodape";
            lbRodape.Size = new Size(0, 17);
            // 
            // txtProcurar
            // 
            txtProcurar.BackColor = SystemColors.Info;
            txtProcurar.Name = "txtProcurar";
            txtProcurar.Size = new Size(150, 31);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 31);
            // 
            // btnBuscar
            // 
            btnBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageTransparentColor = Color.Magenta;
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(23, 28);
            btnBuscar.Text = "BUSCAR";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(panelRegistros);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(1280, 720);
            MinimizeBox = false;
            MinimumSize = new Size(640, 480);
            Name = "TelaPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rafaela Festas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tpMenuCadastros;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem temasToolStripMenuItem;
        private ToolStripMenuItem festaToolStripMenuItem;
        private Panel panelRegistros;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnAdicionarItensTema;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnExcluirItensTema;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnFecharAluguel;
        private ToolStripLabel labelTipoCadastro;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbRodape;
        private ToolStripButton btnVisualizarItens;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripTextBox txtProcurar;
        private ToolStripButton btnBuscar;
    }
}