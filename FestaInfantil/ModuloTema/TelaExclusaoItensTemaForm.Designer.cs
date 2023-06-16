namespace FestaInfantil.ModuloTema
{
    partial class TelaExclusaoItensTemaForm
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
            label6 = new Label();
            txtId = new TextBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            labelTitulo = new Label();
            txtTitulo = new TextBox();
            listItensTema = new CheckedListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 17);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 45;
            label6.Text = "ID: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(479, 14);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(29, 23);
            txtId.TabIndex = 44;
            txtId.Text = "0";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(422, 391);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 50);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.DialogResult = DialogResult.OK;
            btnConfirmar.Location = new Point(323, 391);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(93, 50);
            btnConfirmar.TabIndex = 42;
            btnConfirmar.Text = "Excluir";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(23, 17);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(38, 15);
            labelTitulo.TabIndex = 41;
            labelTitulo.Text = "Tema:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(93, 14);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(321, 23);
            txtTitulo.TabIndex = 40;
            // 
            // listItensTema
            // 
            listItensTema.FormattingEnabled = true;
            listItensTema.Location = new Point(23, 87);
            listItensTema.Name = "listItensTema";
            listItensTema.Size = new Size(485, 274);
            listItensTema.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 59);
            label1.Name = "label1";
            label1.Size = new Size(200, 15);
            label1.TabIndex = 48;
            label1.Text = "Selecione os Itens a serem excluídos:";
            // 
            // TelaExclusaoItensTemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listItensTema);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Name = "TelaExclusaoItensTemaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exclusão de Itens do Tema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private TextBox txtId;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Label labelTitulo;
        private TextBox txtTitulo;
        private CheckedListBox listItensTema;
        private Label label1;
    }
}