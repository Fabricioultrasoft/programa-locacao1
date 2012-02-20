using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace LocacaoNovaVersao
{
    class InteracaoBanco
    {
        string StringGeral = @"Data Source=.\SQLEXPRESS; AttachDbFilename=|DataDirectory|\LocacaoPrincipalDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
        SqlConnection sqlConn;

        public void AbreBanco()
        {
            sqlConn = new SqlConnection(StringGeral); 
            sqlConn.Open();
        }

        public void InserirCliente(string nomeCliente, string sobrenomeCliente, string CPF, string RG, string CNPJ, string Fone_res, string Fone_com,
            string Fone_Cel, string Profissao_cliente, string Observacao_cliente, string Endereco_cliente, string Bairro_cliente, string Cidade, string CEP_cliente,
            string uf_cliente, int Sexo, string email_cliente, DateTime dtCAdastro)
        {
            try
            {
                AbreBanco();
                SqlCommand InserirUsuario = new SqlCommand("Insert into Cliente(Nome_Cliente, Sobrenome_Cliente, CPF, RG, CNPJ, Fone_res, Fone_com, Fone_cel, Profissao_cliente, Observacao_cliente, Endereco_cliente, Cidade_cliente, Bairro_cliente, CEP_cliente, UF_cliente, Sexo, email_cliente, Data_Cadastro) Values(@nomeCliente, @sobrenomeCliente, @CPF, @RG, @CNPJ, @Fone_res, @Fone_com, @Fone_Cel, @Profissao_cliente, @Observacao, @Endereco_cliente, @Cidade, @Bairro_cliente,  @CEP_cliente, @uf_cliente, @sexo, @email_cliente, @data_cadastro)", sqlConn);
                
                InserirUsuario.Parameters.Add("@nomeCliente", nomeCliente);
                InserirUsuario.Parameters.Add("@sobrenomeCliente", sobrenomeCliente);
                InserirUsuario.Parameters.Add("@CPF", CPF);
                InserirUsuario.Parameters.Add("@RG", RG);
                InserirUsuario.Parameters.Add("@CNPJ", CNPJ);
                InserirUsuario.Parameters.Add("@Fone_res", Fone_res);
                InserirUsuario.Parameters.Add("Fone_com", Fone_com);
                InserirUsuario.Parameters.Add("@Fone_Cel", Fone_Cel);
                InserirUsuario.Parameters.Add("@Profissao_cliente", Profissao_cliente);
                InserirUsuario.Parameters.Add("@Endereco_cliente", Endereco_cliente);
                InserirUsuario.Parameters.Add("@Observacao", Observacao_cliente);
                InserirUsuario.Parameters.Add("@Bairro_cliente", Bairro_cliente);
                InserirUsuario.Parameters.Add("@Cidade", Cidade);
                InserirUsuario.Parameters.Add("@CEP_cliente", CEP_cliente);
                InserirUsuario.Parameters.Add("@uf_cliente", uf_cliente);
                InserirUsuario.Parameters.Add("@sexo", Sexo);
                InserirUsuario.Parameters.Add("@email_cliente", email_cliente);
                InserirUsuario.Parameters.Add("@data_cadastro", dtCAdastro);
                InserirUsuario.ExecuteNonQuery();
                MessageBox.Show("Dados Inseridos com Sucesso", "Inserção de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (SqlException)
            {

                MessageBox.Show("Houve um problema ao Realizar a Inserção dos Valores. Tente Novamente");

            }

            
        }
    }
}
