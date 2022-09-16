using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projAutomoveis
{
    public partial class frmcarro : Form
    {

        Carro carro; // definindo 'carro' como um objeto do tipo 'Carro'

        public frmcarro()
        {
            InitializeComponent();
        }

        // Botão limpar definido 

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAno.Clear();
            txtBagagem.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtModel.Clear();
            txtPlaca.Clear();
            txtNumPorta.Clear();
            txtTpCarro.Clear();

            txtModel.Focus();

        }

        // Botão voltar definido

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            // Instancionando o objeto 'carro' com os valores digitados nas txtBox do forms
            carro = new Carro(txtModel.Text, txtPlaca.Text, txtCor.Text, txtTpCarro.Text,(Convert.ToInt32(txtAno.Text)),
            (Convert.ToDouble(txtBagagem.Text)), (Convert.ToInt32(txtNumPorta.Text)), txtChassi.Text);

            // Limpando os campos 
            txtAno.Clear();
            txtBagagem.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtModel.Clear();
            txtPlaca.Clear();
            txtNumPorta.Clear();
            txtTpCarro.Clear();

            txtModel.Focus();

            // Exibindo uma mensagem caso o caminhão seja cadastrado com sucesso
            MessageBox.Show("Carro cadastrado com sucesso.");

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            // Exibindo uma mensagem com os dados cadastrados
            MessageBox.Show(carro.MostrarDados());
        }
    }
}
