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
            string Profissao = textProfissao.Text;
            string Observacao = textObservacao.Text;
            string Endereco = textEndereco.Text;
            string Bairro = textBairro.Text;
            string CEP = textCEP.Text;
            string UF = comboUF.SelectedItem.ToString();

            if (Masculino.Checked)
            {
                //sexo = 0 significa status Masculino, sexo = 1 status feminino
                int Sexo = 0;
            }
            else
            {
                int sexo = 1;

            }

            DateTime DtCriacao = dataAtual.Value;



           
        }

        private void InserirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirFoto = new OpenFileDialog();
            abrirFoto.ShowDialog();
            ImagemCliente.ImageLocation = abrirFoto.FileName;
        }

     }
}
