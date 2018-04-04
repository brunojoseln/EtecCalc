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
        double valor1 = 0, memAux,porc,memoria = 0;
        String operador;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }


        //Números
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

        private void btn0_Click(object sender, EventArgs e)
        {
            if (countVisor != 9)
            {
                txtVisor.Text += '0';
                countVisor++;
            }
        }


        //4 operações


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
                btnRaiz.Enabled = false;
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
                btnRaiz.Enabled = false;
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
                porc = valor1;
                //a variavel porc recebe o valor1 para o usuario poder calcular a porcentagem

                btnSomar.Enabled = false;
                btnSub.Enabled = false;
                btnMult.Enabled = false;
                btnDiv.Enabled = false;
                btnRaiz.Enabled = false;
                btnPorcen.Enabled = true;
                //o btnPorc  foi habilitado para permitir que o usuário calcule a porcentagem
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
                btnRaiz.Enabled = false;

            }
        }


        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "" )
            {
                memAux =Convert.ToDouble(txtVisor.Text);
                switch (operador)
                {
                    case "+":
                        valor1 += memAux;                        
                        txtVisor.Text =Convert.ToString(valor1);
                        valor1 = 0;
                        break;

                    case "-":
                        valor1 -= memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;
                    case "*":
                        valor1 *= memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;
                    case "/":
                        if (valor1 != 0 && memAux !=0)
                        {
                            valor1 = valor1 / memAux;
                            txtVisor.Text = Convert.ToString(valor1);
                            valor1 = 0;
                        }
                        else
                        {
                            MessageBox.Show("Impossivel realizar divisão por 0!","Erro");
                        }
                        break;

                }

                countVisor = 0;

                btnSomar.Enabled = true;
                btnSub.Enabled = true;
                btnMult.Enabled = true;
                btnDiv.Enabled = true;
                btnRaiz.Enabled = true;
            }
        }

        private void btnPorcen_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                memAux = Convert.ToDouble(txtVisor.Text);
                txtVisor.Clear();
                countVisor = 0;
                valor1 = (porc * memAux)/100 ;
                txtVisor.Text = Convert.ToString(valor1);

                valor1 = memAux = countVisor = 0;
                btnSomar.Enabled = true;
                btnSub.Enabled = true;
                btnMult.Enabled = true;
                btnDiv.Enabled = true;
                btnRaiz.Enabled = true;
            }

        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            valor1 = memAux = countVisor = 0;

            btnSomar.Enabled =true;
            btnSub.Enabled =true;
            btnMult.Enabled =true;
            btnDiv.Enabled =true;
            btnRaiz.Enabled = true;
            btnPorcen.Enabled = false;

        }

        //Pergunta ao usuário se ele realmente quer sair
        private void frmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar ?","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Soma valor a memoria
        private void btnSomaMemoria_Click(object sender, EventArgs e)
        {
            lblmemoria.Visible = true;
            if (memoria != 0)
            {
                memoria = memoria + Convert.ToDouble(txtVisor.Text);
            }
            else
            {
                memoria = Convert.ToDouble(txtVisor.Text);
            }
            

        }

        /*Subtrai o valor na memoria
         * 
         * Fiz a memsma coisa que o primeiro a diferença é que depois de realizada a soma o valor da
         * memoria é multiplicado por -1
         * */
        private void btnSubMemoria_Click(object sender, EventArgs e)
        {
            lblmemoria.Visible = true;
            if (memoria != 0)
            {
                memoria = memoria + Convert.ToDouble(txtVisor.Text);
                if (memoria > 0)
                {
                    memoria = memoria * (-1);
                }
                
            }
            else
            {
                memoria = Convert.ToDouble(txtVisor.Text);
                memoria = memoria * (-1);
            }

        }

        //limpa a memoria
        private void btrnLimpaMemoria_Click(object sender, EventArgs e)
        {
            memoria = 0;
            lblmemoria.Visible = false;
;        }

        //Exibe o valor da memoria
        private void btnMostrarmemoria_Click(object sender, EventArgs e)
        {
            txtVisor.Text = Convert.ToString(memoria);
            Convert.ToDouble(memoria);
        }



        private void btnSub_Click_1(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);
                operador = "-";
                txtVisor.Clear();
                countVisor = 0;

                btnSomar.Enabled = false;
                btnSub.Enabled = false;
                btnMult.Enabled = false;
                btnDiv.Enabled = false;
                btnRaiz.Enabled = false;
            }
        }


        /*Criei esse evento para o foco não sair do visor, pois quando o usuário clica em um número
         o foco vai para o número e caso o usuário digite no teclado o número não vai aparecer
         pois o KeyDown está está programado no visor */
        private void txtVisor_Leave(object sender, EventArgs e)
        {
            txtVisor.Focus();
        }


        /* Quis incrementar o algoritmo e pesquisando encontrei o evento KeyDown,
         * toda vez que o usuário aperta um numero esse evento faz com que o numero
         * receba um clique assim adicionando ele no visor da calculadora.
         * 
         * Consultei essa página para me auxiliar no código: https://social.msdn.microsoft.com/Forums/pt-BR/6aaef556-ef9b-44d3-ae0b-50ff4d6629ad/calculadora-pelo-teclado?forum=vscsharppt */

        private void txtVisor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                btn1.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                btn2.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                btn3.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                btn4.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                btn5.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                btn6.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                btn7.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8) 
            {
                btn8.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                btn9.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                btn0.PerformClick();
            }

            if (e.KeyCode == Keys.Add)
            {
                btnSomar.PerformClick();
            }

            if (e.KeyCode == Keys.Subtract)
            {
                btnSub.PerformClick();
            }

            if (e.KeyCode == Keys.Multiply)
            {
                btnMult.PerformClick();
            }

            if (e.KeyCode == Keys.Divide)
            {
                btnDiv.PerformClick();
            }

            if (e.KeyCode == Keys.Enter)
            {
                btnIgual.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);
                txtVisor.Text = Math.Sqrt(valor1).ToString();
            }
 
        }

    }
}
