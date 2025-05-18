namespace ComercialTDSDesk
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            menuStrip1 = new MenuStrip();
            operaçãoToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem3 = new ToolStripMenuItem();
            cadatroToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem1 = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            listarToolStripMenuItem2 = new ToolStripMenuItem();
            movimentoToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            terminarToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem1 = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();
            terminalToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem1 = new ToolStripMenuItem();
            consultarToolStripMenuItem2 = new ToolStripMenuItem();
            emitirNotaToolStripMenuItem = new ToolStripMenuItem();
            confguraçãoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            tsslUsuarioLogado = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            trocarDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            pnlCentral = new Panel();
            menuStrip1.SuspendLayout();
            tsslUsuarioLogado.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { operaçãoToolStripMenuItem, cadatroToolStripMenuItem, movimentoToolStripMenuItem, confguraçãoToolStripMenuItem, sairToolStripMenuItem, sairToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // operaçãoToolStripMenuItem
            // 
            operaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidosToolStripMenuItem });
            operaçãoToolStripMenuItem.Name = "operaçãoToolStripMenuItem";
            operaçãoToolStripMenuItem.Size = new Size(70, 20);
            operaçãoToolStripMenuItem.Text = "&Operação";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, consultarToolStripMenuItem, listarToolStripMenuItem3 });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(116, 22);
            pedidosToolStripMenuItem.Text = "&Pedidos";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(128, 22);
            novoToolStripMenuItem.Text = "&Novo";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(128, 22);
            consultarToolStripMenuItem.Text = "&Consultar ";
            // 
            // listarToolStripMenuItem3
            // 
            listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            listarToolStripMenuItem3.Size = new Size(128, 22);
            listarToolStripMenuItem3.Text = "&Listar";
            // 
            // cadatroToolStripMenuItem
            // 
            cadatroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, produtosToolStripMenuItem, categoriasToolStripMenuItem, fornecedoresToolStripMenuItem, usuariosToolStripMenuItem });
            cadatroToolStripMenuItem.Name = "cadatroToolStripMenuItem";
            cadatroToolStripMenuItem.Size = new Size(61, 20);
            cadatroToolStripMenuItem.Text = "&Cadatro";
            cadatroToolStripMenuItem.Click += cadatroToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(180, 22);
            clienteToolStripMenuItem.Text = "&Clientes";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem, listarToolStripMenuItem, fornecedorToolStripMenuItem, categoriaToolStripMenuItem, estoqueToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(180, 22);
            produtosToolStripMenuItem.Text = "&Produtos";
            // 
            // incluirToolStripMenuItem
            // 
            incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            incluirToolStripMenuItem.Size = new Size(134, 22);
            incluirToolStripMenuItem.Text = "&Incluir";
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(134, 22);
            listarToolStripMenuItem.Text = "&Listar";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(134, 22);
            fornecedorToolStripMenuItem.Text = "&Fornecedor";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(134, 22);
            categoriaToolStripMenuItem.Text = "&Categoria";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(134, 22);
            estoqueToolStripMenuItem.Text = "&Estoque";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(180, 22);
            categoriasToolStripMenuItem.Text = "&Categorias";
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(180, 22);
            fornecedoresToolStripMenuItem.Text = "&Fornecedores";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem1, listarToolStripMenuItem1, listarToolStripMenuItem2 });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(180, 22);
            usuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // incluirToolStripMenuItem1
            // 
            incluirToolStripMenuItem1.Name = "incluirToolStripMenuItem1";
            incluirToolStripMenuItem1.Size = new Size(180, 22);
            incluirToolStripMenuItem1.Text = "&Incluir";
            incluirToolStripMenuItem1.Click += incluirToolStripMenuItem1_Click;
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(180, 22);
            listarToolStripMenuItem1.Text = "&Niveis";
            listarToolStripMenuItem1.Click += listarToolStripMenuItem1_Click;
            // 
            // listarToolStripMenuItem2
            // 
            listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            listarToolStripMenuItem2.Size = new Size(180, 22);
            listarToolStripMenuItem2.Text = "&Listas";
            // 
            // movimentoToolStripMenuItem
            // 
            movimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caixaToolStripMenuItem, terminalToolStripMenuItem, vendasToolStripMenuItem, vendasToolStripMenuItem1 });
            movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            movimentoToolStripMenuItem.Size = new Size(81, 20);
            movimentoToolStripMenuItem.Text = "&Movimento";
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, terminarToolStripMenuItem, consultarToolStripMenuItem1, relatorioToolStripMenuItem });
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(119, 22);
            caixaToolStripMenuItem.Text = "&Caixa";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(123, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // terminarToolStripMenuItem
            // 
            terminarToolStripMenuItem.Name = "terminarToolStripMenuItem";
            terminarToolStripMenuItem.Size = new Size(123, 22);
            terminarToolStripMenuItem.Text = "&terminar";
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(123, 22);
            consultarToolStripMenuItem1.Text = "&consultar";
            // 
            // relatorioToolStripMenuItem
            // 
            relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            relatorioToolStripMenuItem.Size = new Size(123, 22);
            relatorioToolStripMenuItem.Text = "&Relatório";
            // 
            // terminalToolStripMenuItem
            // 
            terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            terminalToolStripMenuItem.Size = new Size(119, 22);
            terminalToolStripMenuItem.Text = "&Terminal";
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(119, 22);
            vendasToolStripMenuItem.Text = "&Vendas ";
            // 
            // vendasToolStripMenuItem1
            // 
            vendasToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem2, emitirNotaToolStripMenuItem });
            vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            vendasToolStripMenuItem1.Size = new Size(119, 22);
            vendasToolStripMenuItem1.Text = "&Vendas ";
            // 
            // consultarToolStripMenuItem2
            // 
            consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            consultarToolStripMenuItem2.Size = new Size(134, 22);
            consultarToolStripMenuItem2.Text = "&Consultar";
            // 
            // emitirNotaToolStripMenuItem
            // 
            emitirNotaToolStripMenuItem.Name = "emitirNotaToolStripMenuItem";
            emitirNotaToolStripMenuItem.Size = new Size(134, 22);
            emitirNotaToolStripMenuItem.Text = "&Emitir Nota";
            // 
            // confguraçãoToolStripMenuItem
            // 
            confguraçãoToolStripMenuItem.Name = "confguraçãoToolStripMenuItem";
            confguraçãoToolStripMenuItem.Size = new Size(88, 20);
            confguraçãoToolStripMenuItem.Text = "Con&fguração";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(71, 20);
            sairToolStripMenuItem.Text = "&Relatórios";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(37, 20);
            sairToolStripMenuItem1.Text = "&sair";
            // 
            // tsslUsuarioLogado
            // 
            tsslUsuarioLogado.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripDropDownButton1 });
            tsslUsuarioLogado.Location = new Point(0, 428);
            tsslUsuarioLogado.Name = "tsslUsuarioLogado";
            tsslUsuarioLogado.Size = new Size(800, 22);
            tsslUsuarioLogado.TabIndex = 4;
            tsslUsuarioLogado.Text = "-";
            tsslUsuarioLogado.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(12, 17);
            toolStripStatusLabel1.Text = "-";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, perfilToolStripMenuItem, trocarDeUsuarioToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 20);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(165, 22);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(165, 22);
            perfilToolStripMenuItem.Text = "Perfil";
            // 
            // trocarDeUsuarioToolStripMenuItem
            // 
            trocarDeUsuarioToolStripMenuItem.Name = "trocarDeUsuarioToolStripMenuItem";
            trocarDeUsuarioToolStripMenuItem.Size = new Size(165, 22);
            trocarDeUsuarioToolStripMenuItem.Text = "Trocar de Usuario";
            trocarDeUsuarioToolStripMenuItem.Click += trocarDeUsuarioToolStripMenuItem_Click;
            // 
            // pnlCentral
            // 
            pnlCentral.Location = new Point(59, 49);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(664, 367);
            pnlCentral.TabIndex = 6;
            pnlCentral.Visible = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCentral);
            Controls.Add(tsslUsuarioLogado);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Sistema Comercial TDS T01";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tsslUsuarioLogado.ResumeLayout(false);
            tsslUsuarioLogado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private StatusStrip tsslUsuarioLogado;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem trocarDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem cadatroToolStripMenuItem;
        private ToolStripMenuItem operaçãoToolStripMenuItem;
        private ToolStripMenuItem movimentoToolStripMenuItem;
        private ToolStripMenuItem confguraçãoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem incluirToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem3;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem incluirToolStripMenuItem1;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem listarToolStripMenuItem2;
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem terminarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem1;
        private ToolStripMenuItem relatorioToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripMenuItem terminalToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem1;
        private ToolStripMenuItem consultarToolStripMenuItem2;
        private ToolStripMenuItem emitirNotaToolStripMenuItem;
        private Panel pnlCentral;
    }
}