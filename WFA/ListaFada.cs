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
            DialogResult result = MessageBox.Show("Você realmente deseja cancelar o cadastro ?", "AVISO",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LimparCampos();
                tabControl1.SelectedIndex = 0;
            }
        }

        private void LimparCampos()
        {
            txtCadastroRapidoNome01.Text = "";           
            cbCadastroRapidoCor01.SelectedIndex = -1;
            txtCadastroRapidoNome02.Text = "";
            txtCadastroRapidoFamilia02.Text = "";
            cbCadastroRapidoCor02.SelectedIndex = -1;
            txtNome.Text = "";
            txtTamanhoAsa.Text = "";
            txtFamilia.Text = "";
            txtTamanhoAsa.Text = "";
            cbElemento.SelectedIndex = -1;
            cbCor.SelectedIndex = -1;
            cbCorAsa.SelectedIndex = -1;
            ckbFazBarulho.Checked = false;
            ckbMulher.Checked = false;            
            ckbAsaQuebrada.Checked = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome deve ser preenchido");
                return;
            }


            try
            {
                Convert.ToDouble(txtTamanhoAsa.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Digite um tamanho para Asa");
                return;
            }


            if (txtFamilia.Text == "")
            {
                MessageBox.Show("Familia deve ser preenchido");
                return;
            }



            if (cbElemento.SelectedItem == null)
            {
                MessageBox.Show("Selecione um elemento");
                return;
            }


            if (cbCor.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma Cor");
                return;
            }


            if (cbCorAsa.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma Cor para Asa");
                return;
            }

            if (ckbMulher.Checked == true)
            {
                
               

            try
            {
                Fada fada = new Fada()
                {
                    Nome = txtNome.Text,
                    Familia = txtFamilia.Text,
                    Cor = cbCor.SelectedItem.ToString(),
                    CorAsa = cbCorAsa.SelectedItem.ToString(),
                    Elemento = cbElemento.SelectedItem.ToString(),
                    Mulher = ckbMulher.Checked,
                    FazBarulho = ckbFazBarulho.Checked,
                    AsaQuebrada = ckbAsaQuebrada.Checked,
                    TamanhoAsa = Convert.ToDouble(txtTamanhoAsa.Text),

                };
                if (nomeAntigo == "")
                {
                    fadas.Add(fada);
                    MessageBox.Show("Cadastrado com Sucesso");
                    AdicionarFadaNaTabela(fada);

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
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            } 
        }

        private void EditarFadaNaTabela(Fada fada, int linha)
        {
            dataGridView1.Rows[linha].Cells[0].Value = fada.Nome;
            dataGridView1.Rows[linha].Cells[1].Value = fada.Familia;
            dataGridView1.Rows[linha].Cells[2].Value = fada.Cor;
            dataGridView1.Rows[linha].Cells[3].Value = fada.Elemento;
            dataGridView1.Rows[linha].Cells[4].Value = fada.Mulher;
        }

        private void AdicionarFadaNaTabela(Fada fada)
        {
            dataGridView1.Rows.Add(new Object[]{
                fada.Nome, fada.Familia, fada.Cor, fada.Elemento, fada.Mulher
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
            DialogResult resultado = MessageBox.Show("Deseja Realmente apagar o cadastro " + nome + " ?", "AVISO",
                MessageBoxButtons.YesNo);

          
                if (resultado == DialogResult.Yes)
                {
                    ApagarFada();
                }
                else
                {
                    MessageBox.Show(nome + " Não Apagado");
                }            
        }

        private void ApagarFada()
        {
            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            MessageBox.Show(nome + " Apagado com Sucesso");
        }

       
        private void btnCadastroRapido01_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnCadastroRapido02_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void btnSalvarRapido01_Click(object sender, EventArgs e)
        {
            if (txtCadastroRapidoNome01.Text == "")
            {
                MessageBox.Show("Nome deve ser preenchido");
                return;
            }


            if (cbCadastroRapidoCor01.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma Cor");
                return;
            }

            Fada fada = new Fada(txtCadastroRapidoNome01.Text, cbCadastroRapidoCor01.SelectedItem.ToString(),
                ckbCadastroRapidoMulher.Checked);
            if (nomeAntigo == "")
            {
                fadas.Add(fada);
                MessageBox.Show("Cadastrado com Sucesso");
                AdicionarFadaNaTabela(fada);

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

        private void btnSalvarRapido02_Click(object sender, EventArgs e)
        {
           
                if (txtCadastroRapidoNome02.Text == "")
                {
                   MessageBox.Show("Nome deve ser preenchido");
                   return;
                }
           
           
                if (txtCadastroRapidoFamilia02.Text == "")
                {
                    MessageBox.Show("Familia deve ser preenchido");
                    return;
                    
                }
            
            try
            {
                if (cbCadastroRapidoCor02.SelectedItem == null)
                {
                    MessageBox.Show("Selecione uma Cor");
                    return;

                }

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            Fada fada = new Fada(txtCadastroRapidoNome02.Text, txtCadastroRapidoFamilia02.Text,
                cbCadastroRapidoCor02.SelectedItem.ToString());
           
            if (nomeAntigo == "")
            {
                fadas.Add(fada);
                MessageBox.Show("Cadastrado com Sucesso");
                AdicionarFadaNaTabela(fada);

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

        private void btnCancelarCadastrorapido01_Click(object sender, EventArgs e)
        {            
            DialogResult result = MessageBox.Show("Você realmente deseja cancelar o cadastro ?", "AVISO",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LimparCampos();
                tabControl1.SelectedIndex = 0;
            }
        }

        private void btnCancelarCadastrorapido02_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja cancelar o cadastro ?", "AVISO",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LimparCampos();
                tabControl1.SelectedIndex = 0;
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
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

            foreach (Fada fada in fadas)
            {
                if (fada.Nome == nome)
                {
                    
                    txtNome.Text = fada.Nome;
                    txtFamilia.Text = fada.Familia;
                    cbCor.Text = fada.Cor;
                    cbCorAsa.Text = fada.CorAsa;
                    cbElemento.Text = fada.Elemento;
                    ckbMulher.Checked = true;
                    ckbFazBarulho.Checked = true;
                    ckbAsaQuebrada.Checked = true;
                    txtTamanhoAsa.Text = Convert.ToString(fada.TamanhoAsa);
                    nomeAntigo = fada.Nome;
                    tabControl1.SelectedIndex = 1;
                    break;
                }
            }
            
        }

       
    }

}
