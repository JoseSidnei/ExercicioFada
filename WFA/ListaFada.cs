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
            txttamanhoAsa.Text = "";
            txtElemento.Text = "";
            cbFamilia.SelectedIndex = -1;
            cbCor.SelectedIndex = -1;
            cbCorAsa.SelectedIndex = -1;
            ckbFazBarulho.Checked = false;
            ckbMulher.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Fada fada = new Fada(); 
               

            }
            catch
            {

            }
            
        }
    }
}
