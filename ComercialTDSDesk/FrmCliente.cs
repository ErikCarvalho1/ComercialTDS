using ComercialTDSClass;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComercialTDSDesk
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void bntGravar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                if (txtNome.Text != string.Empty && txtCpf.Text != string.Empty && txtTelefone.Text != string.Empty && txtEmail.Text != string.Empty
                    && txtTelefone.Text != string.Empty &&  txtCep.Text != string.Empty && txtLogadouro.Text != string.Empty &&
                    txtNumero.Text != string.Empty && txtComplemento.Text != string.Empty && txtBairro.Text != string.Empty && txtCidade.Text != string.Empty && txtUf.Text
                    != string.Empty && txtTipoEnderoco.Text != string.Empty)
                {
                    Cliente cliente = new(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, DateTime.Parse(dateCliente.Text));
                    Endereco endereco = new( txtCep.Text, txtLogadouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text,
                       txtUf.Text, txtTipoEnderoco.Text );
                    endereco.Inserir();

                    cliente.Inserir();
                    if (cliente.Id > 0  && endereco.ClienteId > 0)
                    {
                        MessageBox.Show($"Cliente cadastrado com sucesso");
                        //btnGravar.Enabled = false;
                    }
                }
            }
            else
            {
                Cliente cliente = new(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, DateTime.Parse(dateCliente.Text));
                if (cliente.Atualizar())
                {
                    MessageBox.Show("Cliente atualizado com sucesso!");
                    //btnGravar.Enabled = false;
                }
            }

            //ClienteId = clienteId;
            //Cep = cep;
            //Logradouro = logradouro;
            //Numero = numero;
            //Complemento = complemento;
            //Bairro = bairro;
            //Cidade = cidade;
            //Uf = uf;
            //TipoEndereco = tipoEndereco;

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
    }

}
