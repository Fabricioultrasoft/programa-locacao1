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
    public partial class RelatorioFornecedor : Form
    {
        public RelatorioFornecedor()
        {
            InitializeComponent();
        }

        private void RelatorioFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NOVAOPCAODBDataSet7.FORNECEDOR' table. You can move, or remove it, as needed.
            this.FORNECEDORTableAdapter.Fill(this.NOVAOPCAODBDataSet7.FORNECEDOR);

            this.reportViewer1.RefreshReport();
        }
    }
}
