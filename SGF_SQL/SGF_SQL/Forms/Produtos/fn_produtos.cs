using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace SGF_SQL
{
    public partial class fn_produtos : Form
    {
        dtoProdutos p = new dtoProdutos();
        csForm t = new csForm();
        int indice;
        public static int id_produto = 0;


        public fn_produtos()
        {
            InitializeComponent();
        }

        #region (Metodos)
        private void MenuTrip(bool x)
        {
            try
            {
                foreach (DataGridViewRow item in dgvProdutos.Rows)
                {
                    if (item.Cells["id"].Selected || item.Cells["categoria"].Selected || item.Cells["nome"].Selected || item.Cells["stock"].Selected || item.Cells["preco"].Selected)
                    {
                        id_produto=(int)item.Cells["id"].Value;
                        if (x)
                        {
                            EditarLinha(id_produto);
                        }
                        else
                        {
                            EliminarLinha(id_produto);
                         }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void dgvTamanho(DataGridView dgv)
        {
            try
            {
                dgv.Columns["id"].Width = 50;
                dgv.Columns["nome"].ToolTipText = "nome do produto";
                dgv.Columns["categoria"].ToolTipText = "Categoria do produto";
                dgv.Columns["imagem"].Visible = false;
                dgv.Columns["codigo"].Visible = false;
                dgv.Columns["ColumnEditar"].Width = 55;
                dgv.Columns["ColumnEliminar"].Width = 66;

            }
            catch (Exception ms)
            {
                MessageBox.Show("dgv tamanho " + ms.Message);
            }
        }
        private void Mostrar_dados()
        {
            try
            {
                id_produto = (int)dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells["id"].Value;
                indice = (int)dgvProdutos.CurrentRow.Index;

            pcImagem.Image = (dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells["imagem"].Value.ToString() != string.Empty)
            ? cssConvFoto.CvByteParaImage((byte[])dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells["imagem"].Value) : null;

            }
            catch (Exception)
            {
            }
        }
        private void CalcularTot()
        {
            try
            {
                t.total = int.Parse(p.tbProdutos(true, "tot", null).Rows[0][0].ToString());
                lbTotal.Text = "Total: " + dgvProdutos.Rows.Count + " de " + t.total;

            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }
        private void updateTot(bool x)
        {
            try
            {
                if (x)
                {
                    dgvProdutos.DataSource = p.tbProdutos(true,"top", t.minLimite.ToString());
                }
                else
                {
                    if (txtPrPesquisa.Text!=string.Empty)
                    {
                        dgvProdutos.DataSource = p.tbProdutos(true, cboxTipo.SelectedItem.ToString(), txtPrPesquisa.Text);
                    }
                    else
                    {
                        dgvProdutos.DataSource = p.tbProdutos(true, "top", t.limite.ToString());
                    }
                }
                Mostrar_dados();
                CalcularTot();
            }
            catch (Exception)
            {
            }
        }
        private void Avancar(bool x)
        {
            try
            {
                t.Avancar(this, x);
                dgvProdutos.DataSource = p.tbProdutos(true, "top", t.limite.ToString());
                CalcularTot();
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
            }
        }
        private void EditarLinha(int id)
        {
            user_prNew.tb = new DataTable();
            user_prNew.id_produto= id;
            user_prNew.tb = p.tbProdutos(true,"id", id.ToString());
            CallAdd("produtos");
            dgvProdutos.Rows[indice].Selected = true;
        }
        private void EliminarLinha(int id)
        {
            p.deleteProduto(id, true);
            if (p.vf)
            {
                if (p.result != "")
                    csForm.Mensagem(p.result, "Eliminar Produto", MessageBoxIcon.Information);
                
                t.limite--;
                updateTot(false);
                dgvProdutos.Rows[0].Selected = false;
                pcImagem.Image = null;
            }
            else
            {
                csForm.Mensagem(p.result, "Eliminar Produto", MessageBoxIcon.Warning);
            }
        }
        private void CallAdd(string tipo)
        {
            this.Cursor = Cursors.WaitCursor;
            csForm.tela_sub_produtos = new fn_sub_produtos(tipo);
            csForm.fnOpacidade.Show();
            csForm.tela_sub_produtos.ShowDialog();
            this.Cursor = Cursors.Default;
        }
        private void MoreInformaction()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                id_produto = (int)dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells["id"].Value;
                fn_Pr_inform.id_produto = id_produto;
                csForm.tela_sub_produtos = new fn_Pr_inform();
                csForm.fnOpacidade.Show();
                csForm.tela_sub_produtos.ShowDialog();
                this.Cursor = Cursors.Default;
                updateTot(false);
            }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message, "Produtos", MessageBoxIcon.Warning);
            }
        }
        #endregion
        private void fn_produtos_Load(object sender, EventArgs e)
        {
            try
            {
                updateTot(true);
                csForm.CreateDgvColumnDeleteEdit(dgvProdutos);
                //if (dgvProdutos.Rows.Count > 0) dgvProdutos.Rows[0].Selected = false;
                dgvTamanho(dgvProdutos);
                groupBoxPesquisa.Show();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }

        private void fn_produtos_FormClosing(object sender, FormClosingEventArgs e)
        {
            fn_login.form_menu.Show();
        }

        private void toolCategoria_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor; ;
            csForm.fnOpacidade.Show();
            csForm.tela_categoria.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ToolVerProdutos_Click(object sender, EventArgs e)
        {
            panelProdutos.BringToFront();
        }

        private void toolAddProduto_Click(object sender, EventArgs e)
        {
            user_prNew.id_produto = 0;
            CallAdd("produtos");
            this.Cursor = Cursors.WaitCursor;
            updateTot(true);
            this.Cursor = Cursors.Default;

            
        }

        private void pcRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                updateTot(true);
                this.Cursor = Cursors.Default;

            }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message, "Produtos", MessageBoxIcon.Warning);
            }
        }

        private void cboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrPesquisa.Focus();
        }

        private void txtPrPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboxTipo.SelectedIndex < 0)
                {
                    cboxTipo.SelectedIndex = 3;
                }
                updateTot(false);
             }
            catch (Exception)
            {
            }
        }

        private void pcSeguinte_Click(object sender, EventArgs e)
        {
            Avancar(true);
        }

        private void pcBack_Click(object sender, EventArgs e)
        {
            Avancar(false);
        }
        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Mostrar_dados();

                // Pegar elemento para eliminar ou editar
                foreach (DataGridViewRow item in dgvProdutos.Rows)
                {
                    id_produto = (int)item.Cells["id"].Value;
                   
                    if (item.Cells["columnEliminar"].Selected == true)
                    {
                        if ((int)item.Cells["stock"].Value==0)
                        {
                            EliminarLinha(id_produto);   
                        }
                        else
                        {
                           csForm.Mensagem("Só é possível eliminar produtos sem stock","Atenºão",MessageBoxIcon.Warning);
                        }
                     }
                    else if (item.Cells["columnEditar"].Selected == true)
                    {
                        EditarLinha(id_produto);
                        updateTot(false);
                        dgvProdutos.Rows[0].Selected = false;
                        dgvProdutos.Rows[indice].Cells["nome"].Selected = true;
                    }
                }

                id_produto = (int)dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells["id"].Value;

            }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message, "Produtos", MessageBoxIcon.Warning);
            }
        }

        private void dgvProdutos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
            }
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MoreInformaction();            
        }

        private void maisInformaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoreInformaction();
        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuTrip(true);
            updateTot(false);
        }

        private void EliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MenuTrip(false);
        }

        private void panelProdutos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProdutos_KeyUp(object sender, KeyEventArgs e)
        {
            Mostrar_dados();
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            p.desativarProduto(id_produto, 1);
            updateTot(false);
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            p.desativarProduto(id_produto, 0);
            updateTot(false);
        }
    }
}
