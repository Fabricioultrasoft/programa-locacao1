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
    public partial class Relatorio_Produto : Form
    {
        public Relatorio_Produto()
        {
            InitializeComponent();
        }

        private void Relatorio_Produto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NOVAOPCAODBDataSet.PRODUTOS' table. You can move, or remove it, as needed.
            this.PRODUTOSTableAdapter.Fill(this.NOVAOPCAODBDataSet.PRODUTOS);

            this.reportViewer1.RefreshReport();
        }
    }
}
