﻿using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComercialTDSDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmlogin = new();
            this.Hide();
            frmlogin.ShowDialog();
            if (Program.UsuarioLogado.Id > 0)
            {

                tsslUsuarioLogado.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;

            }

            Show();

            // chamda do panel

        }
        private void AssociaPanel(Form form)
        {

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.MaximizeBox = true;
            form.AutoSize = true;
            form.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(form);
            form.Show();
            pnlCentral.Visible = true;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void trocarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmlogin = new();
            frmlogin.bntCancelar.Text = "&Voltar";
            frmlogin.ShowDialog();
            tsslUsuarioLogado.Text = Program.UsuarioLogado.Nome + "-" + Program.UsuarioLogado.Nivel.Nome;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadatroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmCliente());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmNivel frmnivel = new();
            frmnivel.MdiParent = this;
            frmnivel.Show();
        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmProduto());


        }

        private void pnlCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmProdutoListar());
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmCategoria());
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmPedido());
        }
    }
}
