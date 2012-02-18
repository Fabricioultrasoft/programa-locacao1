using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Threading;

namespace NovaOpcao
{
    public partial class FrmIni : Form
    {
        int cont;

        public FrmIni()
        {
          
            InitializeComponent();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Estoque estoque = new Estoque();
            estoque.Show();
        }

        private void novoFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Show();
        }

        private void saiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIni.ActiveForm.Close();

        }

        private void sobreOProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre.ActiveForm.Close();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            cl.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Locacao lc = new Locacao();
            lc.Show();
        }

        private void FrmIni_Load(object sender, EventArgs e)
        {
         Clipboard.SetDataObject(monthCalendar1.SelectionStart);

         IDataObject iData = Clipboard.GetDataObject();
          
  

            // TODO: This line of code loads data into the 'NOVAOPCAODBDataSet.PRODUTOS' table. You can move, or remove it, as needed.
            this.PRODUTOSTableAdapter.Fill(this.NOVAOPCAODBDataSet.PRODUTOS);

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioFornecedor rl = new RelatorioFornecedor();
            rl.Show();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS; AttachDbFilename=C:\BandoNovaOpcao\NOVAOPCAODB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            
            DateTime DATASELECIONADA = monthCalendar1.SelectionStart;

            SqlCommand cmd = new SqlCommand("SELECT DISTINCT CL.NOME, CL.EMAIL, HR.DATA_ALUGUEL, HR.DATE_DEVOLUCAO FROM CLIENTE AS CL LEFT JOIN HISTORICO AS HR ON(CL.ID_CLIENTE = HR.ID_CLIENTE) WHERE(HR.DATA_ALUGUEL = @DATASELECIONADA)", sqlConn);

            

            cmd.Parameters.Add("@DATASELECIONADA", DATASELECIONADA);

            SqlDataReader sqlDTR = cmd.ExecuteReader();
                        
            DadosHistorico.Items.Clear();
            while (sqlDTR.Read())
            {
                object nome = sqlDTR[0];
                object email = sqlDTR[1];
                object dataAlugel = sqlDTR[2];
                object dataDevol = sqlDTR[3];

                DadosHistorico.Items.Add("Nome: " + nome.ToString() + "-" + "Email: " + email.ToString()+ "-" + "Data Alugada: " + dataAlugel.ToString() + "-" + "Data de Devolução: " + dataDevol.ToString());


            }

            var Data = monthCalendar1.SelectionStart;
            sqlDTR.Close();




        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            DetalhePedido DtPedid = new DetalhePedido();

            DtPedid.Show();
        }


        private void btlocar_Click(object sender, EventArgs e)
        {
            Locacao lc = new Locacao();
            lc.Show();
        }

        private void btnovoproduto_Click(object sender, EventArgs e)
        {
            Estoque et = new Estoque();
            et.Show();
        }

        private void btnovocliente_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            cl.Show();
        }

        private void btfornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fc = new Fornecedor();
            fc.Show();
        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque est = new Estoque();
            est.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            progresso.Maximum = 100;
            progresso.Minimum = 0;
            cont = 0;

            RelatorioClientesFRM rltCLT = new RelatorioClientesFRM();
            rltCLT.Show();
            

            
            

        }

   

              

        private void button1_Click(object sender, EventArgs e)
        {
            GerenciaEMAIL grEmail = new GerenciaEMAIL();
            grEmail.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orcamento orc = new Orcamento();
            orc.Show();
        }
    }

}

