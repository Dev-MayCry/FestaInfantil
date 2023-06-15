namespace FestaInfantil.ModuloCliente
{
    partial class TelaClienteForm
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
            labelTitulo = new Label();
            txtNome = new TextBox();
            label6 = new Label();
            txtId = new TextBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            lbTelefone = new Label();
            button1 = new Button();
            btnSalvar = new Button();
            txtTelefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(28, 38);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(46, 15);
            labelTitulo.TabIndex = 33;
            labelTitulo.Text = "Nome: ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(312, 23);
            txtNome.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(201, 77);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 31;
            label6.Text = "ID: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(228, 74);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(34, 23);
            txtId.TabIndex = 30;
            txtId.Text = "0";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(-89, -182);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 50);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.DialogResult = DialogResult.OK;
            btnConfirmar.Location = new Point(-188, -182);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(93, 50);
            btnConfirmar.TabIndex = 28;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(17, 77);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(57, 15);
            lbTelefone.TabIndex = 35;
            lbTelefone.Text = "Telefone: ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(300, 131);
            button1.Name = "button1";
            button1.Size = new Size(93, 50);
            button1.TabIndex = 37;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(201, 131);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(93, 50);
            btnSalvar.TabIndex = 36;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.HidePromptOnLeave = true;
            txtTelefone.Location = new Point(81, 74);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(91, 23);
            txtTelefone.TabIndex = 38;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 189);
            Controls.Add(txtTelefone);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(lbTelefone);
            Controls.Add(labelTitulo);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Name = "TelaClienteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox txtNome;
        private Label label6;
        private TextBox txtId;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Label lbTelefone;
        private Button button1;
        private Button btnSalvar;
        private MaskedTextBox txtTelefone;
    }
}