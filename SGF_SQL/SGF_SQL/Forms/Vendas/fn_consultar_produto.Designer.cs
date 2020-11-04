namespace SGF_SQL
{
    partial class fn_consultar_produto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fn_consultar_produto));
            this.pnBarraTitulo = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProdutos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pcImagem = new System.Windows.Forms.PictureBox();
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.pcRefresh = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.pcSearch = new System.Windows.Forms.PictureBox();
            this.txtPrPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagem)).BeginInit();
            this.groupBoxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).BeginInit();
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
            this.pnBarraTitulo.Size = new System.Drawing.Size(1044, 47);
            this.pnBarraTitulo.TabIndex = 10;
            this.pnBarraTitulo.TabStop = true;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.DarkGray;
            this.lbTime.Location = new System.Drawing.Point(14, 13);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(150, 24);
            this.lbTime.TabIndex = 16;
            this.lbTime.Text = "Consultar Produtos";
            // 
            // pcClose
            // 
            this.pcClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClose.Image = global::SGF_SQL.Properties.Resources.Cancel_64pxs;
            this.pcClose.Location = new System.Drawing.Point(996, 1);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(46, 45);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcClose.TabIndex = 15;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Controls.Add(this.pcImagem);
            this.groupBox1.Controls.Add(this.groupBoxPesquisa);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 502);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de produtos";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtQuantidade.Location = new System.Drawing.Point(116, 146);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(138, 26);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.Text = "0";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel1.Location = new System.Drawing.Point(116, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 2);
            this.panel1.TabIndex = 153;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label1.Location = new System.Drawing.Point(20, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 154;
            this.label1.Text = "Quantidade:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.DoubleBuffered = true;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.GridColor = System.Drawing.Color.White;
            this.dgvProdutos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.dgvProdutos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvProdutos.Location = new System.Drawing.Point(13, 184);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProdutos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProdutos.RowTemplate.Height = 30;
            this.dgvProdutos.Size = new System.Drawing.Size(990, 312);
            this.dgvProdutos.TabIndex = 4;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvProdutos_KeyUp);
            // 
            // pcImagem
            // 
            this.pcImagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcImagem.Location = new System.Drawing.Point(15, 25);
            this.pcImagem.Name = "pcImagem";
            this.pcImagem.Size = new System.Drawing.Size(77, 67);
            this.pcImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImagem.TabIndex = 128;
            this.pcImagem.TabStop = false;
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPesquisa.Controls.Add(this.pcRefresh);
            this.groupBoxPesquisa.Controls.Add(this.panel3);
            this.groupBoxPesquisa.Controls.Add(this.panel4);
            this.groupBoxPesquisa.Controls.Add(this.cboxTipo);
            this.groupBoxPesquisa.Controls.Add(this.pcSearch);
            this.groupBoxPesquisa.Controls.Add(this.txtPrPesquisa);
            this.groupBoxPesquisa.Controls.Add(this.label2);
            this.groupBoxPesquisa.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.groupBoxPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.groupBoxPesquisa.Location = new System.Drawing.Point(96, 35);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(914, 59);
            this.groupBoxPesquisa.TabIndex = 127;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Área de pesquisa";
            // 
            // pcRefresh
            // 
            this.pcRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcRefresh.Image = global::SGF_SQL.Properties.Resources.Restart_50px;
            this.pcRefresh.Location = new System.Drawing.Point(875, 22);
            this.pcRefresh.Name = "pcRefresh";
            this.pcRefresh.Size = new System.Drawing.Size(26, 28);
            this.pcRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcRefresh.TabIndex = 130;
            this.pcRefresh.TabStop = false;
            this.pcRefresh.Click += new System.EventHandler(this.pcRefresh_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel3.Location = new System.Drawing.Point(59, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 2);
            this.panel3.TabIndex = 129;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel4.Location = new System.Drawing.Point(235, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(595, 2);
            this.panel4.TabIndex = 128;
            // 
            // cboxTipo
            // 
            this.cboxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxTipo.BackColor = System.Drawing.Color.White;
            this.cboxTipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboxTipo.DisplayMember = "id";
            this.cboxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxTipo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.cboxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Items.AddRange(new object[] {
            "id",
            "codigo",
            "categoria",
            "nome"});
            this.cboxTipo.Location = new System.Drawing.Point(59, 23);
            this.cboxTipo.MaxLength = 9;
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(160, 28);
            this.cboxTipo.TabIndex = 5;
            this.cboxTipo.ValueMember = "id";
            this.cboxTipo.SelectedIndexChanged += new System.EventHandler(this.cboxTipo_SelectedIndexChanged);
            // 
            // pcSearch
            // 
            this.pcSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcSearch.Image = global::SGF_SQL.Properties.Resources.Search_52px;
            this.pcSearch.Location = new System.Drawing.Point(836, 23);
            this.pcSearch.Name = "pcSearch";
            this.pcSearch.Size = new System.Drawing.Size(26, 28);
            this.pcSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSearch.TabIndex = 7;
            this.pcSearch.TabStop = false;
            // 
            // txtPrPesquisa
            // 
            this.txtPrPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrPesquisa.BackColor = System.Drawing.Color.White;
            this.txtPrPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrPesquisa.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtPrPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtPrPesquisa.Location = new System.Drawing.Point(235, 24);
            this.txtPrPesquisa.Name = "txtPrPesquisa";
            this.txtPrPesquisa.Size = new System.Drawing.Size(595, 26);
            this.txtPrPesquisa.TabIndex = 1;
            this.txtPrPesquisa.TextChanged += new System.EventHandler(this.txtPrPesquisa_TextChanged_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 29);
            this.label2.TabIndex = 125;
            this.label2.Text = "Tipo:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnBarraTitulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // fn_consultar_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1044, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fn_consultar_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fn_consultar_produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_consultar_produto_FormClosing);
            this.Load += new System.EventHandler(this.fn_consultar_produto_Load);
            this.pnBarraTitulo.ResumeLayout(false);
            this.pnBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagem)).EndInit();
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBarraTitulo;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pcClose;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgvProdutos;
        private System.Windows.Forms.PictureBox pcImagem;
        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.PictureBox pcRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.PictureBox pcSearch;
        private System.Windows.Forms.TextBox txtPrPesquisa;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}