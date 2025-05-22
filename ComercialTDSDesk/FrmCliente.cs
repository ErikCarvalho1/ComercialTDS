using ComercialTDSClass;
using MySqlX.XDevAPI;
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
                if (txtNome.Text != string.Empty && txtCpf.Text != string.Empty && txtTelefone.Text != string.Empty && txtEmail.Text != string.Empty && txtTelefone.Text != string.Empty)
                {
                    Cliente cliente = new Cliente
                    {
                        Nome = txtNome.Text,
                        Cpf = txtCpf.Text,
                        Telefone = txtTelefone.Text,
                        Email = txtEmail.Text,
                        DataNascimento = DateTime.Parse(dateCliente.Text)
                    };
                    cliente.Inserir();
                    if (cliente.Id > 0) 
                    {
                        MessageBox.Show($"Nível cadastrado com sucesso");
                        //btnGravar.Enabled = false;
                    }
                }
            }
            else
            {
                Cliente cliente = new( txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, DateTime.Parse(dateCliente.Text));
                if (cliente.Atualizar())
                {
                    MessageBox.Show("Nível atualizado com sucesso!");
                    //btnGravar.Enabled = false;
                }
            }
        }
    }
    }
}
