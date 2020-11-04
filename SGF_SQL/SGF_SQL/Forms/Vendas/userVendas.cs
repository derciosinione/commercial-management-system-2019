using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGF_SQL
{
    public partial class userVendas : UserControl
    {
        DTO.dtoVendas v = new DTO.dtoVendas();
        csForm t = new csForm();
        decimal  total_today = 0;
        
        public userVendas()
        {
            InitializeComponent();
        }


        #region (Metodos)
        private void dgvTamanho(DataGridView dgv)
        {
            try
            {
                dgv.Columns["id"].Width = 100;
                dgv.Columns["id_venda"].Visible = false;
                dgv.Columns["venda"].Width = 90;
                dgv.Columns["id_funcionario"].Visible = false;
                dgv.Columns["id_produto"].Visible = false;
                
            }
            catch (Exception)
            {
            }
        }
        private void updateTot(bool x)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (x)
                {
                    dgvTotVendas.DataSource = v.tbVendas("top", t.minLimite.ToString());
                }
                else
                {
                    if (txtPrPesquisa.Text != string.Empty)
                    {
                        dgvTotVendas.DataSource = v.tbVendas(cboxTipo.SelectedItem.ToString(), txtPrPesquisa.Text);
                    }
                    else
                    {
                        dgvTotVendas.DataSource = v.tbVendas("top", t.limite.ToString());
                    }
                }

                t.total = int.Parse(v.tbVendas("tot", null).Rows[0][0].ToString());
                lbTotal.Text =dgvTotVendas.Rows.Count + " de " + t.total;
                venda_Today();
                dgvTamanho(dgvTotVendas);
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
            }
        }

        private void Avancar(bool x)
        {
            try
            {
                t.Avancar(fn_login.form_menu,x);
                dgvTotVendas.DataSource = v.tbVendas("top", t.limite.ToString());
                t.total = int.Parse(v.tbVendas("tot", null).Rows[0][0].ToString());
                lbTotal.Text = dgvTotVendas.Rows.Count + " de " + t.total;
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
            }
        }
     
        private void venda_Today()
        {
            total_today = 0;
            foreach (DataGridViewRow item in dgvTotVendas.Rows)
            {
                if (item.Cells["venda"].Value.ToString() != "cancelada")
                {
                    total_today = total_today + decimal.Parse(item.Cells["total"].Value.ToString());
                }
            }
            lbTotal_vendas.Text = total_today + " kz";
        }
        private void CancelarVenda(int valor, string mensagem)
        {
            try
            {
                if (MessageBox.Show(mensagem + " " + dgvTotVendas.Rows[dgvTotVendas.CurrentRow.Index].Cells["id"].Value, "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                v.cancelarVenda(valor, (int)dgvTotVendas.Rows[dgvTotVendas.CurrentRow.Index].Cells["id"].Value);
                csForm.Mensagem(v.result, "Vendas", MessageBoxIcon.Information);
                updateTot(false);
            }
            catch (Exception)
            {
            }
        }

        #endregion

        private void userVendas_Load(object sender, EventArgs e)
        {
            try
            {
                updateTot(true);
                dgvTamanho(dgvTotVendas);
            
            }
            catch (Exception)
            {
                
            }
        }

        private void txtPrPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboxTipo.SelectedIndex < 0)
                {
                    cboxTipo.SelectedIndex = 1;
                }
                updateTot(false);
            }
            catch (Exception)
            {
            }
        }

        private void pcRefresh_Click(object sender, EventArgs e)
        {
            updateTot(true);
        }

        private void CancelarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelarVenda(1, "Desejas cancelar a(s) venda(s) com Id: ");
        }

        private void RefazerVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelarVenda(0, "Desejas refazer a(s) venda(s) com Id: ");
        }

        private void cboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrPesquisa.Focus();
        }

        private void pcSeguinte_Click(object sender, EventArgs e)
        {
            Avancar(true);
        }

        private void pcBack_Click(object sender, EventArgs e)
        {
            Avancar(false);
        }

        private void lbCaixa_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (csForm.user_login.Last().Value != "admin")
                {
                    csForm.Mensagem("Contacte o administrador ou gerente do sistema para completar esta acção", "Sem permição", MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow item in dgvTotVendas.Rows)
                {
                    if (item.Cells[0].Selected || item.Cells[1].Selected || item.Cells[2].Selected || item.Cells[3].Selected || item.Cells[4].Selected || item.Cells[5].Selected || item.Cells[6].Selected || item.Cells[7].Selected)
                    {
                        v.deleteVenda((int)dgvTotVendas.Rows[dgvTotVendas.CurrentRow.Index].Cells[0].Value);
                        if (!v.vf)
                        {
                        csForm.Mensagem(v.result, "Eliminar venda",MessageBoxIcon.Error);
                        break;
                        }
                    }
                }

                updateTot(false);
                if (v.vf)
                   csForm.Mensagem(v.result,"Eliminar venda",MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                csForm.Mensagem(v.result, "Eliminar venda", MessageBoxIcon.Error);                
            }
        }

        private void ImprimirtoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            fn_faturaVenda.print_id = (int)dgvTotVendas.Rows[dgvTotVendas.CurrentRow.Index].Cells["id"].Value;
            csForm.CallAdd(fn_login.form_menu, new fn_faturaVenda());
            this.Cursor = Cursors.Default;
        }
    }
}
