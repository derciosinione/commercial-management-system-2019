namespace SGF_SQL
{
    partial class fn_Pr_inform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fn_Pr_inform));
            this.pnBarraTitulo = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.pcProduto = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.dgvPrEntrada = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pcAddprodutos = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pcRefresh = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.pcPesquisa = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pcSeguinte = new System.Windows.Forms.PictureBox();
            this.pcBack = new System.Windows.Forms.PictureBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.pnBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAddprodutos)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSeguinte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBarraTitulo
            // 
            this.pnBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.pnBarraTitulo.Controls.Add(this.lbTime);
            this.pnBarraTitulo.Controls.Add(this.pcClose);
            this.pnBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnBarraTitulo.Name = "pnBarraTitulo";
            this.pnBarraTitulo.Size = new System.Drawing.Size(966, 47);
            this.pnBarraTitulo.TabIndex = 4;
            this.pnBarraTitulo.TabStop = true;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.DarkGray;
            this.lbTime.Location = new System.Drawing.Point(14, 13);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(162, 24);
            this.lbTime.TabIndex = 16;
            this.lbTime.Text = "Produto Selecionado";
            // 
            // pcClose
            // 
            this.pcClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClose.Image = global::SGF_SQL.Properties.Resources.Cancel_64pxs;
            this.pcClose.Location = new System.Drawing.Point(918, 0);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(46, 45);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcClose.TabIndex = 15;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // pcProduto
            // 
            this.pcProduto.BackColor = System.Drawing.Color.Gainsboro;
            this.pcProduto.Location = new System.Drawing.Point(9, 67);
            this.pcProduto.Name = "pcProduto";
            this.pcProduto.Size = new System.Drawing.Size(132, 112);
            this.pcProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcProduto.TabIndex = 12;
            this.pcProduto.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel8.ForeColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(255, 135);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(238, 2);
            this.panel8.TabIndex = 15;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtCodigo.Location = new System.Drawing.Point(255, 111);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(238, 26);
            this.txtCodigo.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(147, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Código:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(684, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 2);
            this.panel1.TabIndex = 18;
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.SystemColors.Control;
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProduto.Enabled = false;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtProduto.Location = new System.Drawing.Point(684, 74);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(219, 26);
            this.txtProduto.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(584, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(147, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Control;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtId.Location = new System.Drawing.Point(255, 74);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(238, 26);
            this.txtId.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(255, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 2);
            this.panel2.TabIndex = 15;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.Control;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.Enabled = false;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtPreco.Location = new System.Drawing.Point(684, 147);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(222, 26);
            this.txtPreco.TabIndex = 22;
            this.txtPreco.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(684, 174);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(222, 2);
            this.panel5.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(584, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Preço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(584, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtCategoria.Location = new System.Drawing.Point(684, 111);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(219, 26);
            this.txtCategoria.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(684, 137);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(219, 2);
            this.panel7.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(153, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 29);
            this.label10.TabIndex = 29;
            this.label10.Text = "Stock:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel10.ForeColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(255, 172);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(238, 2);
            this.panel10.TabIndex = 30;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Control;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtStock.Location = new System.Drawing.Point(255, 145);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(238, 26);
            this.txtStock.TabIndex = 22;
            this.txtStock.Text = "0";
            // 
            // dgvPrEntrada
            // 
            this.dgvPrEntrada.AllowUserToAddRows = false;
            this.dgvPrEntrada.AllowUserToDeleteRows = false;
            this.dgvPrEntrada.AllowUserToResizeColumns = false;
            this.dgvPrEntrada.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPrEntrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrEntrada.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvPrEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrEntrada.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrEntrada.DoubleBuffered = true;
            this.dgvPrEntrada.EnableHeadersVisualStyles = false;
            this.dgvPrEntrada.GridColor = System.Drawing.Color.White;
            this.dgvPrEntrada.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.dgvPrEntrada.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPrEntrada.Location = new System.Drawing.Point(28, 327);
            this.dgvPrEntrada.Name = "dgvPrEntrada";
            this.dgvPrEntrada.ReadOnly = true;
            this.dgvPrEntrada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrEntrada.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrEntrada.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrEntrada.RowTemplate.Height = 30;
            this.dgvPrEntrada.Size = new System.Drawing.Size(916, 259);
            this.dgvPrEntrada.TabIndex = 153;
            this.dgvPrEntrada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrEntrada_CellClick);
            // 
            // pcAddprodutos
            // 
            this.pcAddprodutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcAddprodutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcAddprodutos.Image = ((System.Drawing.Image)(resources.GetObject("pcAddprodutos.Image")));
            this.pcAddprodutos.Location = new System.Drawing.Point(7, 19);
            this.pcAddprodutos.Name = "pcAddprodutos";
            this.pcAddprodutos.Size = new System.Drawing.Size(38, 35);
            this.pcAddprodutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcAddprodutos.TabIndex = 152;
            this.pcAddprodutos.TabStop = false;
            this.pcAddprodutos.Click += new System.EventHandler(this.pcAddprodutos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.pcRefresh);
            this.groupBox4.Controls.Add(this.panel11);
            this.groupBox4.Controls.Add(this.pcAddprodutos);
            this.groupBox4.Controls.Add(this.panel12);
            this.groupBox4.Controls.Add(this.cboxTipo);
            this.groupBox4.Controls.Add(this.pcPesquisa);
            this.groupBox4.Controls.Add(this.txtPesquisa);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.groupBox4.Location = new System.Drawing.Point(26, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(916, 59);
            this.groupBox4.TabIndex = 155;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Área de pesquisa";
            // 
            // pcRefresh
            // 
            this.pcRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcRefresh.Image = global::SGF_SQL.Properties.Resources.Restart_50px;
            this.pcRefresh.Location = new System.Drawing.Point(881, 22);
            this.pcRefresh.Name = "pcRefresh";
            this.pcRefresh.Size = new System.Drawing.Size(26, 28);
            this.pcRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcRefresh.TabIndex = 130;
            this.pcRefresh.TabStop = false;
            this.pcRefresh.Click += new System.EventHandler(this.pcRefresh_Click);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel11.Location = new System.Drawing.Point(108, 51);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(160, 2);
            this.panel11.TabIndex = 129;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel12.Location = new System.Drawing.Point(274, 51);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(562, 2);
            this.panel12.TabIndex = 128;
            // 
            // cboxTipo
            // 
            this.cboxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxTipo.BackColor = System.Drawing.SystemColors.Control;
            this.cboxTipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboxTipo.DisplayMember = "id";
            this.cboxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxTipo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.cboxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Items.AddRange(new object[] {
            "volume",
            "data de fabricação",
            "data de validade",
            "custus",
            "data de entrada"});
            this.cboxTipo.Location = new System.Drawing.Point(108, 23);
            this.cboxTipo.MaxLength = 9;
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(160, 28);
            this.cboxTipo.TabIndex = 126;
            this.cboxTipo.ValueMember = "id";
            // 
            // pcPesquisa
            // 
            this.pcPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcPesquisa.Image = global::SGF_SQL.Properties.Resources.Search_52px;
            this.pcPesquisa.Location = new System.Drawing.Point(842, 23);
            this.pcPesquisa.Name = "pcPesquisa";
            this.pcPesquisa.Size = new System.Drawing.Size(26, 28);
            this.pcPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPesquisa.TabIndex = 7;
            this.pcPesquisa.TabStop = false;
            this.pcPesquisa.Click += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtPesquisa.Location = new System.Drawing.Point(274, 24);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(562, 26);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label12.Location = new System.Drawing.Point(56, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 29);
            this.label12.TabIndex = 125;
            this.label12.Text = "Tipo:";
            // 
            // pcSeguinte
            // 
            this.pcSeguinte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcSeguinte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcSeguinte.Image = global::SGF_SQL.Properties.Resources.Forward_48px;
            this.pcSeguinte.Location = new System.Drawing.Point(918, 589);
            this.pcSeguinte.Name = "pcSeguinte";
            this.pcSeguinte.Size = new System.Drawing.Size(25, 24);
            this.pcSeguinte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSeguinte.TabIndex = 158;
            this.pcSeguinte.TabStop = false;
            // 
            // pcBack
            // 
            this.pcBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBack.Image = global::SGF_SQL.Properties.Resources.Back_50px;
            this.pcBack.Location = new System.Drawing.Point(871, 589);
            this.pcBack.Name = "pcBack";
            this.pcBack.Size = new System.Drawing.Size(25, 24);
            this.pcBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBack.TabIndex = 157;
            this.pcBack.TabStop = false;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.lbTotal.Location = new System.Drawing.Point(26, 590);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(115, 29);
            this.lbTotal.TabIndex = 156;
            this.lbTotal.Text = "Total: 20 de 40";
            // 
            // fn_Pr_inform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(966, 618);
            this.Controls.Add(this.pcSeguinte);
            this.Controls.Add(this.pcBack);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvPrEntrada);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pcProduto);
            this.Controls.Add(this.pnBarraTitulo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fn_Pr_inform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fn_Pr_inform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_Pr_inform_FormClosing);
            this.Load += new System.EventHandler(this.fn_Pr_inform_Load);
            this.pnBarraTitulo.ResumeLayout(false);
            this.pnBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAddprodutos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSeguinte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBarraTitulo;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pcClose;
        private System.Windows.Forms.PictureBox pcProduto;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtStock;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgvPrEntrada;
        private System.Windows.Forms.PictureBox pcAddprodutos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pcRefresh;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.PictureBox pcPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pcSeguinte;
        private System.Windows.Forms.PictureBox pcBack;
        private System.Windows.Forms.Label lbTotal;
    }
}