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

        Caminhao caminhao; // definindo 'caminhao' como um objeto do tipo 'Caminhao'

        public frmcaminhao()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            // Instancionando o objeto 'caminhao' com os valores digitados nas txtBox do forms
            caminhao = new Caminhao(txtModel.Text, txtPlaca.Text, txtCor.Text, txtTpCarga.Text, (Convert.ToInt32(txtAno.Text)),
            (Convert.ToDouble(txtCapCarga.Text)), txtChassi.Text, txtBau.Text );

            // Limpando os campos 
            txtAno.Clear();
            txtAno.Clear();
            txtCapCarga.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtModel.Clear();
            txtPlaca.Clear();
            txtTpCarga.Clear();
            txtBau.Clear();

            txtModel.Focus();


            // Exibindo uma mensagem caso o caminhão seja cadastrado com sucesso
            MessageBox.Show("Caminhão cadastrado com sucesso.");
            

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            // Exibindo uma mensagem com os dados cadastrados
            MessageBox.Show(caminhao.MostrarDados());
        }

        // Botão voltar definido
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        // Botão limpar definido 
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAno.Clear();
            txtAno.Clear();
            txtCapCarga.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtModel.Clear();
            txtPlaca.Clear();
            txtTpCarga.Clear();
            txtBau.Clear();

            txtModel.Focus();
        }
    }
}
