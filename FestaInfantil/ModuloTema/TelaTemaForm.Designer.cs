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
            label6.Location = new Point(21, 57);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 25;
            label6.Text = "ID: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(88, 57);
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
            btnCancelar.Location = new Point(307, 63);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 50);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(208, 63);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(93, 50);
            btnSalvar.TabIndex = 22;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 125);
            Controls.Add(labelTitulo);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "TelaTemaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaTemaForm";
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
    }
}