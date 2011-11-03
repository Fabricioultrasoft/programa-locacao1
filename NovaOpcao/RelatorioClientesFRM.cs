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
    public partial class RelatorioClientesFRM : Form
    {
        public RelatorioClientesFRM()
        {
            InitializeComponent();
        }

        private void RelatorioClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NOVAOPCAODBDataSetCLIENTES.CLIENTE' table. You can move, or remove it, as needed.
            this.CLIENTETableAdapter.Fill(this.NOVAOPCAODBDataSetCLIENTES.CLIENTE);

            this.reportViewer1.RefreshReport();
        }
    }
}
