using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LocacaoNovaVersao
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InteracaoBanco ManipularBanco = new InteracaoBanco();
            string Nome = textnome.Text;
            string Sobrenome = textsobrenome.Text;
            string CPF = textCPF.Text;
            string RG = textRG.Text;
            string CNPJ = textCPF.Text;
            string FoneRes = textFoneRes.Text;
            string FoneCom = textFoneCom.Text;
            string FoneCel = textCelular.Text;
            string Profissao = textProfissao.Text;
            string Observacao = textObservacao.Text;
            string Endereco = textEndereco.Text;
            string Cidade = textCidade.Text;
            string Bairro = textBairro.Text;
            string CEP = textCEP.Text;
            string UF = comboUF.SelectedItem.ToString();
            string Email = textemail.Text;
            int Sexo;

            if (Masculino.Checked)
            {
                //sexo = 0 significa status Masculino, sexo = 1 status feminino
                Sexo = 0;
            }
            else
            {
                Sexo = 1;

            }

            DateTime DtCriacao = dataAtual.Value;

            ManipularBanco.InserirCliente(Nome, Sobrenome, CPF, RG, CNPJ, FoneRes, FoneCom, FoneCel, Profissao, Observacao, Endereco,Cidade, Bairro,  CEP, UF, Sexo, Email, DtCriacao);


           
        }

        private void textQuantidade_TextChanged(object sender, EventArgs e)
        {
            ChamadaAtualizacaoValores();
            
        }

        private void textCusto_TextChanged(object sender, EventArgs e)
        {
            ChamadaAtualizacaoValores();
            
        }

        private void textVenda_TextChanged(object sender, EventArgs e)
        {
            ChamadaAtualizacaoValores();
        }

        private void ChamadaAtualizacaoValores()
        {
            VerificaString verifica = new VerificaString();
            verifica.VerificaValores(textQuantidade.Text, textCusto.Text, textVenda.Text);
            labelCusto.Text = verifica.PrecoCusto.ToString();
            labelVenda.Text = verifica.PrecoVenda.ToString();
            labelLucro.Text = verifica.Lucro.ToString();

        }


        private void Observacao_TextChanged(object sender, EventArgs e)
        {
            contadorLetras.Text = Observacao.TextLength.ToString();
        }
        

        
     }
}
