namespace ComercialTDSDesk
{
    partial class FrmCliente
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
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            txtTelefone = new TextBox();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            txtLogadouro = new TextBox();
            txtComplemento = new TextBox();
            txtCep = new TextBox();
            txtClienteId = new TextBox();
            id = new Label();
            nome = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtTipoEnderoco = new TextBox();
            txtUf = new TextBox();
            bntGravar = new Button();
            bntEditar = new Button();
            bntCancelar = new Button();
            dateCliente = new DateTimePicker();
            txtCidade = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(130, 354);
            txtId.Name = "txtId";
            txtId.Size = new Size(58, 23);
            txtId.TabIndex = 0;
            txtId.Visible = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(130, 172);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(202, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(251, 216);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(162, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(338, 172);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(75, 23);
            txtCpf.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(130, 216);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(115, 23);
            txtTelefone.TabIndex = 5;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(552, 198);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(158, 23);
            txtNumero.TabIndex = 11;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(552, 245);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(158, 23);
            txtBairro.TabIndex = 10;
            // 
            // txtLogadouro
            // 
            txtLogadouro.Location = new Point(437, 198);
            txtLogadouro.Name = "txtLogadouro";
            txtLogadouro.Size = new Size(109, 23);
            txtLogadouro.TabIndex = 9;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(437, 245);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(109, 23);
            txtComplemento.TabIndex = 8;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(437, 154);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(109, 23);
            txtCep.TabIndex = 7;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(582, 335);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(43, 23);
            txtClienteId.TabIndex = 6;
            txtClienteId.Visible = false;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(98, 357);
            id.Name = "id";
            id.Size = new Size(17, 15);
            id.TabIndex = 12;
            id.Text = "Id";
            id.Visible = false;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(130, 154);
            nome.Name = "nome";
            nome.Size = new Size(40, 15);
            nome.TabIndex = 13;
            nome.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 154);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 14;
            label3.Text = "Cpf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 198);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 15;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 198);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(519, 338);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 18;
            label7.Text = "Cliente Id";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(437, 136);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 19;
            label8.Text = "Cep";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(437, 180);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 20;
            label9.Text = "Logadouro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(552, 180);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 21;
            label10.Text = "Numero ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(437, 227);
            label11.Name = "label11";
            label11.Size = new Size(87, 15);
            label11.TabIndex = 22;
            label11.Text = "Complemento ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(552, 227);
            label12.Name = "label12";
            label12.Size = new Size(38, 15);
            label12.TabIndex = 23;
            label12.Text = "Bairro";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(552, 271);
            label13.Name = "label13";
            label13.Size = new Size(83, 15);
            label13.TabIndex = 27;
            label13.Text = "Tipo Endereço";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(437, 272);
            label14.Name = "label14";
            label14.Size = new Size(19, 15);
            label14.TabIndex = 26;
            label14.Text = "Uf";
            // 
            // txtTipoEnderoco
            // 
            txtTipoEnderoco.Location = new Point(552, 289);
            txtTipoEnderoco.Name = "txtTipoEnderoco";
            txtTipoEnderoco.Size = new Size(158, 23);
            txtTipoEnderoco.TabIndex = 25;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(437, 290);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(109, 23);
            txtUf.TabIndex = 24;
            // 
            // bntGravar
            // 
            bntGravar.Location = new Point(151, 282);
            bntGravar.Name = "bntGravar";
            bntGravar.Size = new Size(75, 36);
            bntGravar.TabIndex = 28;
            bntGravar.Text = "&Gravar";
            bntGravar.UseVisualStyleBackColor = true;
            bntGravar.Click += bntGravar_Click;
            // 
            // bntEditar
            // 
            bntEditar.Location = new Point(227, 282);
            bntEditar.Name = "bntEditar";
            bntEditar.Size = new Size(75, 36);
            bntEditar.TabIndex = 29;
            bntEditar.Text = "&Editar";
            bntEditar.UseVisualStyleBackColor = true;
            bntEditar.Click += bntEditar_Click;
            // 
            // bntCancelar
            // 
            bntCancelar.Location = new Point(308, 282);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(74, 36);
            bntCancelar.TabIndex = 30;
            bntCancelar.Text = "&Cancelar";
            bntCancelar.UseVisualStyleBackColor = true;
            // 
            // dateCliente
            // 
            dateCliente.Location = new Point(130, 245);
            dateCliente.Name = "dateCliente";
            dateCliente.Size = new Size(272, 23);
            dateCliente.TabIndex = 31;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(552, 154);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(158, 23);
            txtCidade.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(552, 136);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 33;
            label1.Text = "Cidade";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_home_30;
            pictureBox1.Location = new Point(452, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 33);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(503, 109);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 35;
            label2.Text = "Endereço";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_user_64;
            pictureBox2.Location = new Point(125, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 64);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(194, 121);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 37;
            label6.Text = "Cliente";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.Highlight;
            label15.Location = new Point(308, 43);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(199, 25);
            label15.TabIndex = 38;
            label15.Text = "Registro de Clientes";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 414);
            Controls.Add(label15);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtCidade);
            Controls.Add(dateCliente);
            Controls.Add(bntCancelar);
            Controls.Add(bntEditar);
            Controls.Add(bntGravar);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(txtTipoEnderoco);
            Controls.Add(txtUf);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nome);
            Controls.Add(id);
            Controls.Add(txtNumero);
            Controls.Add(txtBairro);
            Controls.Add(txtLogadouro);
            Controls.Add(txtComplemento);
            Controls.Add(txtCep);
            Controls.Add(txtClienteId);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private TextBox txtTelefone;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private TextBox txtLogadouro;
        private TextBox txtComplemento;
        private TextBox txtCep;
        private TextBox txtClienteId;
        private Label id;
        private Label nome;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtTipoEnderoco;
        private TextBox txtUf;
        private Button bntGravar;
        private Button bntEditar;
        private Button bntCancelar;
        private DateTimePicker dateCliente;
        private TextBox txtCidade;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label15;
    }
}