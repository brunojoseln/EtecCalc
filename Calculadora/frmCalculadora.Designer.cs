namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.btnLimpaMemoria = new System.Windows.Forms.Button();
            this.btnSubMemoria = new System.Windows.Forms.Button();
            this.lblmemoria = new System.Windows.Forms.Label();
            this.btnMostrarmemoria = new System.Windows.Forms.Button();
            this.btnSomaMemoria = new System.Windows.Forms.Button();
            this.btnPorcen = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.Color.Chocolate;
            this.txtVisor.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVisor.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(4, 12);
            this.txtVisor.MaxLength = 13;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(308, 56);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVisor_KeyDown);
            this.txtVisor.Leave += new System.EventHandler(this.txtVisor_Leave);
            // 
            // btnLimpaMemoria
            // 
            this.btnLimpaMemoria.AutoSize = true;
            this.btnLimpaMemoria.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpaMemoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpaMemoria.FlatAppearance.BorderSize = 0;
            this.btnLimpaMemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpaMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaMemoria.Image = global::Calculadora.Properties.Resources.memoryclear;
            this.btnLimpaMemoria.Location = new System.Drawing.Point(80, 77);
            this.btnLimpaMemoria.Name = "btnLimpaMemoria";
            this.btnLimpaMemoria.Size = new System.Drawing.Size(77, 52);
            this.btnLimpaMemoria.TabIndex = 21;
            this.btnLimpaMemoria.UseVisualStyleBackColor = false;
            this.btnLimpaMemoria.Click += new System.EventHandler(this.btrnLimpaMemoria_Click);
            // 
            // btnSubMemoria
            // 
            this.btnSubMemoria.AutoSize = true;
            this.btnSubMemoria.BackColor = System.Drawing.Color.Transparent;
            this.btnSubMemoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubMemoria.FlatAppearance.BorderSize = 0;
            this.btnSubMemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMemoria.Image = global::Calculadora.Properties.Resources.mmenos;
            this.btnSubMemoria.Location = new System.Drawing.Point(157, 78);
            this.btnSubMemoria.Name = "btnSubMemoria";
            this.btnSubMemoria.Size = new System.Drawing.Size(78, 52);
            this.btnSubMemoria.TabIndex = 20;
            this.btnSubMemoria.UseVisualStyleBackColor = false;
            this.btnSubMemoria.Click += new System.EventHandler(this.btnSubMemoria_Click);
            // 
            // lblmemoria
            // 
            this.lblmemoria.AutoSize = true;
            this.lblmemoria.BackColor = System.Drawing.Color.Chocolate;
            this.lblmemoria.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemoria.ForeColor = System.Drawing.Color.White;
            this.lblmemoria.Location = new System.Drawing.Point(291, 16);
            this.lblmemoria.Name = "lblmemoria";
            this.lblmemoria.Size = new System.Drawing.Size(19, 18);
            this.lblmemoria.TabIndex = 22;
            this.lblmemoria.Text = "M";
            this.lblmemoria.Visible = false;
            // 
            // btnMostrarmemoria
            // 
            this.btnMostrarmemoria.AutoSize = true;
            this.btnMostrarmemoria.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarmemoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMostrarmemoria.FlatAppearance.BorderSize = 0;
            this.btnMostrarmemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarmemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarmemoria.Image = global::Calculadora.Properties.Resources.memoryshow;
            this.btnMostrarmemoria.Location = new System.Drawing.Point(234, 79);
            this.btnMostrarmemoria.Name = "btnMostrarmemoria";
            this.btnMostrarmemoria.Size = new System.Drawing.Size(76, 50);
            this.btnMostrarmemoria.TabIndex = 23;
            this.btnMostrarmemoria.UseVisualStyleBackColor = false;
            this.btnMostrarmemoria.Click += new System.EventHandler(this.btnMostrarmemoria_Click);
            // 
            // btnSomaMemoria
            // 
            this.btnSomaMemoria.AutoSize = true;
            this.btnSomaMemoria.BackColor = System.Drawing.Color.Transparent;
            this.btnSomaMemoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSomaMemoria.FlatAppearance.BorderSize = 0;
            this.btnSomaMemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomaMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomaMemoria.Image = ((System.Drawing.Image)(resources.GetObject("btnSomaMemoria.Image")));
            this.btnSomaMemoria.Location = new System.Drawing.Point(4, 78);
            this.btnSomaMemoria.Name = "btnSomaMemoria";
            this.btnSomaMemoria.Size = new System.Drawing.Size(78, 52);
            this.btnSomaMemoria.TabIndex = 19;
            this.btnSomaMemoria.UseVisualStyleBackColor = false;
            this.btnSomaMemoria.Click += new System.EventHandler(this.btnSomaMemoria_Click);
            // 
            // btnPorcen
            // 
            this.btnPorcen.AutoSize = true;
            this.btnPorcen.BackColor = System.Drawing.Color.Transparent;
            this.btnPorcen.Enabled = false;
            this.btnPorcen.FlatAppearance.BorderSize = 0;
            this.btnPorcen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcen.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcen.Image = global::Calculadora.Properties.Resources.porcentagem;
            this.btnPorcen.Location = new System.Drawing.Point(0, 130);
            this.btnPorcen.Name = "btnPorcen";
            this.btnPorcen.Size = new System.Drawing.Size(59, 112);
            this.btnPorcen.TabIndex = 18;
            this.btnPorcen.UseVisualStyleBackColor = false;
            this.btnPorcen.Click += new System.EventHandler(this.btnPorcen_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.AutoSize = true;
            this.btnRaiz.BackColor = System.Drawing.Color.Transparent;
            this.btnRaiz.FlatAppearance.BorderSize = 0;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Image = global::Calculadora.Properties.Resources.raiz;
            this.btnRaiz.Location = new System.Drawing.Point(-1, 242);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(60, 111);
            this.btnRaiz.TabIndex = 17;
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = global::Calculadora.Properties.Resources.limpar;
            this.btnLimpar.Location = new System.Drawing.Point(63, 297);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 58);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.AutoSize = true;
            this.btnIgual.BackColor = System.Drawing.Color.Transparent;
            this.btnIgual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Image = global::Calculadora.Properties.Resources.igual;
            this.btnIgual.Location = new System.Drawing.Point(194, 299);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(57, 56);
            this.btnIgual.TabIndex = 15;
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnMult
            // 
            this.btnMult.AutoSize = true;
            this.btnMult.BackColor = System.Drawing.Color.Transparent;
            this.btnMult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Image = global::Calculadora.Properties.Resources.multiplicacao;
            this.btnMult.Location = new System.Drawing.Point(251, 130);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(58, 60);
            this.btnMult.TabIndex = 14;
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.AutoSize = true;
            this.btnDiv.BackColor = System.Drawing.Color.Transparent;
            this.btnDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Image = global::Calculadora.Properties.Resources.divisao;
            this.btnDiv.Location = new System.Drawing.Point(251, 185);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(57, 60);
            this.btnDiv.TabIndex = 13;
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.AutoSize = true;
            this.btnSomar.BackColor = System.Drawing.Color.Transparent;
            this.btnSomar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSomar.FlatAppearance.BorderSize = 0;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Image = global::Calculadora.Properties.Resources.mais;
            this.btnSomar.Location = new System.Drawing.Point(252, 297);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(57, 58);
            this.btnSomar.TabIndex = 11;
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.BackColor = System.Drawing.Color.Transparent;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Image = global::Calculadora.Properties.Resources.num0;
            this.btn0.Location = new System.Drawing.Point(128, 298);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(58, 57);
            this.btn0.TabIndex = 10;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Image = global::Calculadora.Properties.Resources.num9;
            this.btn9.Location = new System.Drawing.Point(192, 241);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(58, 59);
            this.btn9.TabIndex = 9;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Image = global::Calculadora.Properties.Resources.num8;
            this.btn8.Location = new System.Drawing.Point(129, 243);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(57, 57);
            this.btn8.TabIndex = 8;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Image = global::Calculadora.Properties.Resources.num6;
            this.btn6.Location = new System.Drawing.Point(192, 184);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(58, 57);
            this.btn6.TabIndex = 7;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Image = global::Calculadora.Properties.Resources.num7;
            this.btn7.Location = new System.Drawing.Point(63, 246);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(58, 57);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Image = global::Calculadora.Properties.Resources.num5;
            this.btn5.Location = new System.Drawing.Point(128, 184);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(58, 58);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "&";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Image = global::Calculadora.Properties.Resources.num4;
            this.btn4.Location = new System.Drawing.Point(65, 184);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(58, 58);
            this.btn4.TabIndex = 4;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Image = global::Calculadora.Properties.Resources.num3;
            this.btn3.Location = new System.Drawing.Point(192, 130);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(59, 58);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Image = global::Calculadora.Properties.Resources.num2;
            this.btn2.Location = new System.Drawing.Point(128, 130);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(58, 58);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Image = global::Calculadora.Properties.Resources.num1;
            this.btn1.Location = new System.Drawing.Point(64, 130);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(58, 58);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnSub
            // 
            this.btnSub.AutoSize = true;
            this.btnSub.BackColor = System.Drawing.Color.Transparent;
            this.btnSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Image = global::Calculadora.Properties.Resources.menos;
            this.btnSub.Location = new System.Drawing.Point(251, 243);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(58, 58);
            this.btnSub.TabIndex = 24;
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click_1);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(316, 360);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMostrarmemoria);
            this.Controls.Add(this.lblmemoria);
            this.Controls.Add(this.btnLimpaMemoria);
            this.Controls.Add(this.btnSubMemoria);
            this.Controls.Add(this.btnSomaMemoria);
            this.Controls.Add(this.btnPorcen);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtVisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EtecCALC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnPorcen;
        private System.Windows.Forms.Button btnSomaMemoria;
        private System.Windows.Forms.Button btnSubMemoria;
        private System.Windows.Forms.Button btnLimpaMemoria;
        private System.Windows.Forms.Label lblmemoria;
        private System.Windows.Forms.Button btnMostrarmemoria;
        private System.Windows.Forms.Button btnSub;
    }
}

