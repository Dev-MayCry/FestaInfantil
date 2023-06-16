namespace FestaInfantil.ModuloTema {
    partial class TelaVisualizacaoItensForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.listItens = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 54;
            this.label6.Text = "ID: ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(471, 15);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(29, 23);
            this.txtId.TabIndex = 53;
            this.txtId.Text = "0";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(412, 391);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 50);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "OK";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(27, 15);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(38, 15);
            this.labelTitulo.TabIndex = 50;
            this.labelTitulo.Text = "Tema:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(90, 12);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(302, 23);
            this.txtTitulo.TabIndex = 49;
            // 
            // listItens
            // 
            this.listItens.FormattingEnabled = true;
            this.listItens.ItemHeight = 15;
            this.listItens.Location = new System.Drawing.Point(15, 96);
            this.listItens.Name = "listItens";
            this.listItens.Size = new System.Drawing.Size(485, 289);
            this.listItens.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Valor Total:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(90, 45);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(302, 23);
            this.txtValor.TabIndex = 57;
            // 
            // TelaVisualizacaoItensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.listItens);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.txtTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaVisualizacaoItensForm";
            this.ShowIcon = false;
            this.Text = "Visualização de Itens do Tema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label6;
        private TextBox txtId;
        private Button btnCancelar;
        private Label labelTitulo;
        private TextBox txtTitulo;
        private ListBox listItens;
        private Label label1;
        private TextBox txtValor;
    }
}