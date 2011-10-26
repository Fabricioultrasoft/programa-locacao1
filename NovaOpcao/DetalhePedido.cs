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
    public partial class DetalhePedido : Form
    {
        public DetalhePedido()
        {
            InitializeComponent();
        }

        private void fillDADOSToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hISTORICOTableAdapter.FillDADOS(this.detalhesPedido1.HISTORICO, ((System.DateTime)(System.Convert.ChangeType(DataFiltro.Text, typeof(System.DateTime)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    

        private void DetalhePedido_Load(object sender, EventArgs e)
        {
            
            

            // TODO: This line of code loads data into the 'retornaNome.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter1.Fill(this.retornaNome.CLIENTE);
            // TODO: This line of code loads data into the 'nOVAOPCAODBDataSet6.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.nOVAOPCAODBDataSet6.CLIENTE);

           
            

        }

        private void fillDADOSToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.hISTORICOTableAdapter.FillDADOS(this.detalhesPedido1.HISTORICO, ((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Text, typeof(System.DateTime)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void DetalhesPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NomeID_TextChanged(object sender, EventArgs e)
        {

        }

        



        
    }
}
