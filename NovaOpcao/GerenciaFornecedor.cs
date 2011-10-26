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
    public partial class GerenciaFornecedor : Form
    {
        public GerenciaFornecedor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nOVAOPCAODBDataSet7.FORNECEDOR' table. You can move, or remove it, as needed.
            this.fORNECEDORTableAdapter.Fill(this.nOVAOPCAODBDataSet7.FORNECEDOR);

        }

  

      

    }
}
