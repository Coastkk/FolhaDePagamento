using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.Utilitarios
{
    public class CalculaDescontoINSS
    {
        public double salario { get; set; }
        static double DescontoINSS;
        int aliquota;
        public static double CalcularDescontoINSS(double salario)
        {
            if(salario <= 1903.98)
            {
                
            }
            if(salario >= 1903.99 && salario <= 2826.65)
            {
               DescontoINSS = (salario / 100) * 7.5;
            }
            if(salario >= 2826.66 && salario <= 3751.05)
            {
                DescontoINSS = (salario / 100) * 15;
            }
            if(salario >= 3751.06 && salario <= 4664.68)
            {
                DescontoINSS = (salario / 100) * 22.5;
            }
            if(salario > 4664.68)
            {
                DescontoINSS = (salario / 100) * 27.5;
            }
            return DescontoINSS;
        }
    }
}
