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
    public partial class Fornecedor : Form
    {
        String nome_fornecedor = "";
        String endereco_fornecedor = "";
        String telefone_fornecedor;
        String celular_fornecedor;
        String email = "";
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void textnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btFornecedor_Click(object sender, EventArgs e)
        {
            Inserir fornecedor = new Inserir();

                            
            nome_fornecedor = textnome.Text;
            endereco_fornecedor = textendereco.Text;
            telefone_fornecedor = texttelefone.Text;
            celular_fornecedor = textcelular.Text;
            email = textemail.Text;

            fornecedor.InserirFornecedor(nome_fornecedor, endereco_fornecedor, telefone_fornecedor, celular_fornecedor, email);


            if (MessageBox.Show("Deseja cadastrar outro fornecedor?", "Fornecedor cadastrado com sucesso", MessageBoxButtons.YesNo) == DialogResult.No)
            {

                Fornecedor.ActiveForm.Close();

            }
            else
            {
                textnome.Clear();
                textendereco.Clear();
                texttelefone.Clear();
                textcelular.Clear();
                textemail.Clear();
            }
           

        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            textnome.Clear();
            textendereco.Clear();
            texttelefone.Clear();
            textcelular.Clear();
            textemail.Clear();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            Fornecedor.ActiveForm.Close();
        }

    
        
    }
}
