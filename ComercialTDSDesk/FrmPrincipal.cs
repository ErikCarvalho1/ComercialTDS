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

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmNivel frmnivel = new();
            frmnivel.MdiParent = this; // Corrigido: removido os parênteses
            frmnivel.Show();
        }
    }
}
