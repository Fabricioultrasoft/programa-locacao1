using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NovaOpcao
{
    public partial class Cliente : Form
    {
        String nome_cliente = "";
        String sobrenome_cliente = "";
        String endereco_cliente = "";
        String telefone_cliente;
        String celular_cliente;
        String alternativo_cliente;
        String email_cliente = "";
        public Cliente()
        {
            InitializeComponent();
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();

            nome_cliente = textnome.Text;
            sobrenome_cliente = textsobrenome.Text;
            endereco_cliente = textendereco.Text;

            telefone_cliente = texttelefone.Text;

            celular_cliente = textcelular.Text;

            alternativo_cliente = textalternativo.Text;

            email_cliente = textemail.Text;

            inserir.InserirCliente(nome_cliente, sobrenome_cliente, endereco_cliente, telefone_cliente, celular_cliente, alternativo_cliente, email_cliente);


            if (MessageBox.Show("Deseja cadastrar outro cliente?", "Cliente cadastrado com sucesso", MessageBoxButtons.YesNo) == DialogResult.No)
            {

                Cliente.ActiveForm.Close();

            }
            else
            {
                textnome.Clear();
                textsobrenome.Clear();
                textendereco.Clear();
                texttelefone.Clear();
                textcelular.Clear();
                textalternativo.Clear();
                textemail.Clear();
            }

        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            textnome.Clear();
            textsobrenome.Clear();
            textendereco.Clear();
            texttelefone.Clear();
            textcelular.Clear();
            textalternativo.Clear();
            textemail.Clear();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            Cliente.ActiveForm.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioClientesFRM rlCL = new RelatorioClientesFRM();
            rlCL.Show();
        }
    }
}
