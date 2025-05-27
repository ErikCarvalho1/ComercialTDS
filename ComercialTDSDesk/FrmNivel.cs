using ComercialTDSClass;
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
    public partial class FrmNivel : Form
    {
        public FrmNivel()
        {
            InitializeComponent();
        }

        private void bntGravar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                if (txtNome.Text != string.Empty && txtSigla.Text != string.Empty)
                {
                    Nivel nivel = new(txtNome.Text, txtSigla.Text);
                    nivel.Inserir();
                    if (nivel.Id > 0)
                    {
                        MessageBox.Show($"Nível cadastrado com sucesso");
                        //btnGravar.Enabled = false;
                    }
                }
                CarregaGrid();
                LimpaControles();
            }
            else
            {
                Nivel nivel = new(int.Parse(txtId.Text), txtNome.Text, txtSigla.Text);
                if (nivel.Atualizar())
                {
                    MessageBox.Show("Nível atualizado com sucesso!");
                    //btnGravar.Enabled = false;

                }
            }

        }
        private void CarregaGrid()
        {
            var Lista = Nivel.ObterLista();
            int linha = 0;
            dgvNiveis.Rows.Clear();
            foreach (var item in Lista)
            {
                dgvNiveis.Rows.Add();
                dgvNiveis.Rows[linha].Cells[0].Value = item.Id;
                dgvNiveis.Rows[linha].Cells[1].Value = item.Nome;
                dgvNiveis.Rows[linha].Cells[2].Value = item.Sigla;
                linha++;
            }
        }

        public void LimpaControles()
        {
            txtId.Clear();
            txtNome.Clear();
            txtSigla.Clear();

        }
        private void FrmNivel_Load(object sender, EventArgs e)
        {
            CarregaGrid();

            //var niveis = Nivel.ObterLista();
            //int linha = 0;
            //dgvNiveis.Rows.Clear();
            //foreach (var nivel in niveis)
            //{
            //    dgvNiveis.Rows.Add();
            //    dgvNiveis.Rows[linha].Cells[0].Value = nivel.Id;
            //    dgvNiveis.Rows[linha].Cells[1].Value = nivel.Nome;
            //    dgvNiveis.Rows[linha].Cells[2].Value = nivel.Sigla;
            //    linha++;
            //}

        }

        private void dgvNiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNiveis_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // recuperando o indice da linha do gride 
            int linha = dgvNiveis.CurrentRow.Index;
            // recuperando o id do nivel na coluna, oculda, ID (0)
            int id = Convert.ToInt32(dgvNiveis.Rows[linha].Cells[0].Value);
            //obter  o objeto nivel
            var nivel = Nivel.ObterPorId(id);
            //Atribuindo os dados aos controles
            txtId.Text = nivel.Id.ToString();
            txtNome.Text = nivel.Nome;
            txtSigla.Text = nivel.Sigla;
            txtNome.ReadOnly = true;
            txtSigla.ReadOnly = true;
            bntEditar.Enabled = true;

            // MessageBox.Show($"{nivel.Id} {nivel.Nome} {nivel.Sigla}");

        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
            txtSigla.ReadOnly = false;
            bntEditar.Enabled = false;
            bntEditar.Enabled = true;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
