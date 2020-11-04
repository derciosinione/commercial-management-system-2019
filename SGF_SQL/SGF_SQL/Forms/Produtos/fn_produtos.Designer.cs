namespace SGF_SQL
{
    partial class fn_produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fn_produtos));
            this.pnBarraTitulo = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVerProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.materialContextMenuStripDgv = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.EditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.maisInformaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcSeguinte = new System.Windows.Forms.PictureBox();
            this.pcBack = new System.Windows.Forms.PictureBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.pcImagem = new System.Windows.Forms.PictureBox();
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.pcRefresh = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.pcSearch = new System.Windows.Forms.PictureBox();
            this.txtPrPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelProdutos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.materialContextMenuStripDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSeguinte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBack)).BeginInit();
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
            this.pnBarraTitulo.Size = new System.Drawing.Size(836, 47);
            this.pnBarraTitulo.TabIndex = 3;
            this.pnBarraTitulo.TabStop = true;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.DarkGray;
            this.lbTime.Location = new System.Drawing.Point(14, 13);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(144, 24);
            this.lbTime.TabIndex = 16;
            this.lbTime.Text = "Menu de Produtos";
            // 
            // pcClose
            // 
            this.pcClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClose.Image = global::SGF_SQL.Properties.Resources.Cancel_64pxs;
            this.pcClose.Location = new System.Drawing.Point(788, 1);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(46, 45);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcClose.TabIndex = 15;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 2);
            this.panel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem6,
            this.toolCategoria});
            this.menuStrip1.Location = new System.Drawing.Point(0, 47);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddProduto,
            this.visualizarToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.toolStripMenuItem1.Image = global::SGF_SQL.Properties.Resources.Shopping_Cart_Loaded_50px;
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 25);
            this.toolStripMenuItem1.Text = "Produtos";
            // 
            // toolAddProduto
            // 
            this.toolAddProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.toolAddProduto.Image = global::SGF_SQL.Properties.Resources.Add_File_26px;
            this.toolAddProduto.Name = "toolAddProduto";
            this.toolAddProduto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolAddProduto.Size = new System.Drawing.Size(204, 26);
            this.toolAddProduto.Text = "Adicionar";
            this.toolAddProduto.Click += new System.EventHandler(this.toolAddProduto_Click);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolVerProdutos,
            this.categoriasToolStripMenuItem});
            this.visualizarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.visualizarToolStripMenuItem.Image = global::SGF_SQL.Properties.Resources.Show_Property_52px;
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // ToolVerProdutos
            // 
            this.ToolVerProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.ToolVerProdutos.Image = global::SGF_SQL.Properties.Resources.Shopping_Cart_Loaded_50px;
            this.ToolVerProdutos.Name = "ToolVerProdutos";
            this.ToolVerProdutos.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.ToolVerProdutos.Size = new System.Drawing.Size(253, 26);
            this.ToolVerProdutos.Text = "Produtos";
            this.ToolVerProdutos.Click += new System.EventHandler(this.ToolVerProdutos_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.categoriasToolStripMenuItem.Image = global::SGF_SQL.Properties.Resources.Elective_50px;
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.toolCategoria_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.toolStripMenuItem5.Image = global::SGF_SQL.Properties.Resources.Print_52px;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(204, 26);
            this.toolStripMenuItem5.Text = "Imprimir";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.toolStripMenuItem6.Image = global::SGF_SQL.Properties.Resources.Product_50px;
            this.toolStripMenuItem6.ImageTransparentColor = System.Drawing.Color.Red;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(75, 25);
            this.toolStripMenuItem6.Text = "Stock";
            // 
            // toolCategoria
            // 
            this.toolCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.toolCategoria.Image = global::SGF_SQL.Properties.Resources.Elective_50px;
            this.toolCategoria.ImageTransparentColor = System.Drawing.Color.Red;
            this.toolCategoria.Name = "toolCategoria";
            this.toolCategoria.Size = new System.Drawing.Size(112, 25);
            this.toolCategoria.Text = "Categorias";
            this.toolCategoria.Click += new System.EventHandler(this.toolCategoria_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 655);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 25);
            this.panel2.TabIndex = 6;
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.Color.White;
            this.panelProdutos.Controls.Add(this.groupBox1);
            this.panelProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProdutos.Location = new System.Drawing.Point(0, 78);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(836, 577);
            this.panelProdutos.TabIndex = 7;
            this.panelProdutos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProdutos_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Controls.Add(this.pcSeguinte);
            this.groupBox1.Controls.Add(this.pcBack);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.pcImagem);
            this.groupBox1.Controls.Add(this.groupBoxPesquisa);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 542);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de produtos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.dgvProdutos.ContextMenuStrip = this.materialContextMenuStripDgv;
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
            this.dgvProdutos.Location = new System.Drawing.Point(12, 166);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProdutos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProdutos.RowTemplate.Height = 30;
            this.dgvProdutos.Size = new System.Drawing.Size(771, 349);
            this.dgvProdutos.TabIndex = 150;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
            this.dgvProdutos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProdutos_DataError);
            this.dgvProdutos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvProdutos_KeyUp);
            // 
            // materialContextMenuStripDgv
            // 
            this.materialContextMenuStripDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStripDgv.Depth = 0;
            this.materialContextMenuStripDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditarToolStripMenuItem,
            this.EliminarToolStripMenuItem2,
            this.maisInformaçõesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.actualizarToolStripMenuItem});
            this.materialContextMenuStripDgv.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStripDgv.Name = "materialContextMenuStrip1";
            this.materialContextMenuStripDgv.Size = new System.Drawing.Size(169, 136);
            // 
            // EditarToolStripMenuItem
            // 
            this.EditarToolStripMenuItem.Image = global::SGF_SQL.Properties.Resources.icons8_Edit_50px;
            this.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem";
            this.EditarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.EditarToolStripMenuItem.Text = "Editar";
            this.EditarToolStripMenuItem.Click += new System.EventHandler(this.EditarToolStripMenuItem_Click);
            // 
            // EliminarToolStripMenuItem2
            // 
            this.EliminarToolStripMenuItem2.Image = global::SGF_SQL.Properties.Resources.Trash_Can_64px;
            this.EliminarToolStripMenuItem2.Name = "EliminarToolStripMenuItem2";
            this.EliminarToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.EliminarToolStripMenuItem2.Text = "Eliminar";
            this.EliminarToolStripMenuItem2.Click += new System.EventHandler(this.EliminarToolStripMenuItem2_Click);
            // 
            // maisInformaçõesToolStripMenuItem
            // 
            this.maisInformaçõesToolStripMenuItem.Image = global::SGF_SQL.Properties.Resources.Show_Property_52px;
            this.maisInformaçõesToolStripMenuItem.Name = "maisInformaçõesToolStripMenuItem";
            this.maisInformaçõesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.maisInformaçõesToolStripMenuItem.Text = "Mais informações";
            this.maisInformaçõesToolStripMenuItem.Click += new System.EventHandler(this.maisInformaçõesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::SGF_SQL.Properties.Resources.icons8_Toggle_On_50px;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem3.Text = "Activar";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::SGF_SQL.Properties.Resources.icons8_Toggle_Off_50px;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem2.Text = "Desactivar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Image = global::SGF_SQL.Properties.Resources.Restart_50px;
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.pcRefresh_Click);
            // 
            // pcSeguinte
            // 
            this.pcSeguinte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcSeguinte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcSeguinte.Image = global::SGF_SQL.Properties.Resources.Forward_48px;
            this.pcSeguinte.Location = new System.Drawing.Point(757, 515);
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
            this.pcBack.Location = new System.Drawing.Point(710, 515);
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
            this.lbTotal.Location = new System.Drawing.Point(10, 515);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(96, 29);
            this.lbTotal.TabIndex = 145;
            this.lbTotal.Text = "Total: 20/40";
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
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
            this.groupBoxPesquisa.Size = new System.Drawing.Size(687, 59);
            this.groupBoxPesquisa.TabIndex = 127;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Área de pesquisa";
            this.groupBoxPesquisa.Visible = false;
            // 
            // pcRefresh
            // 
            this.pcRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcRefresh.Image = global::SGF_SQL.Properties.Resources.Restart_50px;
            this.pcRefresh.Location = new System.Drawing.Point(648, 22);
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
            this.panel4.Size = new System.Drawing.Size(368, 2);
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
            "nome",
            "stock"});
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
            this.pcSearch.Location = new System.Drawing.Point(609, 23);
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
            this.txtPrPesquisa.Size = new System.Drawing.Size(368, 26);
            this.txtPrPesquisa.TabIndex = 4;
            this.txtPrPesquisa.TextChanged += new System.EventHandler(this.txtPrPesquisa_TextChanged);
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
            // fn_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 680);
            this.Controls.Add(this.panelProdutos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fn_produtos";
            this.Text = "fn_produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_produtos_FormClosing);
            this.Load += new System.EventHandler(this.fn_produtos_Load);
            this.pnBarraTitulo.ResumeLayout(false);
            this.pnBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelProdutos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.materialContextMenuStripDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcSeguinte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagem)).EndInit();
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBarraTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolAddProduto;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolCategoria;
        private System.Windows.Forms.PictureBox pcClose;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcSeguinte;
        private System.Windows.Forms.PictureBox pcBack;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.PictureBox pcImagem;
        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.PictureBox pcRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.PictureBox pcSearch;
        private System.Windows.Forms.TextBox txtPrPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolVerProdutos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStripDgv;
        private System.Windows.Forms.ToolStripMenuItem EditarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EliminarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem maisInformaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgvProdutos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}