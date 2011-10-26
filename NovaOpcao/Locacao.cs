using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace NovaOpcao
{
    public partial class Locacao : Form
    {
        public Locacao()
        {

            InitializeComponent();
        }

        private void ListaProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Locacao lc = new Locacao();
            lc.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ArrayList CalculoAluguel = new ArrayList();
            int controleInicial = 0;
            int coluna = 6, linha = 0;
            while (controleInicial < AlocTab.RowCount)
            {
                CalculoAluguel.Insert(linha, Convert.ToInt32(AlocTab[coluna, linha++].Value));
                AlocTab[3, linha - 1].Value = Convert.ToInt32(AlocTab[3, linha - 1].Value) - Convert.ToInt32(AlocTab[6, linha - 1].Value);
                AlocTab.Update();
                AlocTab.Refresh();
                controleInicial++;
            }
        }

        private void Locacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nOVAOPCAODBDataSet3.CLIENTE' table. You can move, or remove it, as needed.
           this.cLIENTETableAdapter1.Fill(this.nOVAOPCAODBDataSet3.CLIENTE);
            // TODO: This line of code loads data into the 'nOVAOPCAODBDataSet2.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.nOVAOPCAODBDataSet2.CLIENTE);
            // TODO: This line of code loads data into the 'nOVAOPCAODBDataSet1.PRODUTOS' table. You can move, or remove it, as needed.
            this.pRODUTOSTableAdapter1.Fill(this.nOVAOPCAODBDataSet1.PRODUTOS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Id_Cliente = TxtClientes.SelectedValue.ToString();
            int tamanhoArray = AlocTab.RowCount;
            int controleInicial = 0;

           

            ArrayList ProdutoID = new ArrayList();
            ArrayList DescricaoProduto = new ArrayList();
            ArrayList QtdeProduto = new ArrayList();
            

            DateTime data_retirada = data_locacao.Value.Date;
            DateTime DATA_DEVOL = dt_devol.Value.Date;

            while (controleInicial < AlocTab.RowCount)
            {

                ProdutoID.Insert(controleInicial, AlocTab[0, controleInicial].Value);
                DescricaoProduto.Insert(controleInicial, AlocTab[3, controleInicial].Value);
                controleInicial++;
            }


            int controleBanco = 0, sinalizador=0;

            if (Convert.ToInt32(AlocTab[3, controleBanco].Value) > 0)
            {
                sinalizador = 0;
            for (int controle = 0; controle < tamanhoArray; controle++)
            {
                if (Convert.ToInt32(AlocTab[6, controle].Value) != 0)
                {
                    string connectionString = @"Data Source=.\SQLEXPRESS; AttachDbFilename=C:\BandoNovaOpcao\NOVAOPCAODB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                    SqlConnection sqlConn = new SqlConnection(connectionString);
                    sqlConn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO LOCACAO(ID_CLIENTE, ID_PRODUTO, QUANTIDADE, DATA_ALOCADA, DATA_DEVOL) VALUES (@Id_Cliente, @Produto, @Qtde, @dataAgora, @dataDevol)", sqlConn);
                    SqlCommand historico = new SqlCommand("INSERT INTO HISTORICO(ID_PRODUTO, ID_CLIENTE, QUANTIDADE_ALUGADA, DATA_ALUGUEL, DATE_DEVOLUCAO) VALUES (@Produto, @Id_Cliente, @Qtde, @dataAgora, @dataDevol)", sqlConn);                   
                    SqlCommand alter = new SqlCommand("UPDATE PRODUTOS SET QUANTIDADE = (QUANTIDADE - @Qtde) WHERE (ID_PRODUTO = @Produto)",sqlConn);

                    cmd.Parameters.Add("@Id_Cliente", Id_Cliente);
                    cmd.Parameters.Add("@Produto", ProdutoID[controle]);
                    cmd.Parameters.Add("@Qtde", Convert.ToString(AlocTab[6, controle].Value));
                    cmd.Parameters.Add("@dataAgora", data_retirada);
                    cmd.Parameters.Add("@dataDevol", DATA_DEVOL);


                    alter.Parameters.Add("@Qtde", Convert.ToString(AlocTab[6, controle].Value));
                    alter.Parameters.Add("@Produto", ProdutoID[controle]);

                    historico.Parameters.Add("@Produto", ProdutoID[controle]);
                    historico.Parameters.Add("@Id_Cliente",Id_Cliente);
                    historico.Parameters.Add("@Qtde", Convert.ToString(AlocTab[6, controle].Value));
                    historico.Parameters.Add("@dataAgora", data_retirada);
                    historico.Parameters.Add("@dataDevol", DATA_DEVOL);

                    cmd.ExecuteNonQuery();
                    alter.ExecuteNonQuery();
                    historico.ExecuteNonQuery();

                    sqlConn.Close();

                    sinalizador = 1;
                }
            }
                controleBanco++;
            }else{
                sinalizador = 0;
                 MessageBox.Show("Um ou mais Produtos possui 0 items no estoque, não sendo possível a locação. Revise a quantidade e tente novamente!");

            }

            if (sinalizador == 1)
            {
                MessageBox.Show("Produtos alugados com sucesso!");
            }
            else
            {

                MessageBox.Show("Produtos não Alugados - Revise quantidade em estoque e tente novamente");
            }




            

        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            Locacao.ActiveForm.Close();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            int linha = 0;
            while(linha < AlocTab.RowCount) {
                AlocTab[6,linha].Value = null;
                linha++;
                AlocTab.Refresh();
            }
        }
    }
}

