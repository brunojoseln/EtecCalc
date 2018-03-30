using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        //Variaveis globais
        //Declarei e já atribui valor 0 pra váriavel valor1
        int countVisor;
        double valor1 = 0, memAux;
        String operador;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (countVisor !=9)
            {
                txtVisor.Text += '1';
                countVisor++;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (countVisor != 9)
            {
                txtVisor.Text += '2';
                countVisor++;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (countVisor != 9)
            {
                txtVisor.Text += '3';
                countVisor++;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (countVisor != 9)
            {
                txtVisor.Text += '4';
                countVisor++;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (countVisor != 9)
            {
                txtVisor.Text += '5';
                countVisor++;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (countVisor != 9)
            {
                txtVisor.Text += '6';
                countVisor++;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (countVisor != 9)
            {
                txtVisor.Text += '7';
                countVisor++;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (countVisor != 9)
            {
                txtVisor.Text += '8';
                countVisor++;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (countVisor != 9)
            {
                txtVisor.Text += '9';
                countVisor++;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);
                operador = "+";
                txtVisor.Clear();
                countVisor = 0;

                btnSomar.Enabled =false;
                btnSub.Enabled =false;
                btnMult.Enabled =false;
                btnDiv.Enabled =false;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text !="")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);
                operador = "-";
                txtVisor.Clear();
                countVisor = 0;

                btnSomar.Enabled = false;
                btnSub.Enabled = false;
                btnMult.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text !="")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);
                operador = "*";
                txtVisor.Clear();
                countVisor = 0;

                btnSomar.Enabled = false;
                btnSub.Enabled = false;
                btnMult.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text !="")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);
                operador = "/";
                txtVisor.Clear();
                countVisor = 0;

                btnSomar.Enabled = false;
                btnSub.Enabled = false;
                btnMult.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            valor1 = memAux = countVisor = 0;

            btnSomar.Enabled =true;
            btnSub.Enabled =true;
            btnMult.Enabled =true;
            btnDiv.Enabled =true;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (countVisor != 9)
            {
                txtVisor.Text += '0';
                countVisor++;
            }
        }
    }
}
