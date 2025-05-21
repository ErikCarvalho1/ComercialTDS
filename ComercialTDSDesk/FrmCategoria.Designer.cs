namespace ComercialTDSDesk
{
    partial class FrmCategoria
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
            label2 = new Label();
            label1 = new Label();
            bntCancelar = new Button();
            bntEditar = new Button();
            bntGravar = new Button();
            txtSigla = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 241);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 16;
            label2.Text = "Sigla";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 191);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 15;
            label1.Text = "Nome";
            // 
            // bntCancelar
            // 
            bntCancelar.Location = new Point(446, 288);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(75, 23);
            bntCancelar.TabIndex = 14;
            bntCancelar.Text = "&Cancelar";
            bntCancelar.UseVisualStyleBackColor = true;
            // 
            // bntEditar
            // 
            bntEditar.Enabled = false;
            bntEditar.Location = new Point(367, 288);
            bntEditar.Name = "bntEditar";
            bntEditar.Size = new Size(75, 23);
            bntEditar.TabIndex = 13;
            bntEditar.Text = "&Editar";
            bntEditar.UseVisualStyleBackColor = true;
            // 
            // bntGravar
            // 
            bntGravar.Location = new Point(286, 288);
            bntGravar.Name = "bntGravar";
            bntGravar.Size = new Size(75, 23);
            bntGravar.TabIndex = 12;
            bntGravar.Text = "&Gravar";
            bntGravar.UseVisualStyleBackColor = true;
            bntGravar.Click += bntGravar_Click;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(284, 259);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(105, 23);
            txtSigla.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(280, 209);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(230, 23);
            txtNome.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Location = new Point(280, 140);
            txtId.Name = "txtId";
            txtId.Size = new Size(58, 23);
            txtId.TabIndex = 9;
            txtId.Visible = false;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bntCancelar);
            Controls.Add(bntEditar);
            Controls.Add(bntGravar);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button bntCancelar;
        private Button bntEditar;
        private Button bntGravar;
        private TextBox txtSigla;
        private TextBox txtNome;
        private TextBox txtId;
    }
}