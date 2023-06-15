namespace FestaInfantil.ModuloTema
{
    partial class TelaCadastroItensTemaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdicionar = new Button();
            label1 = new Label();
            txtDescricao = new TextBox();
            listItens = new ListBox();
            label6 = new Label();
            txtId = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            labelTitulo = new Label();
            txtTitulo = new TextBox();
            label2 = new Label();
            txtValor = new TextBox();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(443, 69);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(68, 52);
            btnAdicionar.TabIndex = 37;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 72);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 36;
            label1.Text = "Descrição: ";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(96, 69);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(321, 23);
            txtDescricao.TabIndex = 35;
            // 
            // listItens
            // 
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 15;
            listItens.Location = new Point(26, 139);
            listItens.Name = "listItens";
            listItens.Size = new Size(485, 214);
            listItens.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 19);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 33;
            label6.Text = "ID: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(482, 16);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(29, 23);
            txtId.TabIndex = 32;
            txtId.Text = "0";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(429, 373);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 50);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(330, 373);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(93, 50);
            btnSalvar.TabIndex = 30;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(26, 19);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(38, 15);
            labelTitulo.TabIndex = 29;
            labelTitulo.Text = "Tema:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(96, 16);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(321, 23);
            txtTitulo.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 101);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 38;
            label2.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(96, 98);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(321, 23);
            txtValor.TabIndex = 39;
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // TelaCadastroItensTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 435);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(btnAdicionar);
            Controls.Add(label1);
            Controls.Add(txtDescricao);
            Controls.Add(listItens);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(labelTitulo);
            Controls.Add(txtTitulo);
            Name = "TelaCadastroItensTemaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Temas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Label label1;
        private TextBox txtDescricao;
        private ListBox listItens;
        private Label label6;
        private TextBox txtId;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label labelTitulo;
        private TextBox txtTitulo;
        private Label label2;
        private TextBox txtValor;
    }
}