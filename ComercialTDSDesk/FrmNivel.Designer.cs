﻿namespace ComercialTDSDesk
{
    partial class FrmNivel
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
            txtId = new TextBox();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            bntGravar = new Button();
            bntEditar = new Button();
            bntCancelar = new Button();
            dgvNiveis = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnSIgla = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNiveis).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(57, 273);
            txtId.Name = "txtId";
            txtId.Size = new Size(58, 23);
            txtId.TabIndex = 0;
            txtId.Visible = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(51, 123);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(230, 23);
            txtNome.TabIndex = 1;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(55, 173);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(105, 23);
            txtSigla.TabIndex = 2;
            // 
            // bntGravar
            // 
            bntGravar.Location = new Point(57, 202);
            bntGravar.Name = "bntGravar";
            bntGravar.Size = new Size(73, 23);
            bntGravar.TabIndex = 3;
            bntGravar.Text = "&Gravar";
            bntGravar.UseVisualStyleBackColor = true;
            bntGravar.Click += bntGravar_Click;
            // 
            // bntEditar
            // 
            bntEditar.Enabled = false;
            bntEditar.Location = new Point(136, 202);
            bntEditar.Name = "bntEditar";
            bntEditar.Size = new Size(75, 23);
            bntEditar.TabIndex = 4;
            bntEditar.Text = "&Editar";
            bntEditar.UseVisualStyleBackColor = true;
            bntEditar.Click += bntEditar_Click;
            // 
            // bntCancelar
            // 
            bntCancelar.Location = new Point(217, 202);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(75, 23);
            bntCancelar.TabIndex = 5;
            bntCancelar.Text = "&Cancelar";
            bntCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvNiveis
            // 
            dgvNiveis.AllowUserToAddRows = false;
            dgvNiveis.AllowUserToDeleteRows = false;
            dgvNiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNiveis.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnSIgla });
            dgvNiveis.Location = new Point(313, 105);
            dgvNiveis.Name = "dgvNiveis";
            dgvNiveis.ReadOnly = true;
            dgvNiveis.RowHeadersVisible = false;
            dgvNiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNiveis.Size = new Size(283, 140);
            dgvNiveis.TabIndex = 6;
            dgvNiveis.CellContentClick += dgvNiveis_CellContentClick_1;
            dgvNiveis.CellContentDoubleClick += dgvNiveis_CellContentClick_1;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Visible = false;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnSIgla
            // 
            clnSIgla.HeaderText = "Sigla";
            clnSIgla.Name = "clnSIgla";
            clnSIgla.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 105);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 155);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "Sigla";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(241, 35);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 9;
            label3.Text = "Cadastro de Nivel";
            label3.Click += label3_Click;
            // 
            // FrmNivel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 328);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvNiveis);
            Controls.Add(bntCancelar);
            Controls.Add(bntEditar);
            Controls.Add(bntGravar);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "FrmNivel";
            Text = "Cadastro de Nivel";
            Load += FrmNivel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNiveis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtSigla;
        private Button bntGravar;
        private Button bntEditar;
        private Button bntCancelar;
        private DataGridView dgvNiveis;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnSIgla;
        private Label label3;
    }
}