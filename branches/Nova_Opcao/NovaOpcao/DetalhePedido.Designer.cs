namespace NovaOpcao
{
    partial class DetalhePedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.DetalhesPedido = new System.Windows.Forms.DataGridView();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTIDADEALUGADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAALUGUELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDEVOLUCAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hISTORICOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.detalhesPedido1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalhesPedido1 = new NovaOpcao.DetalhesPedido();
            this.hISTORICOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hISTORICOTableAdapter = new NovaOpcao.DetalhesPedidoTableAdapters.HISTORICOTableAdapter();
            this.tableAdapterManager = new NovaOpcao.DetalhesPedidoTableAdapters.TableAdapterManager();
            this.hISTORICOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hISTORICOBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.retornaNome = new NovaOpcao.RetornaNome();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nOVAOPCAODBDataSet6 = new NovaOpcao.NOVAOPCAODBDataSet6();
            this.hISTORICOBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new NovaOpcao.NOVAOPCAODBDataSet6TableAdapters.CLIENTETableAdapter();
            this.cLIENTETableAdapter1 = new NovaOpcao.RetornaNomeTableAdapters.CLIENTETableAdapter();
            this.DataFiltro = new System.Windows.Forms.DateTimePicker();
            this.fillDADOSToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fillDADOSToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DetalhesPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORICOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalhesPedido1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalhesPedido1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORICOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORICOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORICOBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retornaNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOVAOPCAODBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORICOBindingSource4)).BeginInit();
            this.fillDADOSToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Detalhes do Pedido:";
            // 
            // DetalhesPedido
            // 
            this.DetalhesPedido.AllowUserToAddRows = false;
            this.DetalhesPedido.AllowUserToDeleteRows = false;
            this.DetalhesPedido.AutoGenerateColumns = false;
            this.DetalhesPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalhesPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOME,
            this.dataGridViewTextBoxColumn3,
            this.qUANTIDADEALUGADADataGridViewTextBoxColumn,
            this.dATAALUGUELDataGridViewTextBoxColumn,
            this.dATEDEVOLUCAODataGridViewTextBoxColumn});
            this.DetalhesPedido.DataSource = this.hISTORICOBindingSource2;
            this.DetalhesPedido.Location = new System.Drawing.Point(15, 76);
            this.DetalhesPedido.Name = "DetalhesPedido";
            this.DetalhesPedido.ReadOnly = true;
            this.DetalhesPedido.Size = new System.Drawing.Size(771, 341);
            this.DetalhesPedido.TabIndex = 7;
            this.DetalhesPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalhesPedido_CellContentClick);
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DESCRICAO";
            this.dataGridViewTextBoxColumn3.HeaderText = "DESCRICAO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // qUANTIDADEALUGADADataGridViewTextBoxColumn
            // 
            this.qUANTIDADEALUGADADataGridViewTextBoxColumn.DataPropertyName = "QUANTIDADE_ALUGADA";
            this.qUANTIDADEALUGADADataGridViewTextBoxColumn.HeaderText = "QUANTIDADE_ALUGADA";
            this.qUANTIDADEALUGADADataGridViewTextBoxColumn.Name = "qUANTIDADEALUGADADataGridViewTextBoxColumn";
            this.qUANTIDADEALUGADADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAALUGUELDataGridViewTextBoxColumn
            // 
            this.dATAALUGUELDataGridViewTextBoxColumn.DataPropertyName = "DATA_ALUGUEL";
            this.dATAALUGUELDataGridViewTextBoxColumn.HeaderText = "DATA_ALUGUEL";
            this.dATAALUGUELDataGridViewTextBoxColumn.Name = "dATAALUGUELDataGridViewTextBoxColumn";
            this.dATAALUGUELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEDEVOLUCAODataGridViewTextBoxColumn
            // 
            this.dATEDEVOLUCAODataGridViewTextBoxColumn.DataPropertyName = "DATE_DEVOLUCAO";
            this.dATEDEVOLUCAODataGridViewTextBoxColumn.HeaderText = "DATE_DEVOLUCAO";
            this.dATEDEVOLUCAODataGridViewTextBoxColumn.Name = "dATEDEVOLUCAODataGridViewTextBoxColumn";
            this.dATEDEVOLUCAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hISTORICOBindingSource2
            // 
            this.hISTORICOBindingSource2.DataMember = "HISTORICO";
            this.hISTORICOBindingSource2.DataSource = this.detalhesPedido1BindingSource;
            // 
            // detalhesPedido1BindingSource
            // 
            this.detalhesPedido1BindingSource.DataSource = this.detalhesPedido1;
            this.detalhesPedido1BindingSource.Position = 0;
            // 
            // detalhesPedido1
            // 
            this.detalhesPedido1.DataSetName = "DetalhesPedido";
            this.detalhesPedido1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hISTORICOBindingSource1
            // 
            this.hISTORICOBindingSource1.DataMember = "HISTORICO";
            this.hISTORICOBindingSource1.DataSource = this.detalhesPedido1BindingSource;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataSource = typeof(NovaOpcao.Estoque);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // hISTORICOTableAdapter
            // 
            this.hISTORICOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = NovaOpcao.DetalhesPedidoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hISTORICOBindingSource
            // 
            this.hISTORICOBindingSource.DataMember = "HISTORICO";
            this.hISTORICOBindingSource.DataSource = this.detalhesPedido1;
            // 
            // hISTORICOBindingSource3
            // 
            this.hISTORICOBindingSource3.DataMember = "HISTORICO";
            this.hISTORICOBindingSource3.DataSource = this.detalhesPedido1BindingSource;
            // 
            // cLIENTEBindingSource1
            // 
            this.cLIENTEBindingSource1.DataMember = "CLIENTE";
            this.cLIENTEBindingSource1.DataSource = this.retornaNome;
            // 
            // retornaNome
            // 
            this.retornaNome.DataSetName = "RetornaNome";
            this.retornaNome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.nOVAOPCAODBDataSet6;
            // 
            // nOVAOPCAODBDataSet6
            // 
            this.nOVAOPCAODBDataSet6.DataSetName = "NOVAOPCAODBDataSet6";
            this.nOVAOPCAODBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hISTORICOBindingSource4
            // 
            this.hISTORICOBindingSource4.DataMember = "HISTORICO";
            this.hISTORICOBindingSource4.DataSource = this.detalhesPedido1BindingSource;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTETableAdapter1
            // 
            this.cLIENTETableAdapter1.ClearBeforeFill = true;
            // 
            // DataFiltro
            // 
            this.DataFiltro.Location = new System.Drawing.Point(90, 0);
            this.DataFiltro.Name = "DataFiltro";
            this.DataFiltro.Size = new System.Drawing.Size(272, 20);
            this.DataFiltro.TabIndex = 14;
            // 
            // fillDADOSToolStripButton1
            // 
            this.fillDADOSToolStripButton1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.fillDADOSToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillDADOSToolStripButton1.Name = "fillDADOSToolStripButton1";
            this.fillDADOSToolStripButton1.Size = new System.Drawing.Size(72, 22);
            this.fillDADOSToolStripButton1.Text = "Filtrar Dados";
            this.fillDADOSToolStripButton1.Visible = false;
            this.fillDADOSToolStripButton1.Click += new System.EventHandler(this.fillDADOSToolStripButton1_Click);
            // 
            // fillDADOSToolStrip1
            // 
            this.fillDADOSToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillDADOSToolStripButton1});
            this.fillDADOSToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillDADOSToolStrip1.Name = "fillDADOSToolStrip1";
            this.fillDADOSToolStrip1.Size = new System.Drawing.Size(813, 25);
            this.fillDADOSToolStrip1.TabIndex = 15;
            this.fillDADOSToolStrip1.Text = "fillDADOSToolStrip1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.fillDADOSToolStripButton1_Click);
            // 
            // DetalhePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 441);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.fillDADOSToolStrip1);
            this.Controls.Add(this.DataFiltro);
            this.Controls.Add(this.DetalhesPedido);
            this.Controls.Add(this.label4);
            this.Name = "DetalhePedido";
            this.Text = "DetalhePedido";
            this.Load += new System.EventHandler(this.fillDADOSToolStripButton1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DetalhesPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORICOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalhesPedido1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalhesPedido1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORICOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORICOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORICOBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retornaNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOVAOPCAODBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORICOBindingSource4)).EndInit();
            this.fillDADOSToolStrip1.ResumeLayout(false);
            this.fillDADOSToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DetalhesPedido;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private DetalhesPedido detalhesPedido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DetalhesPedidoTableAdapters.HISTORICOTableAdapter hISTORICOTableAdapter;
        private DetalhesPedidoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE_ALUGADA;
        private System.Windows.Forms.BindingSource detalhesPedido1BindingSource;
        private System.Windows.Forms.BindingSource hISTORICOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hISTORICOBindingSource1;
        private System.Windows.Forms.BindingSource hISTORICOBindingSource2;
        private System.Windows.Forms.BindingSource hISTORICOBindingSource3;
        private System.Windows.Forms.BindingSource hISTORICOBindingSource4;
        private NOVAOPCAODBDataSet6 nOVAOPCAODBDataSet6;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private NOVAOPCAODBDataSet6TableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private RetornaNome retornaNome;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource1;
        private RetornaNomeTableAdapters.CLIENTETableAdapter cLIENTETableAdapter1;
        private System.Windows.Forms.DateTimePicker DataFiltro;
        private System.Windows.Forms.ToolStripButton fillDADOSToolStripButton1;
        private System.Windows.Forms.ToolStrip fillDADOSToolStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTIDADEALUGADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAALUGUELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDEVOLUCAODataGridViewTextBoxColumn;
    }
}