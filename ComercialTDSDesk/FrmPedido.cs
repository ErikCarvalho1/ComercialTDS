using ComercialTDSClass;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialTDSDesk
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {

        }

        private void FrmPedido_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPedido_Load_2(object sender, EventArgs e)
        {
            txtUsuario.Text = $"{Program.UsuarioLogado.Id} - {Program.UsuarioLogado.Nome}";
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length > 4)
            {
                var cliente = Cliente.ObterPorId(int.Parse(txtIdCliente.Text));
                if (cliente.Id > 0)
                {
                    txtNomeCliente.Text = cliente.Nome;
                }
            }
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(Program.UsuarioLogado, Cliente.ObterPorId(int.Parse(txtIdCliente.Text)));
            pedido.Inserir();
            if (pedido.Id > 0)
            {
                txtIdPedido.Text = pedido.Id.ToString();
                grbIndentificacao.Enabled = false;
                grbItens.Enabled = true;
            }
        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {
            if (txtCodBar.Text.Length > 6)
            {
                var produto = Produto.ObterPorCodBar(txtCodBar.Text);
                if (produto.Id == 0)
                {
                    produto = Produto.ObterPorId(int.Parse(txtCodBar.Text));
                }
                txtIdProd.Text = produto.Id.ToString();
                txtDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.ValorUnit.ToString("R$##.00");
                label4.Text = $"R${produto.ValorUnit * produto.ClasseDesconto}";
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemDePedido itempedido = new(
                int.Parse(txtIdPedido.Text),
                Produto.ObterPorId(int.Parse(txtIdProd.Text)),
                double.Parse(txtDescontoItem.Text),
                double.Parse(txtDescontoItem.Text)
                );
            itempedido.inserir();
            if (itempedido.Id > 0)
            {
                CarregarItens();
            }

        }
        private void CarregarItens(int pedidoId)
        {
            var itens = ItemDePedido.ObterlistaPorPedidoId(pedidoId);
            dgvItensPedido.Rows.Clear();
            int linha = 0;
            double subTotal = 0;
            double desconto = 0;

            foreach (var item in itens)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[linha].Cells[0].Value = $"#{(linha + 1).ToString().PadLeft(2, '0')}";
                dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBarras;
                dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit;
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade;
                dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto;
                desconto = +item.Desconto;
                double totalItem = item.ValorUnit * item.Quantidade - item.Desconto;
                dgvItensPedido.Rows[linha].Cells[6].Value = totalItem;
                linha++;
                txtSubTotalItens.Text - subTotal.ToString();
                txtSubTotal.Text = subTotal.ToString();

            }
        }

        private void txtIdPedido_KeyDown(object sender, KeyEventArgs e)
        {
            //verificar se a tecla enter doi pressionada
            if (e.KeyCode == Keys.Enter)
            {
                var pedido = Pedido.ObterPorId(int.Parse(txtIdPedido.Text));
                if (pedido.Id > 0)
                {
                    if (pedido.Status"A")
                    {
                        grbIndentificacao.Enabled = false;
                        txtNomeCliente.Text = $"{pedido.Cliente.Id} - {pedido.Cliente.Nome}";
                        txtUsuario.Text = $"{pedido.Usuario.Id} - {pedido.Usuario.Nome}";
                        grbItens.Enabled = true;

                    }
                }
            }
        }

        private void txtDescontoPedido_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Pedido pedido = Pedido.ObterPorId(int.Parse(txtIdPedido.Text));
            pedido.Desconto = double.Parse(txtDescontoPedido.Text);
            pedido.Status = "F";
             if (pedido.Atualizar())
            {
                MessageBox.Show($"Pedido {pedido.Id} foi fechado com sucesso. \n");
                Controls.Clear();
            }
            

            
        }
    }
}
