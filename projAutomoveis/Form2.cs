﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace projAutomoveis
{

    public partial class frmcaminhao : Form
    {

        Caminhao caminhao;
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
            txtCapCarga.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtModel.Clear();
            txtPlaca.Clear();
            txtTpCarga.Clear();
            rdbNo.Checked = false;
            rdbYes.Checked = false;

            txtModel.Focus();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            bool bau;

            bau = false;
            if (rdbNo.Checked)
            {
                bau = false;
            }
            else if (rdbYes.Checked)
            {
                bau = true;
            }

            caminhao = new Caminhao(txtModel.Text, txtPlaca.Text, txtCor.Text, txtTpCarga.Text, (Convert.ToInt32(txtAno.Text)),
            (Convert.ToDouble(txtCapCarga.Text)), txtChassi.Text, (Convert.ToBoolean(bau)));

            txtAno.Clear();
            txtTpCarga.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtModel.Clear();
            txtPlaca.Clear();
            txtCapCarga.Clear();
            rdbNo.Checked = false;
            rdbYes.Checked = false;

            MessageBox.Show("Caminhão cadastrado com sucesso.");

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.MostrarDados());
        }
    }
}
