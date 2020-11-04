namespace SGF_SQL
{
    partial class fn_sub_produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fn_sub_produtos));
            this.pnBarraTitulo = new System.Windows.Forms.Panel();
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.user_prEntradas1 = new SGF_SQL.user_prEntradas();
            this.user_prNew1 = new SGF_SQL.user_prNew();
            this.pnBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBarraTitulo
            // 
            this.pnBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.pnBarraTitulo.Controls.Add(this.pcClose);
            this.pnBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnBarraTitulo.Name = "pnBarraTitulo";
            this.pnBarraTitulo.Size = new System.Drawing.Size(811, 47);
            this.pnBarraTitulo.TabIndex = 5;
            this.pnBarraTitulo.TabStop = true;
            // 
            // pcClose
            // 
            this.pcClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClose.Image = global::SGF_SQL.Properties.Resources.Cancel_64pxs;
            this.pcClose.Location = new System.Drawing.Point(763, 0);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(46, 45);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcClose.TabIndex = 15;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // user_prEntradas1
            // 
            this.user_prEntradas1.BackColor = System.Drawing.SystemColors.Control;
            this.user_prEntradas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_prEntradas1.Location = new System.Drawing.Point(0, 47);
            this.user_prEntradas1.Name = "user_prEntradas1";
            this.user_prEntradas1.Size = new System.Drawing.Size(811, 504);
            this.user_prEntradas1.TabIndex = 6;
            // 
            // user_prNew1
            // 
            this.user_prNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_prNew1.Location = new System.Drawing.Point(0, 0);
            this.user_prNew1.Name = "user_prNew1";
            this.user_prNew1.Size = new System.Drawing.Size(811, 551);
            this.user_prNew1.TabIndex = 7;
            // 
            // fn_sub_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 551);
            this.Controls.Add(this.user_prEntradas1);
            this.Controls.Add(this.pnBarraTitulo);
            this.Controls.Add(this.user_prNew1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fn_sub_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_sub_produtos_FormClosing);
            this.Load += new System.EventHandler(this.fn_sub_produtos_Load);
            this.pnBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBarraTitulo;
        private System.Windows.Forms.PictureBox pcClose;
        private user_prEntradas user_prEntradas1;
        private user_prNew user_prNew1;

    }
}