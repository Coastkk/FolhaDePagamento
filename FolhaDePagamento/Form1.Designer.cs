namespace FolhaDePagamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalVencimentos = new System.Windows.Forms.TextBox();
            this.botaoCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtHorasExtrasCinquenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPericulosidade = new System.Windows.Forms.TextBox();
            this.txtDSR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHorasExtrasCem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJornadaTrabalhoMensal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHorasExtrasNoturno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalDescontos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLiquidoReceber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFGTS_Mes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBaseCalculoFGTS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescontosFixos = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBaseCalculoINSS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folha de pagamento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário base (R$):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(241, 64);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(119, 23);
            this.txtSalarioBase.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descanso semanal remunerado (R$):\r\n\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(241, 108);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(119, 23);
            this.txtHorasTrabalhadas.TabIndex = 4;
            this.txtHorasTrabalhadas.TextChanged += new System.EventHandler(this.txtQuantidadeHoras_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Horas trabalhadas:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total de vencimentos:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTotalVencimentos
            // 
            this.txtTotalVencimentos.Location = new System.Drawing.Point(164, 378);
            this.txtTotalVencimentos.Name = "txtTotalVencimentos";
            this.txtTotalVencimentos.Size = new System.Drawing.Size(100, 23);
            this.txtTotalVencimentos.TabIndex = 7;
            this.txtTotalVencimentos.TextChanged += new System.EventHandler(this.txtValorSalarioFinal_TextChanged);
            // 
            // botaoCalcular
            // 
            this.botaoCalcular.Location = new System.Drawing.Point(380, 313);
            this.botaoCalcular.Name = "botaoCalcular";
            this.botaoCalcular.Size = new System.Drawing.Size(75, 23);
            this.botaoCalcular.TabIndex = 9;
            this.botaoCalcular.Text = "Calcular";
            this.botaoCalcular.UseVisualStyleBackColor = true;
            this.botaoCalcular.Click += new System.EventHandler(this.botaoCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Horas extaorinárias (50%)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtHorasExtrasCinquenta
            // 
            this.txtHorasExtrasCinquenta.Location = new System.Drawing.Point(618, 64);
            this.txtHorasExtrasCinquenta.Name = "txtHorasExtrasCinquenta";
            this.txtHorasExtrasCinquenta.Size = new System.Drawing.Size(119, 23);
            this.txtHorasExtrasCinquenta.TabIndex = 12;
            this.txtHorasExtrasCinquenta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adicional de periculosidade (%)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPericulosidade
            // 
            this.txtPericulosidade.Location = new System.Drawing.Point(618, 197);
            this.txtPericulosidade.Name = "txtPericulosidade";
            this.txtPericulosidade.Size = new System.Drawing.Size(119, 23);
            this.txtPericulosidade.TabIndex = 14;
            // 
            // txtDSR
            // 
            this.txtDSR.Location = new System.Drawing.Point(241, 197);
            this.txtDSR.Name = "txtDSR";
            this.txtDSR.Size = new System.Drawing.Size(119, 23);
            this.txtDSR.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Horas extraordinárias (100%)";
            // 
            // txtHorasExtrasCem
            // 
            this.txtHorasExtrasCem.Location = new System.Drawing.Point(618, 108);
            this.txtHorasExtrasCem.Name = "txtHorasExtrasCem";
            this.txtHorasExtrasCem.Size = new System.Drawing.Size(119, 23);
            this.txtHorasExtrasCem.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Jornada de trabalho mensal: ";
            // 
            // txtJornadaTrabalhoMensal
            // 
            this.txtJornadaTrabalhoMensal.Location = new System.Drawing.Point(241, 153);
            this.txtJornadaTrabalhoMensal.Name = "txtJornadaTrabalhoMensal";
            this.txtJornadaTrabalhoMensal.Size = new System.Drawing.Size(119, 23);
            this.txtJornadaTrabalhoMensal.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(491, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Horas extras noturno:";
            // 
            // txtHorasExtrasNoturno
            // 
            this.txtHorasExtrasNoturno.Location = new System.Drawing.Point(618, 153);
            this.txtHorasExtrasNoturno.Name = "txtHorasExtrasNoturno";
            this.txtHorasExtrasNoturno.Size = new System.Drawing.Size(119, 23);
            this.txtHorasExtrasNoturno.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Descontos:";
            // 
            // txtTotalDescontos
            // 
            this.txtTotalDescontos.Location = new System.Drawing.Point(380, 378);
            this.txtTotalDescontos.Name = "txtTotalDescontos";
            this.txtTotalDescontos.Size = new System.Drawing.Size(100, 23);
            this.txtTotalDescontos.TabIndex = 23;
            this.txtTotalDescontos.TextChanged += new System.EventHandler(this.txtDescontos_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(514, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Líquido a receber";
            // 
            // txtLiquidoReceber
            // 
            this.txtLiquidoReceber.Location = new System.Drawing.Point(618, 378);
            this.txtLiquidoReceber.Name = "txtLiquidoReceber";
            this.txtLiquidoReceber.Size = new System.Drawing.Size(100, 23);
            this.txtLiquidoReceber.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(534, 457);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "FGTS do mês:";
            // 
            // txtFGTS_Mes
            // 
            this.txtFGTS_Mes.Location = new System.Drawing.Point(618, 454);
            this.txtFGTS_Mes.Name = "txtFGTS_Mes";
            this.txtFGTS_Mes.Size = new System.Drawing.Size(100, 23);
            this.txtFGTS_Mes.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(66, 457);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "Base Cálc. FGTS:";
            // 
            // txtBaseCalculoFGTS
            // 
            this.txtBaseCalculoFGTS.Location = new System.Drawing.Point(164, 454);
            this.txtBaseCalculoFGTS.Name = "txtBaseCalculoFGTS";
            this.txtBaseCalculoFGTS.Size = new System.Drawing.Size(100, 23);
            this.txtBaseCalculoFGTS.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Descontos Fixos (R$):";
            // 
            // txtDescontosFixos
            // 
            this.txtDescontosFixos.Location = new System.Drawing.Point(241, 238);
            this.txtDescontosFixos.Name = "txtDescontosFixos";
            this.txtDescontosFixos.Size = new System.Drawing.Size(119, 23);
            this.txtDescontosFixos.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(284, 457);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 15);
            this.label16.TabIndex = 33;
            this.label16.Text = "Base Cálc. INSS:";
            // 
            // txtBaseCalculoINSS
            // 
            this.txtBaseCalculoINSS.Location = new System.Drawing.Point(380, 454);
            this.txtBaseCalculoINSS.Name = "txtBaseCalculoINSS";
            this.txtBaseCalculoINSS.Size = new System.Drawing.Size(100, 23);
            this.txtBaseCalculoINSS.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 553);
            this.Controls.Add(this.txtBaseCalculoINSS);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDescontosFixos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBaseCalculoFGTS);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtFGTS_Mes);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtLiquidoReceber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotalDescontos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtHorasExtrasNoturno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtJornadaTrabalhoMensal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHorasExtrasCem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDSR);
            this.Controls.Add(this.txtPericulosidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHorasExtrasCinquenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.botaoCalcular);
            this.Controls.Add(this.txtTotalVencimentos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CalculoFolhaDePagamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSalarioBase;
        private Label label3;
        private TextBox txtHorasTrabalhadas;
        private Label label4;
        private Label label5;
        private TextBox txtTotalVencimentos;
        private Button botaoCalcular;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtHorasExtrasCinquenta;
        private Label label7;
        private TextBox txtPericulosidade;
        private TextBox txtDSR;
        private Label label8;
        private TextBox txtHorasExtrasCem;
        private Label label9;
        private TextBox txtJornadaTrabalhoMensal;
        private Label label10;
        private TextBox txtHorasExtrasNoturno;
        private Label label11;
        private TextBox txtTotalDescontos;
        private Label label12;
        private TextBox txtLiquidoReceber;
        private Label label14;
        private TextBox txtFGTS_Mes;
        private Label label15;
        private TextBox txtBaseCalculoFGTS;
        private Label label13;
        private TextBox txtDescontosFixos;
        private Label label16;
        private TextBox txtBaseCalculoINSS;
    }
}