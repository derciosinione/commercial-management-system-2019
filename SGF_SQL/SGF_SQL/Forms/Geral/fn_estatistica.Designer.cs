namespace SGF_SQL
{
    partial class fn_estatistica
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fn_estatistica));
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtos_entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtos1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pn_venda = new System.Windows.Forms.Panel();
            this.rpV_vendas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPesquVenda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtAnoVenda = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtMesVenda = new System.Windows.Forms.TextBox();
            this.pn_funcionarios = new System.Windows.Forms.Panel();
            this.rp_funcionarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pn_produtos_entrada = new System.Windows.Forms.Panel();
            this.rp_Entrada_produtos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquiEntrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAno_entrada = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMes_entrada = new System.Windows.Forms.TextBox();
            this.pn_produtos = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtos_entradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtos1BindingSource)).BeginInit();
            this.pn_venda.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pn_funcionarios.SuspendLayout();
            this.pn_produtos_entrada.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn_produtos.SuspendLayout();
            this.SuspendLayout();
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            // 
            // db_farmaciaDataSet
            // 
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            // 
            // produtos_entradaBindingSource
            // 
            this.produtos_entradaBindingSource.DataMember = "produtos_entrada";
            // 
            // produtos1BindingSource
            // 
            this.produtos1BindingSource.DataMember = "produtos1";
            // 
            // pn_venda
            // 
            this.pn_venda.Controls.Add(this.rpV_vendas);
            this.pn_venda.Controls.Add(this.panel4);
            this.pn_venda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_venda.Location = new System.Drawing.Point(0, 0);
            this.pn_venda.Name = "pn_venda";
            this.pn_venda.Size = new System.Drawing.Size(694, 573);
            this.pn_venda.TabIndex = 0;
            // 
            // rpV_vendas
            // 
            this.rpV_vendas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.produtosBindingSource;
            this.rpV_vendas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpV_vendas.LocalReport.ReportEmbeddedResource = "SGF_SQL.Roport.rp_produtos_fatura.rdlc";
            this.rpV_vendas.Location = new System.Drawing.Point(0, 64);
            this.rpV_vendas.Name = "rpV_vendas";
            this.rpV_vendas.Size = new System.Drawing.Size(694, 509);
            this.rpV_vendas.TabIndex = 0;
            this.rpV_vendas.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPesquVenda);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.txtAnoVenda);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.txtMesVenda);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 64);
            this.panel4.TabIndex = 2;
            // 
            // btnPesquVenda
            // 
            this.btnPesquVenda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPesquVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btnPesquVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquVenda.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquVenda.ForeColor = System.Drawing.Color.Silver;
            this.btnPesquVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquVenda.Location = new System.Drawing.Point(350, 22);
            this.btnPesquVenda.Name = "btnPesquVenda";
            this.btnPesquVenda.Size = new System.Drawing.Size(96, 31);
            this.btnPesquVenda.TabIndex = 187;
            this.btnPesquVenda.Text = "pesquisar";
            this.btnPesquVenda.UseVisualStyleBackColor = false;
            this.btnPesquVenda.Click += new System.EventHandler(this.btnPesquVenda_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(21, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 29);
            this.label3.TabIndex = 186;
            this.label3.Text = "Mês:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(185, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 29);
            this.label4.TabIndex = 185;
            this.label4.Text = "Ano:";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel6.Location = new System.Drawing.Point(234, 49);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(96, 2);
            this.panel6.TabIndex = 184;
            // 
            // txtAnoVenda
            // 
            this.txtAnoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAnoVenda.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnoVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnoVenda.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtAnoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtAnoVenda.Location = new System.Drawing.Point(233, 21);
            this.txtAnoVenda.Name = "txtAnoVenda";
            this.txtAnoVenda.Size = new System.Drawing.Size(96, 26);
            this.txtAnoVenda.TabIndex = 183;
            this.txtAnoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel7.Location = new System.Drawing.Point(71, 46);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(94, 2);
            this.panel7.TabIndex = 182;
            // 
            // txtMesVenda
            // 
            this.txtMesVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMesVenda.BackColor = System.Drawing.SystemColors.Control;
            this.txtMesVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMesVenda.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtMesVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtMesVenda.Location = new System.Drawing.Point(71, 18);
            this.txtMesVenda.Name = "txtMesVenda";
            this.txtMesVenda.Size = new System.Drawing.Size(95, 26);
            this.txtMesVenda.TabIndex = 181;
            this.txtMesVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pn_funcionarios
            // 
            this.pn_funcionarios.Controls.Add(this.rp_funcionarios);
            this.pn_funcionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_funcionarios.Location = new System.Drawing.Point(0, 0);
            this.pn_funcionarios.Name = "pn_funcionarios";
            this.pn_funcionarios.Size = new System.Drawing.Size(694, 573);
            this.pn_funcionarios.TabIndex = 1;
            // 
            // rp_funcionarios
            // 
            this.rp_funcionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.funcionariosBindingSource;
            this.rp_funcionarios.LocalReport.DataSources.Add(reportDataSource2);
            this.rp_funcionarios.LocalReport.ReportEmbeddedResource = "SGF_SQL.Roport.rp_funcionarios.rdlc";
            this.rp_funcionarios.Location = new System.Drawing.Point(0, 0);
            this.rp_funcionarios.Name = "rp_funcionarios";
            this.rp_funcionarios.Size = new System.Drawing.Size(694, 573);
            this.rp_funcionarios.TabIndex = 0;
            this.rp_funcionarios.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 573);
            this.panel3.TabIndex = 2;
            // 
            // pn_produtos_entrada
            // 
            this.pn_produtos_entrada.Controls.Add(this.rp_Entrada_produtos);
            this.pn_produtos_entrada.Controls.Add(this.panel1);
            this.pn_produtos_entrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_produtos_entrada.Location = new System.Drawing.Point(0, 0);
            this.pn_produtos_entrada.Name = "pn_produtos_entrada";
            this.pn_produtos_entrada.Size = new System.Drawing.Size(694, 573);
            this.pn_produtos_entrada.TabIndex = 3;
            // 
            // rp_Entrada_produtos
            // 
            this.rp_Entrada_produtos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.produtos_entradaBindingSource;
            this.rp_Entrada_produtos.LocalReport.DataSources.Add(reportDataSource3);
            this.rp_Entrada_produtos.LocalReport.ReportEmbeddedResource = "SGF_SQL.Roport.rp_produtos_entrada.rdlc";
            this.rp_Entrada_produtos.Location = new System.Drawing.Point(0, 64);
            this.rp_Entrada_produtos.Name = "rp_Entrada_produtos";
            this.rp_Entrada_produtos.Size = new System.Drawing.Size(694, 509);
            this.rp_Entrada_produtos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPesquiEntrada);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtAno_entrada);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtMes_entrada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 64);
            this.panel1.TabIndex = 1;
            // 
            // btnPesquiEntrada
            // 
            this.btnPesquiEntrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPesquiEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btnPesquiEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquiEntrada.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquiEntrada.ForeColor = System.Drawing.Color.Silver;
            this.btnPesquiEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquiEntrada.Location = new System.Drawing.Point(350, 22);
            this.btnPesquiEntrada.Name = "btnPesquiEntrada";
            this.btnPesquiEntrada.Size = new System.Drawing.Size(96, 31);
            this.btnPesquiEntrada.TabIndex = 187;
            this.btnPesquiEntrada.Text = "pesquisar";
            this.btnPesquiEntrada.UseVisualStyleBackColor = false;
            this.btnPesquiEntrada.Click += new System.EventHandler(this.btnPesquiEntrada_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 186;
            this.label1.Text = "Mês:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(185, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 29);
            this.label2.TabIndex = 185;
            this.label2.Text = "Ano:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel2.Location = new System.Drawing.Point(234, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 2);
            this.panel2.TabIndex = 184;
            // 
            // txtAno_entrada
            // 
            this.txtAno_entrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAno_entrada.BackColor = System.Drawing.SystemColors.Control;
            this.txtAno_entrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAno_entrada.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtAno_entrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtAno_entrada.Location = new System.Drawing.Point(233, 21);
            this.txtAno_entrada.Name = "txtAno_entrada";
            this.txtAno_entrada.Size = new System.Drawing.Size(96, 26);
            this.txtAno_entrada.TabIndex = 183;
            this.txtAno_entrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel5.Location = new System.Drawing.Point(71, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(94, 2);
            this.panel5.TabIndex = 182;
            // 
            // txtMes_entrada
            // 
            this.txtMes_entrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMes_entrada.BackColor = System.Drawing.SystemColors.Control;
            this.txtMes_entrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMes_entrada.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.txtMes_entrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtMes_entrada.Location = new System.Drawing.Point(71, 18);
            this.txtMes_entrada.Name = "txtMes_entrada";
            this.txtMes_entrada.Size = new System.Drawing.Size(95, 26);
            this.txtMes_entrada.TabIndex = 181;
            this.txtMes_entrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pn_produtos
            // 
            this.pn_produtos.Controls.Add(this.reportViewer1);
            this.pn_produtos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_produtos.Location = new System.Drawing.Point(0, 0);
            this.pn_produtos.Name = "pn_produtos";
            this.pn_produtos.Size = new System.Drawing.Size(694, 573);
            this.pn_produtos.TabIndex = 4;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.produtos1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGF_SQL.Roport.rp_produtos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(694, 573);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // 
            // 
            // fn_estatistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 573);
            this.Controls.Add(this.pn_venda);
            this.Controls.Add(this.pn_produtos);
            this.Controls.Add(this.pn_produtos_entrada);
            this.Controls.Add(this.pn_funcionarios);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fn_estatistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_estatistica_FormClosing);
            this.Load += new System.EventHandler(this.fn_estatistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtos_entradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtos1BindingSource)).EndInit();
            this.pn_venda.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pn_funcionarios.ResumeLayout(false);
            this.pn_produtos_entrada.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_produtos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_venda;
        private System.Windows.Forms.Panel pn_funcionarios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pn_produtos_entrada;
        private System.Windows.Forms.Panel pn_produtos;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource produtos1BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rpV_vendas;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rp_Entrada_produtos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquiEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAno_entrada;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMes_entrada;
        private System.Windows.Forms.BindingSource produtos_entradaBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPesquVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtAnoVenda;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtMesVenda;
        private Microsoft.Reporting.WinForms.ReportViewer rp_funcionarios;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;








    }
}