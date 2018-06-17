using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class ListaFada : Form
    {
        string nomeAntigo  = string.Empty;
        List<Fada> fadas = new List<Fada>();

        public ListaFada()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtTamanhoAsa.Text = "";
            txtElemento.Text = "";
            txtFamilia.Text = "";
            txtCor.Text = "";
            txtCorAsa.Text = "";
            txtTamanhoAsa.Text = "";
            ckbFazBarulho.Checked = false;
            ckbMulher.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Fada fada = new Fada()
                {
                    Nome = txtNome.Text,
                    Familia = txtFamilia.Text,
                    Cor = txtCor.Text,
                    CorAsa = txtCorAsa.Text,
                    Elemento = txtElemento.Text,
                    Mulher = ckbMulher.Checked,
                    FazBarulho = ckbFazBarulho.Checked,
                    TamanhoAsa = Convert.ToDouble(txtTamanhoAsa.Text)
                };
                if (nomeAntigo == "") 
                {
                    fadas.Add(fada);
                    MessageBox.Show("Cadastrado com Sucesso");
                }
                else
                {
                    int linha = fadas.FindIndex(x => x.Nome == nomeAntigo);
                    fadas[linha] = fada;
                    EditarFadaNaTabela(fada, linha);
                    MessageBox.Show("Alterado com sucesso");
                    nomeAntigo = string.Empty;
                   
                }

                LimparCampos();
                tabControl1.SelectedIndex = 0;


            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
            
        }

        private void EditarFadaNaTabela(Fada fada, int linha)
        {
            dataGridView1.Rows[linha].Cells[0].Value = fada.Nome;
            dataGridView1.Rows[linha].Cells[1].Value = fada.Familia;
            dataGridView1.Rows[linha].Cells[2].Value = fada.Cor;
            dataGridView1.Rows[linha].Cells[3].Value = fada.CorAsa;
            dataGridView1.Rows[linha].Cells[4].Value = fada.TamanhoAsa;
            dataGridView1.Rows[linha].Cells[5].Value = fada.Elemento;
        }

        private void AdicionarFadaNaTabela(Fada fada)
        {
            dataGridView1.Rows.Add(new Object[]{
                fada.Nome, fada.Familia, fada.Cor, fada.Elemento
                });
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma Fada");
                tabControl1.SelectedIndex = 1;
                return;
            }

            if(dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString();

            for (int i = 0; i < fadas.Count; i++)
            {
                Fada fada = fadas[i];
                if (fada.Nome == nome)
                {
                    fadas.RemoveAt(i);
                }
            }

            dataGridView1.Rows.RemoveAt(linhaSelecionada);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma Fada");
                tabControl1.SelectedIndex = 1;
                return;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString();

            foreach(Fada fada in fadas)
            {
                if(fada.Nome == nome)
                {
                    txtNome.Text = fada.Nome;
                    txtFamilia.Text = fada.Familia;
                    txtCor.Text = fada.Cor;
                    txtCorAsa.Text = fada.CorAsa;
                    txtElemento.Text = fada.Elemento;
                    ckbMulher.Checked = true;
                    ckbFazBarulho.Checked = true;
                    txtTamanhoAsa.Text = Convert.ToString(fada.TamanhoAsa);
                }
            }
        }

        private void btnCadastroRapido_Click(object sender, EventArgs e)
        {
            Fada fada = new Fada(txtCadastroRapidoNome.Text, txtCadastroRapidoFamilia.Text, txtCadastroRapidoCor.Text);
        }
    }

}
