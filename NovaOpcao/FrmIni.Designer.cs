namespace NovaOpcao
{
    partial class FrmIni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIni));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.versaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progresso = new System.Windows.Forms.ToolStripProgressBar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.DadosHistorico = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btfornecedor = new System.Windows.Forms.Button();
            this.btnovocliente = new System.Windows.Forms.Button();
            this.btnovoproduto = new System.Windows.Forms.Button();
            this.btlocar = new System.Windows.Forms.Button();
            this.NOVAOPCAODBDataSet = new NovaOpcao.NOVAOPCAODBDataSet();
            this.PRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRODUTOSTableAdapter = new NovaOpcao.NOVAOPCAODBDataSetTableAdapters.PRODUTOSTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NOVAOPCAODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.toolStripMenuItem3,
            this.clienteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saiToolStripMenuItem});
            this.gerenciarToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.chart_bar;
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.cadastrarProdutosToolStripMenuItem});
            this.estoqueToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.book;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.book_edit;
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.entradasToolStripMenuItem.Text = "Gerenciar Estoque";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // cadastrarProdutosToolStripMenuItem
            // 
            this.cadastrarProdutosToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.book_add;
            this.cadastrarProdutosToolStripMenuItem.Name = "cadastrarProdutosToolStripMenuItem";
            this.cadastrarProdutosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cadastrarProdutosToolStripMenuItem.Text = "Cadastrar Produtos";
            this.cadastrarProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutosToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarFornecedoresToolStripMenuItem,
            this.novoFornecedorToolStripMenuItem});
            this.fornecedorToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.building;
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // gerenciarFornecedoresToolStripMenuItem
            // 
            this.gerenciarFornecedoresToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.building_edit;
            this.gerenciarFornecedoresToolStripMenuItem.Name = "gerenciarFornecedoresToolStripMenuItem";
            this.gerenciarFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.gerenciarFornecedoresToolStripMenuItem.Text = "Gerenciar Fornecedores";
            // 
            // novoFornecedorToolStripMenuItem
            // 
            this.novoFornecedorToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.building_add;
            this.novoFornecedorToolStripMenuItem.Name = "novoFornecedorToolStripMenuItem";
            this.novoFornecedorToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.novoFornecedorToolStripMenuItem.Text = "Novo Fornecedor";
            this.novoFornecedorToolStripMenuItem.Click += new System.EventHandler(this.novoFornecedorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::NovaOpcao.Properties.Resources.cart;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem3.Text = "Alugar";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.user;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.user_add;
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(131, 6);
            // 
            // saiToolStripMenuItem
            // 
            this.saiToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.cancel;
            this.saiToolStripMenuItem.Name = "saiToolStripMenuItem";
            this.saiToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saiToolStripMenuItem.Text = "&Sair";
            this.saiToolStripMenuItem.Click += new System.EventHandler(this.saiToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.report;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.user_gray;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.lorry;
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.email;
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOProgramaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.versaoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.help;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreOProgramaToolStripMenuItem
            // 
            this.sobreOProgramaToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.application_cascade;
            this.sobreOProgramaToolStripMenuItem.Name = "sobreOProgramaToolStripMenuItem";
            this.sobreOProgramaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.sobreOProgramaToolStripMenuItem.Text = "Sobre o Programa";
            this.sobreOProgramaToolStripMenuItem.Click += new System.EventHandler(this.sobreOProgramaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
            // 
            // versaoToolStripMenuItem
            // 
            this.versaoToolStripMenuItem.Image = global::NovaOpcao.Properties.Resources.key;
            this.versaoToolStripMenuItem.Name = "versaoToolStripMenuItem";
            this.versaoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.versaoToolStripMenuItem.Text = "Versão";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progresso});
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(927, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progresso
            // 
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(100, 16);
            this.progresso.Step = 1;
            this.progresso.Value = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 52);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Red;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eventos Diários:";
            // 
            // DadosHistorico
            // 
            this.DadosHistorico.ColumnWidth = 2;
            this.DadosHistorico.FormattingEnabled = true;
            this.DadosHistorico.HorizontalExtent = 2;
            this.DadosHistorico.HorizontalScrollbar = true;
            this.DadosHistorico.Location = new System.Drawing.Point(303, 93);
            this.DadosHistorico.MultiColumn = true;
            this.DadosHistorico.Name = "DadosHistorico";
            this.DadosHistorico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DadosHistorico.ScrollAlwaysVisible = true;
            this.DadosHistorico.Size = new System.Drawing.Size(573, 121);
            this.DadosHistorico.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btfornecedor);
            this.groupBox1.Controls.Add(this.btnovocliente);
            this.groupBox1.Controls.Add(this.btnovoproduto);
            this.groupBox1.Controls.Add(this.btlocar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(18, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eventos Comuns:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(285, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Orçamento";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enviar E-mail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btfornecedor
            // 
            this.btfornecedor.Location = new System.Drawing.Point(153, 94);
            this.btfornecedor.Name = "btfornecedor";
            this.btfornecedor.Size = new System.Drawing.Size(103, 39);
            this.btfornecedor.TabIndex = 3;
            this.btfornecedor.Text = "Novo Fornecedor";
            this.btfornecedor.UseVisualStyleBackColor = true;
            this.btfornecedor.Click += new System.EventHandler(this.btfornecedor_Click);
            // 
            // btnovocliente
            // 
            this.btnovocliente.Location = new System.Drawing.Point(17, 94);
            this.btnovocliente.Name = "btnovocliente";
            this.btnovocliente.Size = new System.Drawing.Size(103, 39);
            this.btnovocliente.TabIndex = 2;
            this.btnovocliente.Text = "Novo Cliente";
            this.btnovocliente.UseVisualStyleBackColor = true;
            this.btnovocliente.Click += new System.EventHandler(this.btnovocliente_Click);
            // 
            // btnovoproduto
            // 
            this.btnovoproduto.Location = new System.Drawing.Point(153, 36);
            this.btnovoproduto.Name = "btnovoproduto";
            this.btnovoproduto.Size = new System.Drawing.Size(103, 39);
            this.btnovoproduto.TabIndex = 1;
            this.btnovoproduto.Text = "Novo Produto";
            this.btnovoproduto.UseVisualStyleBackColor = true;
            this.btnovoproduto.Click += new System.EventHandler(this.btnovoproduto_Click);
            // 
            // btlocar
            // 
            this.btlocar.Location = new System.Drawing.Point(17, 36);
            this.btlocar.Name = "btlocar";
            this.btlocar.Size = new System.Drawing.Size(103, 39);
            this.btlocar.TabIndex = 0;
            this.btlocar.Text = "Locar Produtos";
            this.btlocar.UseVisualStyleBackColor = true;
            this.btlocar.Click += new System.EventHandler(this.btlocar_Click);
            // 
            // NOVAOPCAODBDataSet
            // 
            this.NOVAOPCAODBDataSet.DataSetName = "NOVAOPCAODBDataSet";
            this.NOVAOPCAODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PRODUTOSBindingSource
            // 
            this.PRODUTOSBindingSource.DataMember = "PRODUTOS";
            this.PRODUTOSBindingSource.DataSource = this.NOVAOPCAODBDataSet;
            // 
            // PRODUTOSTableAdapter
            // 
            this.PRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(765, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Detalhes do Pedido";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmIni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 414);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DadosHistorico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmIni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Opção Locações";
            this.Load += new System.EventHandler(this.FrmIni_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NOVAOPCAODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem versaoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progresso;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ListBox DadosHistorico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnovocliente;
        private System.Windows.Forms.Button btnovoproduto;
        private System.Windows.Forms.Button btlocar;
        private System.Windows.Forms.Button btfornecedor;
        private System.Windows.Forms.BindingSource PRODUTOSBindingSource;
        private NOVAOPCAODBDataSet NOVAOPCAODBDataSet;
        private NOVAOPCAODBDataSetTableAdapters.PRODUTOSTableAdapter PRODUTOSTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
  
    }
}

