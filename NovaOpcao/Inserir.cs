using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace NovaOpcao
{
    class Inserir
    {
        public Double ResultadoGlobal;

        public void InserirCliente(string nome_cliente, string sobrenome_cliente, string endereco_cliente, string telefone_cliente, string celular_cliente, string alternativo_cliente, string email_cliente)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS; AttachDbFilename=C:\BandoNovaOpcao\NOVAOPCAODB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO CLIENTE(NOME, SOBRENOME, ENDEREÇO, TELEFONE1, TELEFONE2, EMAIL, TELEFONE3) VALUES (@NOME, @SOBRENOME, @END, @TEL, @CEL, @EMAIL, @ALT)", sqlConn);

            cmd.Parameters.Add("@NOME", nome_cliente);
            cmd.Parameters.Add("@SOBRENOME", sobrenome_cliente);
            cmd.Parameters.Add("@END", endereco_cliente);
            cmd.Parameters.Add("@TEL", telefone_cliente);
            cmd.Parameters.Add("@CEL", celular_cliente);
            cmd.Parameters.Add("@ALT", alternativo_cliente);
            cmd.Parameters.Add("@EMAIL", email_cliente);

            cmd.ExecuteNonQuery();

            sqlConn.Close();

        }

        public void InserirFornecedor(string nome, string endereco_fornecedor, string telefone_fornecedor, string celular_fornecedor,
            string email)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS; AttachDbFilename=C:\BandoNovaOpcao\NOVAOPCAODB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True; ";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO FORNECEDOR(NOME_FORNECEDOR, END_FORNECEDOR, TELEFONE_FORNECEDOR, TELEFONE_FORNECEDOR2, EMAIL) VALUES (@NOME, @END, @TEL, @CEL, @EMAIL)", sqlConn);

            cmd.Parameters.Add("@NOME", nome);
            cmd.Parameters.Add("@END", endereco_fornecedor);
            cmd.Parameters.Add("@TEL", telefone_fornecedor);
            cmd.Parameters.Add("@CEL", celular_fornecedor);
            cmd.Parameters.Add("@EMAIL", email);

            cmd.ExecuteNonQuery();

            sqlConn.Close();


        }
        
        public void InserirProduto(string nome, int qtde, double valor_unitario, double valor_total)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS; AttachDbFilename=C:\BandoNovaOpcao\NOVAOPCAODB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True; ";
          
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO PRODUTOS (DESCRICAO, QUANTIDADE, VALOR_UNITARIO, VALOR_TOTAL) VALUES (@nome, @qtde, @valor_unitario, @valor_total)", sqlConn);
            cmd.Parameters.Add("@nome", nome);
            cmd.Parameters.Add("@qtde", qtde);
            cmd.Parameters.Add("@valor_unitario", valor_unitario);
            cmd.Parameters.Add("@valor_total", valor_total);
          
            cmd.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void Selecao()
        {
            

        }

        public string VerificaString(string Input1, string Input2)
        {
            string Resultado = "";

            if (Input1 == String.Empty || Input2 == String.Empty)
            {
                Resultado = "0";

                return Resultado;
            }
            else if (Input2 == "0" || Input2 == "0")
            {
                Resultado = "0";


            }
            else
            {

                SetaQuantidade(Convert.ToDouble(Input1), Convert.ToDouble(Input2));

            }

            return Resultado;

        }


        public double SetaQuantidade(double valor_uni, double qtde)
        {
                       
            return ResultadoGlobal = valor_uni * qtde;

        }

    }
}
