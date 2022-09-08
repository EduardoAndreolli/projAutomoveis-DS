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
        public frmcaminhao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAno.Clear();
            txtAuto.Clear();
            txtCapCarga.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtModel.Clear();
            txtMotor.Clear();
            txtPeso.Clear();
            txtPlaca.Clear();
            txtTpCabine.Clear();
            txtTpCarga.Clear();

            txtModel.Focus();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}
