using FolhaDePagamento.Utilitarios;

namespace FolhaDePagamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoCalcular_Click(object sender, EventArgs e)
        {
            int QuantidadeHorasTrabalhadas, QuantidadeHorasNaoTrabalhadas, JornadaMensal, QuantidadeHorasExtrasCinquenta,
                QuantidadeHorasExtrasCem, QuantidadeHorasExtrasNoturno;
            double salarioBase, PercentualPericulosidade, HorasNaoTrabalhadas, TotalVencimentos, TotalDescontos, LiquidoReceber, ValorHoraComum, HorasExtrasCem,
                HorasExtasCinquenta, HorasExtrasNoturno, DescontoINSS, FGTS, Perciculosidade, DescontosFixos;

            salarioBase = double.Parse(txtSalarioBase.Text);
            JornadaMensal = int.Parse(txtJornadaTrabalhoMensal.Text);
            QuantidadeHorasTrabalhadas = int.Parse(txtHorasTrabalhadas.Text);
            PercentualPericulosidade = double.Parse(txtPericulosidade.Text);
            DescontosFixos = double.Parse(txtDescontosFixos.Text);

            ValorHoraComum = salarioBase / JornadaMensal;
            Perciculosidade = salarioBase * (PercentualPericulosidade / 100);
            
            QuantidadeHorasNaoTrabalhadas = QuantidadeHorasTrabalhadas - JornadaMensal;
            HorasNaoTrabalhadas = (ValorHoraComum * QuantidadeHorasNaoTrabalhadas) * -1;

            QuantidadeHorasExtrasCinquenta = int.Parse(txtHorasExtrasCinquenta.Text);
            QuantidadeHorasExtrasCem = int.Parse(txtHorasExtrasCem.Text);
            QuantidadeHorasExtrasNoturno = int.Parse(txtHorasExtrasNoturno.Text);
            HorasExtasCinquenta = (ValorHoraComum * 1.5) * QuantidadeHorasExtrasCinquenta;
            HorasExtrasCem = (ValorHoraComum * 2) * QuantidadeHorasExtrasCem;
            HorasExtrasNoturno = ((ValorHoraComum * 1.5) * 1.2) * QuantidadeHorasExtrasNoturno;

            TotalVencimentos = salarioBase + HorasExtasCinquenta + HorasExtrasCem + HorasExtrasNoturno + HorasNaoTrabalhadas + Perciculosidade;

            DescontoINSS = CalculaDescontoINSS.CalcularDescontoINSS(TotalVencimentos);
            TotalDescontos = DescontoINSS + DescontosFixos;

            LiquidoReceber = TotalVencimentos - TotalDescontos;

            FGTS = TotalVencimentos * 0.08;

            txtTotalVencimentos.Text = TotalVencimentos.ToString();
            txtTotalDescontos.Text = TotalDescontos.ToString();
            txtLiquidoReceber.Text = LiquidoReceber.ToString();
            txtBaseCalculoFGTS.Text = TotalVencimentos.ToString();
            txtBaseCalculoINSS.Text = TotalVencimentos.ToString();
            txtFGTS_Mes.Text = FGTS.ToString();
        }

        private void txtQuantidadeHoras_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtValorSalarioFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtDescontos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}