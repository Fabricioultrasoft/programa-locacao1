using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace LocacaoNovaVersao
{
    class InteracaoBanco
    {


        private void AbreBanco()
        {
            string StringGeral = @"Data Source=.\SQLEXPRESS; AttachDbFilename=|DataDirectory|\LocacaoPrincipalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            SqlConnection sqlConn = new SqlConnection(StringGeral);
            sqlConn.Open();
        }

        public void InserirCliente(string nomeCliente, string sobrenomeCliente, string CPF, string RG, string CNPJ, string Fone_res, string Fone_com,
            string Fone_Cel, string Profissao_cliente, string Observacao_cliente, string Endereco_cliente, string Bairro_cliente, string CEP_cliente,
            string uf_cliente, int Sexo, string email_cliente, DateTime dtCAdastro, Bitmap Imagem)
        {
            

        }
    }
}
