using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LocacaoNovaVersao
{
    class VerificaString
    {
        public Double PrecoCusto, PrecoVenda, Lucro;
        double Resultado;

        public double VerificaValores(string Input1, string Input2, string Input3)
        {
            try
            {

                if (Input1 == String.Empty || Input2 == String.Empty || Input3 == String.Empty)
                {
                    Resultado = 0.00;
                }
                else if (Input2 == "0" || Input2 == "0" || Input3 == String.Empty)
                {
                    Resultado = 0.00;
                }
                else
                {
                    return SetaQuantidade(Convert.ToInt32(Input1), Convert.ToDouble(Input2), Convert.ToDouble(Input3));
                }
                return Resultado = 0.00;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("O valor inserido NÃO está no formato correto.\nLembrando que o campo Quantidade comporta apenas valores Inteiros. Ex:. 1, 2, 10, 27, 99, etc.\nOs outros aceitam tanto Inteiros como Decimais. Ex:. 1, 2, 2.5, 7, 10, 100.99, etc","Erro de Valores",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return Resultado = 0.00;
            }

        }


        private double SetaQuantidade(int Quantidade, double Preco_Custo, double Preco_Venda)
        {
            PrecoCusto = Preco_Custo * Quantidade+Resultado;
            PrecoVenda = Preco_Venda * Quantidade + Resultado;
            Lucro = PrecoVenda - PrecoCusto + Resultado;
            return Lucro;

        }

    }
}
