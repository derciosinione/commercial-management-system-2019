namespace SGF_SQL
{
    partial class userVendas
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

        #region Component Designer generated code

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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTotal_vendas = new System.Windows.Forms.Label();
            this.lbCaixa = new System.Windows.Forms.Label();
            this.dgvTotVendas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.materialContextMenuStripDgv = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolStripMenuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefazerVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirtoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcSeguinte = new System.Windows.Forms.PictureBox();
            this.pcBack = new System.Windows.Forms.PictureBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.pcRefresh = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.pcSearch = new System.Windows.Forms.PictureBox();
            this.txtPrPesquisa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotVendas)).BeginInit();
            this.materialContextMenuStripDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSeguinte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBack)).BeginInit();
            this.groupBoxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lbTotal_vendas);
            this.groupBox2.Controls.Add(this.lbCaixa);
            this.groupBox2.Controls.Add(this.dgvTotVendas);
            this.groupBox2.Controls.Add(this.pcSeguinte);
            this.groupBox2.Controls.Add(this.pcBack);
            this.groupBox2.Controls.Add(this.lbTotal);
            this.groupBox2.Controls.Add(this.groupBoxPesquisa);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.groupBox2.Location = new System.Drawing.Point(10, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1242, 474);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de produtos";
            // 
            // lbTotal_vendas
            // 
            this.lbTotal_vendas.AutoSize = true;
            this.lbTotal_vendas.Font = new System.Drawing.Font("Myanmar Text", 22F);
            this.lbTotal_vendas.ForeColor = System.Drawing.Color.Gray;
            this.lbTotal_vendas.Location = new System.Drawing.Point(97, 111);
            this.lbTotal_vendas.Name = "lbTotal_vendas";
            this.lbTotal_vendas.Size = new System.Drawing.Size(76, 53);
            this.lbTotal_vendas.TabIndex = 141;
            this.lbTotal_vendas.Text = "0 kz";
            // 
            // lbCaixa
            // 
            this.lbCaixa.AutoSize = true;
            this.lbCaixa.Font = new System.Drawing.Font("Myanmar Text", 22F);
            this.lbCaixa.ForeColor = System.Drawing.Color.Gray;
            this.lbCaixa.Location = new System.Drawing.Point(14, 111);
            this.lbCaixa.Name = "lbCaixa";
            this.lbCaixa.Size = new System.Drawing.Size(100, 53);
            this.lbCaixa.TabIndex = 141;
            this.lbCaixa.Text = "Caixa:";
            this.lbCaixa.Click += new System.EventHandler(this.lbCaixa_Click);
            // 
            // dgvTotVendas
            // 
            this.dgvTotVendas.AllowUserToAddRows = false;
            this.dgvTotVendas.AllowUserToDeleteRows = false;
            this.dgvTotVendas.AllowUserToResizeColumns = false;
            this.dgvTotVendas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTotVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTotVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTotVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotVendas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTotVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTotVendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTotVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotVendas.ContextMenuStrip = this.materialContextMenuStripDgv;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotVendas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTotVendas.DoubleBuffered = true;
            this.dgvTotVendas.EnableHeadersVisualStyles = false;
            this.dgvTotVendas.GridColor = System.Drawing.Color.White;
            this.dgvTotVendas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.dgvTotVendas.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTotVendas.Location = new System.Drawing.Point(12, 166);
            this.dgvTotVendas.Name = "dgvTotVendas";
            this.dgvTotVendas.ReadOnly = true;
            this.dgvTotVendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTotVendas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTotVendas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTotVendas.RowTemplate.Height = 30;
            this.dgvTotVendas.Size = new System.Drawing.Size(1220, 281);
            this.dgvTotVendas.TabIndex = 150;
            // 
            // materialContextMenuStripDgv
            // 
            this.materialContextMenuStripDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStripDgv.Depth = 0;
            this.materialContextMenuStripDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuEliminar,
            this.CancelarVendaToolStripMenuItem,
            this.RefazerVendaToolStripMenuItem,
            this.ImprimirtoolStripMenuItem2,
            this.actualizarToolStripMenuItem});
            this.materialContextMenuStripDgv.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStripDgv.Name = "materialContextMenuStrip1";
            this.materialContextMenuStripDgv.Size = new System.Drawing.Size(161, 136);
            // 
            // toolStripMenuEliminar
            // 
            this.toolStripMenuEliminar.Image = global::SGF_SQL.Properties.Resources.Trash_Can_64px;
            this.toolStripMenuEliminar.Name = "toolStripMenuEliminar";
            this.toolStripMenuEliminar.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuEliminar.Text = "Eliminar venda";
            this.toolStripMenuEliminar.Click += new System.EventHandler(this.toolStripMenuEliminar_Click);
            // 
            // CancelarVendaToolStripMenuItem
            // 
            this.CancelarVendaToolStripMenuItem.Image = global::SGF_SQL.Properties.Resources.Trash_Can_64px;
            this.CancelarVendaToolStripMenuItem.Name = "CancelarVendaToolStripMenuItem";
            this.CancelarVendaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.CancelarVendaToolStripMenuItem.Text = "Cancelar venda";
            this.CancelarVendaToolStripMenuItem.Click += new System.EventHandler(this.CancelarVendaToolStripMenuItem_Click);
            // 
            // RefazerVendaToolStripMenuItem
            // 
            this.RefazerVendaToolStripMenuItem.Image = global::SGF_SQL.Properties.Resources.Shopping_Cart_Loaded_50px;
            this.RefazerVendaToolStripMenuItem.Name = "RefazerVendaToolStripMenuItem";
            this.RefazerVendaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.RefazerVendaToolStripMenuItem.Text = "Refazer venda";
            this.RefazerVendaToolStripMenuItem.Click += new System.EventHandler(this.RefazerVendaToolStripMenuItem_Click);
            // 
            // ImprimirtoolStripMenuItem2
            // 
            this.ImprimirtoolStripMenuItem2.Image = global::SGF_SQL.Properties.Resources.Print_52px;
            this.ImprimirtoolStripMenuItem2.Name = "ImprimirtoolStripMenuItem2";
            this.ImprimirtoolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.ImprimirtoolStripMenuItem2.Text = "Imprimir factura";
            this.ImprimirtoolStripMenuItem2.Click += new System.EventHandler(this.ImprimirtoolStripMenuItem2_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Image = global::SGF_SQL.Properties.Resources.Restart_50px;
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // pcSeguinte
            // 
            this.pcSeguinte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcSeguinte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcSeguinte.Image = global::SGF_SQL.Properties.Resources.Forward_48px;
            this.pcSeguinte.Location = new System.Drawing.Point(1206, 447);
            this.pcSeguinte.Name = "pcSeguinte";
            this.pcSeguinte.Size = new System.Drawing.Size(25, 24);
            this.pcSeguinte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSeguinte.TabIndex = 149;
            this.pcSeguinte.TabStop = false;
            this.pcSeguinte.Click += new System.EventHandler(this.pcSeguinte_Click);
            // 
            // pcBack
            // 
            this.pcBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBack.Image = global::SGF_SQL.Properties.Resources.Back_50px;
            this.pcBack.Location = new System.Drawing.Point(1159, 447);
            this.pcBack.Name = "pcBack";
            this.pcBack.Size = new System.Drawing.Size(25, 24);
            this.pcBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBack.TabIndex = 148;
            this.pcBack.TabStop = false;
            this.pcBack.Click += new System.EventHandler(this.pcBack_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.lbTotal.Location = new System.Drawing.Point(10, 447);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(96, 29);
            this.lbTotal.TabIndex = 145;
            this.lbTotal.Text = "Total: 20/40";
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPesquisa.Controls.Add(this.pcRefresh);
            this.groupBoxPesquisa.Controls.Add(this.panel8);
            this.groupBoxPesquisa.Controls.Add(this.panel9);
            this.groupBoxPesquisa.Controls.Add(this.cboxTipo);
            this.groupBoxPesquisa.Controls.Add(this.pcSearch);
            this.groupBoxPesquisa.Controls.Add(this.txtPrPesquisa);
            this.groupBoxPesquisa.Controls.Add(this.label7);
            this.groupBoxPesquisa.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.groupBoxPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.groupBoxPesquisa.Location = new System.Drawing.Point(14, 35);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(1213, 59);
            this.groupBoxPesquisa.TabIndex = 127;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Área de pesquisa";
            // 
            // pcRefresh
            // 
            this.pcRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcRefresh.Image = global::SGF_SQL.Properties.Resources.Restart_50px;
            this.pcRefresh.Location = new System.Drawing.Point(1174, 22);
            this.pcRefresh.Name = "pcRefresh";
            this.pcRefresh.Size = new System.Drawing.Size(26, 28);
            this.pcRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcRefresh.TabIndex = 130;
            this.pcRefresh.TabStop = false;
            this.pcRefresh.Click += new System.EventHandler(this.pcRefresh_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel8.Location = new System.Drawing.Point(59, 51);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(160, 2);
            this.panel8.TabIndex = 129;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel9.Location = new System.Drawing.Point(235, 51);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(894, 2);
            this.panel9.TabIndex = 128;
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
            "produto",
            "tipo",
            "venda",
            "dia",
            "mês",
            "data",
            "funcionários"});
            this.cboxTipo.Location = new System.Drawing.Point(59, 23);
            this.cboxTipo.MaxLength = 9;
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(160, 28);
            this.cboxTipo.TabIndex = 126;
            this.cboxTipo.ValueMember = "id";
            this.cboxTipo.SelectedIndexChanged += new System.EventHandler(this.cboxTipo_SelectedIndexChanged);
            // 
            // pcSearch
            // 
            this.pcSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcSearch.Image = global::SGF_SQL.Properties.Resources.Search_52px;
            this.pcSearch.Location = new System.Drawing.Point(1135, 23);
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
            this.txtPrPesquisa.Size = new System.Drawing.Size(894, 26);
            this.txtPrPesquisa.TabIndex = 4;
            this.txtPrPesquisa.TextChanged += new System.EventHandler(this.txtPrPesquisa_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 29);
            this.label7.TabIndex = 125;
            this.label7.Text = "Tipo:";
            // 
            // userVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Name = "userVendas";
            this.Size = new System.Drawing.Size(1263, 497);
            this.Load += new System.EventHandler(this.userVendas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotVendas)).EndInit();
            this.materialContextMenuStripDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcSeguinte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBack)).EndInit();
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgvTotVendas;
        private System.Windows.Forms.PictureBox pcSeguinte;
        private System.Windows.Forms.PictureBox pcBack;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotal_vendas;
        private System.Windows.Forms.Label lbCaixa;
        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.PictureBox pcRefresh;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.PictureBox pcSearch;
        private System.Windows.Forms.TextBox txtPrPesquisa;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStripDgv;
        private System.Windows.Forms.ToolStripMenuItem CancelarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefazerVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEliminar;
        private System.Windows.Forms.ToolStripMenuItem ImprimirtoolStripMenuItem2;

    }
}
