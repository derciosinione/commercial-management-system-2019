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
    public partial class fn_Pr_inform : Form
    {
        dtoProdutos p = new dtoProdutos();
        public DataTable tb = new DataTable();
        public static Form tela_opacidade;
        csForm t = new csForm();
        int id, indice;
        public static int id_produto; 
        public fn_Pr_inform()
        {
            InitializeComponent();
        }

        private void IniciaLisar()
        {
            tb = p.tbProdutos(true,"id", id_produto.ToString());
            txtCodigo.Text = tb.Rows[0]["codigo"].ToString();
            txtId.Text = tb.Rows[0]["id"].ToString();
            txtProduto.Text = tb.Rows[0]["nome"].ToString();
            txtCategoria.Text = tb.Rows[0]["categoria"].ToString();
            txtStock.Text = tb.Rows[0]["stock"].ToString();
            txtPreco.Text = tb.Rows[0]["preco"].ToString();            
            pcProduto.Image = cssConvFoto.CvByteParaImage((byte[])tb.Rows[0]["imagem"]);
        }
        private void updateTot(bool x)
        {
            try
            {
                IniciaLisar();
                t.total = int.Parse(p.tbEntradas(id_produto,"tot", null).Rows[0][0].ToString());

                if (x)
                {
                    dgvPrEntrada.DataSource = p.tbEntradas(id_produto, "top", t.minLimite.ToString());
                    lbTotal.Text = "Total: " + p.tbEntradas(id_produto, "top", t.minLimite.ToString()).Rows.Count + " de " + t.total;

                }
                else
                {
                    if (txtPesquisa.Text!=string.Empty)
                    {
                      dgvPrEntrada.DataSource = p.tbEntradas(id_produto, cboxTipo.SelectedItem.ToString(), txtPesquisa.Text);
                      t.total = int.Parse(p.tbEntradas(id_produto, "tot", null).Rows[0][0].ToString());
                    }
                    else
                    {
                        dgvPrEntrada.DataSource = p.tbEntradas(id_produto, "top", t.limite.ToString());
                    }

                    lbTotal.Text = "Total: " + p.tbEntradas(id_produto, "top", t.limite.ToString()).Rows.Count + " de " + t.total;
                }

            }
            catch (Exception)
            {
            }
        }
        private void Avancar(bool x)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                t.total = int.Parse(p.tbEntradas(id_produto,"tot", null).Rows[0][0].ToString());

                if (x)
                {
                    if (t.total > t.limite)
                    {
                        t.limite = ((t.total - t.limite) < t.minLimite) ? ((t.total - t.limite) + t.limite) : (t.limite + t.minLimite);
                        lbTotal.Text = "Total: " + t.limite + " de " + t.total;
                    }
                }
                else
                {
                    if (t.total > t.minLimite)
                    {
                        t.limite = ((t.limite - t.minLimite) < t.minLimite) ? (t.limite - (t.limite - t.minLimite)) : (t.limite - t.minLimite); // Operador ternário, equivalente a if
                        lbTotal.Text = "Total: " + t.limite + " de " + t.total;
                    }
                }

                dgvPrEntrada.DataSource = p.tbEntradas(id_produto, "top", t.limite.ToString());
                this.Cursor = Cursors.Default;

            }
            catch (Exception)
            {
            }
        }
        private void EliminarLinha()
        {
            p.deleteProduto((int)dgvPrEntrada.Rows[dgvPrEntrada.CurrentRow.Index].Cells["id"].Value, false);
            if (p.vf)
            {
                csForm.Mensagem(p.result,"Entrada de Produtos",MessageBoxIcon.Information);
                t.limite--;
            }
            else
            {
                csForm.Mensagem(p.result, "Entrada de Produtos", MessageBoxIcon.Error);
            }
        }
        private void EditarLinha()
        {
            user_prEntradas.tb = new DataTable();
            user_prEntradas.tb = p.tbEntradas(id_produto,"id", id.ToString());
            ChamarForm("edit");

        }
        private void ChamarForm(string tipo)
        {
            this.Cursor = Cursors.WaitCursor;
            user_prEntradas.tipo = tipo;
            csForm.tela_sub_produtos = new fn_sub_produtos("entrada");            
            user_prEntradas.id = id;
            user_prEntradas.id_produto = int.Parse(txtId.Text);
            user_prEntradas.nome = txtProduto.Text;
            tela_opacidade = new fn_Opacity();
            tela_opacidade.Show();
            csForm.tela_sub_produtos.ShowDialog();
            this.Cursor = Cursors.Default;
        }
        private void fn_Pr_inform_Load(object sender, EventArgs e)
        {
            try
            {
                updateTot(true);
                csForm.CreateDgvColumnDeleteEdit(dgvPrEntrada);
                dgvPrEntrada.Columns["id_produto"].Visible = false;
                dgvPrEntrada.Columns["id"].Visible = false;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }
        private void fn_Pr_inform_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForm.fnOpacidade.Hide();
        }
        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pcAddprodutos_Click(object sender, EventArgs e)
        {
            ChamarForm("add");
            updateTot(true);
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboxTipo.SelectedIndex < 0)
                {
                    cboxTipo.SelectedIndex = 1;
                }

                this.Cursor = Cursors.WaitCursor;
                updateTot(false);
                this.Cursor = Cursors.Default;
            }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message,"",MessageBoxIcon.Error);
            }
        }
        private void dgvPrEntrada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)dgvPrEntrada.Rows[dgvPrEntrada.CurrentRow.Index].Cells["id"].Value;
                indice = (int)dgvPrEntrada.CurrentRow.Index;

                // Pegar elemento para eliminar ou editar
                foreach (DataGridViewRow item in dgvPrEntrada.Rows)
                {

                    if (item.Cells["columnEliminar"].Selected == true)
                    {
                        EliminarLinha();
                        if (p.vf)
                        {
                          updateTot(false);
                        }
                    }
                    else if (item.Cells["columnEditar"].Selected == true)
                    { 
                            EditarLinha();
                        
                        updateTot(false);
                        
                    }
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }

        }

        private void pcRefresh_Click(object sender, EventArgs e)
        {
            updateTot(true);
        }
    }
}
