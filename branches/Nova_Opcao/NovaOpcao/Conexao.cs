using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace NovaOpcao
{
    class Conexao
    {

        public string AbreBanco()
        {
            string InfoConexao = ConfigurationSettings.AppSettings["InfoConexao"];
            SqlConnection connection = new SqlConnection(InfoConexao);
            connection.Open();
            return InfoConexao;

        }

    }
}
