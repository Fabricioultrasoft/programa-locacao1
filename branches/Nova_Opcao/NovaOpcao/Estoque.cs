using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NovaOpcao
{
    public partial class Estoque : Form
    {
        string nome_produto = "";
        int quantidade = 0;
        double valor_unitario = 0;
        double valor_total;
        public Estoque()
        {
            InitializeComponent();
        }
    
        private void saiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIni frmini = new FrmIni();
            frmini.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nome_produto = Nome_Produto.Text;
            quantidade = Convert.ToInt32(qtde_produto.Text);
            valor_unitario = Convert.ToDouble(Valor_Unitario.Text);
            Inserir insere = new Inserir();
            insere.InserirProduto(nome_produto, quantidade, valor_unitario, valor_total);

            if (MessageBox.Show("Deseja cadastrar outro produto?", "Produto cadastrado com sucesso", MessageBoxButtons.YesNo) == DialogResult.No)
            {

                Estoque.ActiveForm.Close();

            }
            else
            {
                Nome_Produto.Clear();
                qtde_produto.Text = "0";
                Valor_Unitario.Text = "0,00";
            }



        }

        private void Valor_Unitario_TextChanged(object sender, EventArgs e)
        {
            Inserir controle = new Inserir();

            controle.VerificaString(Valor_Unitario.Text, qtde_produto.Text); 
            
            //setando variavel global
            valor_total = controle.ResultadoGlobal;

            //setando textBox
            Valor_Total.Text = controle.ResultadoGlobal.ToString();
                     
        }

        private void qtde_produto_TextChanged(object sender, EventArgs e)
        {
            Inserir controle = new Inserir();

            controle.VerificaString(Valor_Unitario.Text, qtde_produto.Text);

            //setando variavel global
            valor_total = controle.ResultadoGlobal;

            //setando textBox
            Valor_Total.Text = controle.ResultadoGlobal.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nome_Produto.Clear();
            qtde_produto.Clear();
            Valor_Total.Clear();
            Valor_Unitario.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Estoque.ActiveForm.Close();

        }

        private void Estoque_Load(object sender, EventArgs e)
        {
        }
    }
}
