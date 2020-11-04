namespace SGF_SQL
{
    partial class fn_farmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fn_farmacia));
            this.pnBarraTitulo = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.pnConfigure = new System.Windows.Forms.Panel();
            this.btnSalvarInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNun_banco = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnBackUp = new System.Windows.Forms.Panel();
            this.btnOperar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbImportar = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbExportar = new MaterialSkin.Controls.MaterialRadioButton();
            this.gbxDomingo = new System.Windows.Forms.GroupBox();
            this.lbCaminho = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.pnBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            this.pnConfigure.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnBackUp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxDomingo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBarraTitulo
            // 
            this.pnBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.pnBarraTitulo.Controls.Add(this.lbTitulo);
            this.pnBarraTitulo.Controls.Add(this.pcClose);
            this.pnBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnBarraTitulo.Name = "pnBarraTitulo";
            this.pnBarraTitulo.Size = new System.Drawing.Size(605, 47);
            this.pnBarraTitulo.TabIndex = 11;
            this.pnBarraTitulo.TabStop = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lbTitulo.Location = new System.Drawing.Point(14, 13);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(184, 24);
            this.lbTitulo.TabIndex = 16;
            this.lbTitulo.Text = "Menu de Configurações";
            // 
            // pcClose
            // 
            this.pcClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClose.Image = global::SGF_SQL.Properties.Resources.Cancel_64pxs;
            this.pcClose.Location = new System.Drawing.Point(557, 1);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(46, 45);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcClose.TabIndex = 15;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // pnConfigure
            // 
            this.pnConfigure.Controls.Add(this.btnSalvarInfo);
            this.pnConfigure.Controls.Add(this.groupBox1);
            this.pnConfigure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnConfigure.Location = new System.Drawing.Point(0, 0);
            this.pnConfigure.Name = "pnConfigure";
            this.pnConfigure.Size = new System.Drawing.Size(605, 450);
            this.pnConfigure.TabIndex = 12;
            // 
            // btnSalvarInfo
            // 
            this.btnSalvarInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSalvarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btnSalvarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarInfo.Font = new System.Drawing.Font("Myanmar Text", 14F);
            this.btnSalvarInfo.ForeColor = System.Drawing.Color.Silver;
            this.btnSalvarInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarInfo.Location = new System.Drawing.Point(38, 352);
            this.btnSalvarInfo.Name = "btnSalvarInfo";
            this.btnSalvarInfo.Size = new System.Drawing.Size(132, 35);
            this.btnSalvarInfo.TabIndex = 169;
            this.btnSalvarInfo.Text = "Salvar";
            this.btnSalvarInfo.UseVisualStyleBackColor = false;
            this.btnSalvarInfo.Click += new System.EventHandler(this.btnSalvarInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel20);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.txtTel2);
            this.groupBox1.Controls.Add(this.panel14);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtNun_banco);
            this.groupBox1.Controls.Add(this.panel12);
            this.groupBox1.Controls.Add(this.txtIban);
            this.groupBox1.Controls.Add(this.txtLocalizacao);
            this.groupBox1.Controls.Add(this.panel19);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtBanco);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.txtNif);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(38, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 285);
            this.groupBox1.TabIndex = 168;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Sistema";
            // 
            // panel20
            // 
            this.panel20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel20.Location = new System.Drawing.Point(104, 275);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(407, 2);
            this.panel20.TabIndex = 156;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel9.Location = new System.Drawing.Point(104, 191);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(407, 2);
            this.panel9.TabIndex = 147;
            // 
            // txtTel2
            // 
            this.txtTel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel2.BackColor = System.Drawing.SystemColors.Control;
            this.txtTel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.txtTel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtTel2.Location = new System.Drawing.Point(104, 254);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(407, 20);
            this.txtTel2.TabIndex = 154;
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel14.Location = new System.Drawing.Point(104, 218);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(407, 2);
            this.panel14.TabIndex = 147;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label17.Location = new System.Drawing.Point(9, 254);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 27);
            this.label17.TabIndex = 155;
            this.label17.Text = "Tel2:";
            // 
            // txtNun_banco
            // 
            this.txtNun_banco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNun_banco.BackColor = System.Drawing.SystemColors.Control;
            this.txtNun_banco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNun_banco.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.txtNun_banco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtNun_banco.Location = new System.Drawing.Point(104, 170);
            this.txtNun_banco.Name = "txtNun_banco";
            this.txtNun_banco.Size = new System.Drawing.Size(407, 20);
            this.txtNun_banco.TabIndex = 145;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel12.Location = new System.Drawing.Point(104, 75);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(407, 2);
            this.panel12.TabIndex = 153;
            // 
            // txtIban
            // 
            this.txtIban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIban.BackColor = System.Drawing.SystemColors.Control;
            this.txtIban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIban.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.txtIban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtIban.Location = new System.Drawing.Point(104, 197);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(407, 20);
            this.txtIban.TabIndex = 145;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalizacao.BackColor = System.Drawing.SystemColors.Control;
            this.txtLocalizacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocalizacao.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.txtLocalizacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtLocalizacao.Location = new System.Drawing.Point(104, 54);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(407, 20);
            this.txtLocalizacao.TabIndex = 151;
            // 
            // panel19
            // 
            this.panel19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel19.Location = new System.Drawing.Point(104, 246);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(407, 2);
            this.panel19.TabIndex = 156;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(9, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 27);
            this.label9.TabIndex = 152;
            this.label9.Text = "Localização:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(9, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 27);
            this.label11.TabIndex = 146;
            this.label11.Text = "IBAN:";
            // 
            // txtTel1
            // 
            this.txtTel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel1.BackColor = System.Drawing.SystemColors.Control;
            this.txtTel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.txtTel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtTel1.Location = new System.Drawing.Point(104, 225);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(407, 20);
            this.txtTel1.TabIndex = 154;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(9, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 27);
            this.label6.TabIndex = 146;
            this.label6.Text = "Nº Banco:";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel8.Location = new System.Drawing.Point(104, 161);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(407, 2);
            this.panel8.TabIndex = 144;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label16.Location = new System.Drawing.Point(9, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 27);
            this.label16.TabIndex = 155;
            this.label16.Text = "Tel1:";
            // 
            // txtBanco
            // 
            this.txtBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBanco.BackColor = System.Drawing.SystemColors.Control;
            this.txtBanco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBanco.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.txtBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtBanco.Location = new System.Drawing.Point(104, 140);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(407, 20);
            this.txtBanco.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(9, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 27);
            this.label5.TabIndex = 143;
            this.label5.Text = "Banco:";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel7.Location = new System.Drawing.Point(104, 131);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(407, 2);
            this.panel7.TabIndex = 141;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtEmail.Location = new System.Drawing.Point(104, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(407, 20);
            this.txtEmail.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
            this.label4.TabIndex = 140;
            this.label4.Text = "Email:";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel6.Location = new System.Drawing.Point(104, 102);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(407, 2);
            this.panel6.TabIndex = 138;
            // 
            // txtNif
            // 
            this.txtNif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNif.BackColor = System.Drawing.SystemColors.Control;
            this.txtNif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNif.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.txtNif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtNif.Location = new System.Drawing.Point(104, 81);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(407, 20);
            this.txtNif.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 27);
            this.label3.TabIndex = 137;
            this.label3.Text = "NIF:";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel5.Location = new System.Drawing.Point(104, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(407, 2);
            this.panel5.TabIndex = 135;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtNome.Location = new System.Drawing.Point(104, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(407, 20);
            this.txtNome.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 27);
            this.label1.TabIndex = 134;
            this.label1.Text = "Nome:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 14);
            this.panel2.TabIndex = 13;
            // 
            // pnBackUp
            // 
            this.pnBackUp.Controls.Add(this.btnOperar);
            this.pnBackUp.Controls.Add(this.groupBox2);
            this.pnBackUp.Controls.Add(this.gbxDomingo);
            this.pnBackUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackUp.Location = new System.Drawing.Point(0, 47);
            this.pnBackUp.Name = "pnBackUp";
            this.pnBackUp.Size = new System.Drawing.Size(605, 389);
            this.pnBackUp.TabIndex = 14;
            // 
            // btnOperar
            // 
            this.btnOperar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btnOperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperar.Font = new System.Drawing.Font("Myanmar Text", 14F);
            this.btnOperar.ForeColor = System.Drawing.Color.Silver;
            this.btnOperar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOperar.Location = new System.Drawing.Point(26, 302);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(110, 35);
            this.btnOperar.TabIndex = 136;
            this.btnOperar.Text = "Exportar";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbImportar);
            this.groupBox2.Controls.Add(this.rbExportar);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Location = new System.Drawing.Point(26, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 65);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // rbImportar
            // 
            this.rbImportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbImportar.AutoSize = true;
            this.rbImportar.Depth = 0;
            this.rbImportar.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbImportar.Location = new System.Drawing.Point(237, 23);
            this.rbImportar.Margin = new System.Windows.Forms.Padding(0);
            this.rbImportar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbImportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbImportar.Name = "rbImportar";
            this.rbImportar.Ripple = true;
            this.rbImportar.Size = new System.Drawing.Size(175, 30);
            this.rbImportar.TabIndex = 36;
            this.rbImportar.Text = "Importar base de dados ";
            this.rbImportar.UseVisualStyleBackColor = true;
            this.rbImportar.CheckedChanged += new System.EventHandler(this.rbImportar_CheckedChanged);
            // 
            // rbExportar
            // 
            this.rbExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbExportar.AutoSize = true;
            this.rbExportar.Checked = true;
            this.rbExportar.Depth = 0;
            this.rbExportar.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbExportar.Location = new System.Drawing.Point(10, 23);
            this.rbExportar.Margin = new System.Windows.Forms.Padding(0);
            this.rbExportar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbExportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbExportar.Name = "rbExportar";
            this.rbExportar.Ripple = true;
            this.rbExportar.Size = new System.Drawing.Size(174, 30);
            this.rbExportar.TabIndex = 35;
            this.rbExportar.TabStop = true;
            this.rbExportar.Text = "Exportar base de dados";
            this.rbExportar.UseVisualStyleBackColor = true;
            this.rbExportar.CheckedChanged += new System.EventHandler(this.rbExportar_CheckedChanged);
            // 
            // gbxDomingo
            // 
            this.gbxDomingo.Controls.Add(this.lbCaminho);
            this.gbxDomingo.Controls.Add(this.panel1);
            this.gbxDomingo.Controls.Add(this.label2);
            this.gbxDomingo.Controls.Add(this.txtCaminho);
            this.gbxDomingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.gbxDomingo.ForeColor = System.Drawing.Color.DarkGray;
            this.gbxDomingo.Location = new System.Drawing.Point(26, 87);
            this.gbxDomingo.Name = "gbxDomingo";
            this.gbxDomingo.Size = new System.Drawing.Size(567, 191);
            this.gbxDomingo.TabIndex = 174;
            this.gbxDomingo.TabStop = false;
            this.gbxDomingo.Text = "Criar cópia de segurança";
            // 
            // lbCaminho
            // 
            this.lbCaminho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCaminho.AutoSize = true;
            this.lbCaminho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCaminho.Enabled = false;
            this.lbCaminho.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaminho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.lbCaminho.Location = new System.Drawing.Point(507, 56);
            this.lbCaminho.Name = "lbCaminho";
            this.lbCaminho.Size = new System.Drawing.Size(39, 36);
            this.lbCaminho.TabIndex = 157;
            this.lbCaminho.Text = "...";
            this.lbCaminho.Click += new System.EventHandler(this.lbCaminho_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel1.Location = new System.Drawing.Point(109, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 2);
            this.panel1.TabIndex = 156;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 155;
            this.label2.Text = "Localização:";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminho.BackColor = System.Drawing.SystemColors.Control;
            this.txtCaminho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaminho.Enabled = false;
            this.txtCaminho.Font = new System.Drawing.Font("Microsoft YaHei", 10.25F);
            this.txtCaminho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.txtCaminho.Location = new System.Drawing.Point(109, 71);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(399, 19);
            this.txtCaminho.TabIndex = 154;
            // 
            // fn_farmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.pnBackUp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnBarraTitulo);
            this.Controls.Add(this.pnConfigure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fn_farmacia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fn_farmacia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_farmacia_FormClosing);
            this.Load += new System.EventHandler(this.fn_farmacia_Load);
            this.pnBarraTitulo.ResumeLayout(false);
            this.pnBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            this.pnConfigure.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnBackUp.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxDomingo.ResumeLayout(false);
            this.gbxDomingo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBarraTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pcClose;
        private System.Windows.Forms.Panel pnConfigure;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnBackUp;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNun_banco;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRadioButton rbImportar;
        private MaterialSkin.Controls.MaterialRadioButton rbExportar;
        private System.Windows.Forms.GroupBox gbxDomingo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label lbCaminho;
    }
}