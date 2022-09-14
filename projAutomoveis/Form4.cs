using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projAutomoveis
{
    public partial class frmcaminhao : Form
    {

        Caminhao caminhao;

        public frmcaminhao()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            Caminhao = new caminhao(txtModel.Text, txtPlaca.Text, txtCor.Text, txtTpCarga.Text, (Convert.ToInt32(txtAno.Text)),
            (Convert.ToDouble(txtCapCarga.Text)), txtChassi.Text, txtBau.Text );

            txtAno.Clear();

            MessageBox.Show("Caminhão cadastrado com sucesso.");
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.MostrarDados());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}
