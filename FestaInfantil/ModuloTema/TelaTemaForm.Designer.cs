namespace FestaInfantil.ModuloTema
{
    partial class TelaTemaForm
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
            btnSalvar = new Button();
            txtValorTotal = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(21, 15);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(46, 15);
            labelTitulo.TabIndex = 27;
            labelTitulo.Text = "Nome: ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(88, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(312, 23);
            txtNome.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 63);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 25;
            label6.Text = "ID: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(88, 60);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(38, 23);
            txtId.TabIndex = 24;
            txtId.Text = "0";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(307, 124);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 50);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(208, 124);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(93, 50);
            btnSalvar.TabIndex = 22;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(233, 57);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(167, 23);
            txtValorTotal.TabIndex = 28;
            txtValorTotal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 60);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 29;
            label1.Text = "Valor Total:";
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 186);
            Controls.Add(label1);
            Controls.Add(txtValorTotal);
            Controls.Add(labelTitulo);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTemaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Tema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox txtNome;
        private Label label6;
        private TextBox txtId;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtValorTotal;
        private Label label1;
    }
}