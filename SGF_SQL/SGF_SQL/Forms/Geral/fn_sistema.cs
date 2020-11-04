using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGF_SQL
{
    public partial class fn_farmacia : Form
    {
        DTO.dtoFarmacia f = new DTO.dtoFarmacia();
        public fn_farmacia(int tipo,string titulo)
        {
            InitializeComponent();
            try
            {
                if (tipo != 0)
            {
                pnBackUp.BringToFront();
                lbTitulo.Text = titulo;
                txtCaminho.Text = @"C:\SGC_BackUp\db_comercial_backup.bak";
                txtCaminho.Enabled = false;
                lbCaminho.Enabled = false;
                btnOperar.Text = "Exportar";
                return;
            }
            else
            {
        
                txtNome.Text = f.tbFarmacia().Rows[0]["nome"].ToString();
                txtLocalizacao.Text = f.tbFarmacia().Rows[0]["localizacao"].ToString();
                txtNif.Text = f.tbFarmacia().Rows[0]["NIF"].ToString();
                txtEmail.Text = f.tbFarmacia().Rows[0]["email"].ToString();
                txtBanco.Text = f.tbFarmacia().Rows[0]["banco"].ToString();
                txtNun_banco.Text = f.tbFarmacia().Rows[0]["num_banco"].ToString();
                txtIban.Text = f.tbFarmacia().Rows[0]["iban"].ToString();
                txtTel1.Text = f.tbFarmacia().Rows[0]["tel1"].ToString();
                txtTel2.Text = f.tbFarmacia().Rows[0]["tel2"].ToString();
                txtNome.Select(0, 0);
                pnConfigure.BringToFront();
            }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message,"Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void fn_farmacia_Load(object sender, EventArgs e)
        {
            
        }

        private void fn_farmacia_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForm.fnOpacidade.Hide();
        }

        private void btnSalvarInfo_Click(object sender, EventArgs e)
        {
            f.salvar_informacoes(txtNome.Text, txtLocalizacao.Text, txtNif.Text, txtEmail.Text, txtBanco.Text, txtNun_banco.Text, txtIban.Text, txtTel1.Text, txtTel2.Text);
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbCaminho_Click(object sender, EventArgs e)
        {
            try
            {
                
                    OpenFileDialog abrir = new OpenFileDialog();
                    abrir.Title = "SGF | Selecionar arquivo";

                    abrir.Filter = "arquivo (*.bak)|*.bak";

                    if (abrir.ShowDialog() == DialogResult.OK)
                    {
                        txtCaminho.Text = abrir.FileName;
                    }
                
            }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message,"Segurança",MessageBoxIcon.Warning);
            }
        }

        private void rbExportar_CheckedChanged(object sender, EventArgs e)
        {
            txtCaminho.Text = @"C:\SGF_BackUp\db_farmacia_backup.bak";
            txtCaminho.Enabled = false;
            lbCaminho.Enabled = false;
            btnOperar.Text = "Exportar";
        }

        private void rbImportar_CheckedChanged(object sender, EventArgs e)
        {
            txtCaminho.Clear();
            txtCaminho.Enabled = true;
            lbCaminho.Enabled = true;
            btnOperar.Text = "Importar";

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if(rbExportar.Checked){
                if (f.ExportarDB())
                    csForm.Mensagem("Backup feito com sucesso", "FARMÁCIA", MessageBoxIcon.Information);
                else
                    csForm.Mensagem("Erro ao efectuar backup, tente mais tarde", "FARMÁCIA", MessageBoxIcon.Warning);
                }
            else
            {
                csForm.Mensagem("Esta opção ainda não está disponivel nesta versão","Sgf", MessageBoxIcon.Information);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
