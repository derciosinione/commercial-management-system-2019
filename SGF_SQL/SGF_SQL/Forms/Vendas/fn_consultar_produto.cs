using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace SGF_SQL
{
    public partial class fn_consultar_produto : Form
    {
        DTO.dtoProdutos p = new DTO.dtoProdutos();
        public static DataGridViewImageColumn ColumnSelect;
        public static int id_produto, c=0;
        public static List<string> id_selectd = new List<string>();
        public fn_consultar_produto()
        {
            InitializeComponent();
        }


        private void Mostrar_dados()
        {
            id_produto = (int)dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells["id"].Value;

            pcImagem.Image = (dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells["imagem"].Value.ToString() != string.Empty)
            ? cssConvFoto.CvByteParaImage((byte[])dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells["imagem"].Value) : null;
        }

        private void dgvTamanho(DataGridView dgv)
        {
            try
            {
                dgv.Columns["id"].Width = 40;
                dgv.Columns["stock"].Width = 50;
                dgv.Columns["nome"].ToolTipText = "nome do produto";
                dgv.Columns["categoria"].ToolTipText = "Categoria do produto";
                dgv.Columns["imagem"].Visible = false;
                dgv.Columns["estado"].Visible = false;
                dgv.Columns["codigo"].Visible = false;
                
            }
            catch (Exception ms)
            {
                MessageBox.Show("dgv tamanho " + ms.Message);
            }
        }
        private void updateTot()
        {
            try
            {
                    if (txtPrPesquisa.Text != string.Empty)
                    {
                        dgvProdutos.DataSource = p.tbProdutos(false, cboxTipo.SelectedItem.ToString(), txtPrPesquisa.Text);
                     }
                    else
                    {
                        dgvProdutos.DataSource = p.tbProdutos(false, "top", "");
                    }
                Mostrar_dados();
            }
            catch (Exception)
            {
            }
        }
        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fn_consultar_produto_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForm.fnOpacidade.Hide();
        }
        private void fn_consultar_produto_Load(object sender, EventArgs e)
        {
            try
            {
                updateTot();
                csRestricoes.add_Number(txtQuantidade);
                if (!dgvProdutos.Columns.Contains("ColumnSelecionar"))
                {
                 csForm.CreateDgvColumnSelect(dgvProdutos);
                 dgvTamanho(dgvProdutos);
                }
                txtPrPesquisa.Focus();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }
        private void txtPrPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cboxTipo.SelectedIndex < 0)
                {
                    cboxTipo.SelectedIndex = 3;
                }
                updateTot();
            }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message, "Produtos", MessageBoxIcon.Warning);
            }

        }
        private void pcRefresh_Click(object sender, EventArgs e)
        {
            updateTot();
        }
        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Mostrar_dados();

                foreach (DataGridViewRow item in dgvProdutos.Rows)
                {
                    if (item.Cells["columnSelecionar"].Selected == true)
                    {
                        if (txtQuantidade.Text != "0")
                        {
                            if (int.Parse(txtQuantidade.Text) > (int)item.Cells["stock"].Value)
                            {
                                csForm.Mensagem("Não é possivel selecionar o produto.\n Stock inferior a quantidade especificada.", "Atenção", MessageBoxIcon.Warning);
                                return;
                            }
                            if (id_selectd.Contains(item.Cells["id"].Value.ToString()))
                            {
                                csForm.Mensagem("Este produto já foi selecionado.", "Atenção", MessageBoxIcon.Warning);
                                return;
                            }

                            // Passar os dados do produto selecionado na tabela de venda
                            id_selectd.Add(item.Cells["id"].Value.ToString());
                            fn_vendas.tb.Rows[c]["Id"] = item.Cells["id"].Value;
                            fn_vendas.tb.Rows[c]["Produto"] = item.Cells["nome"].Value;
                            fn_vendas.tb.Rows[c]["Quantidade"] = txtQuantidade.Text;
                            fn_vendas.tb.Rows[c]["Preco"] = item.Cells["preco"].Value;
                            fn_vendas.tb.Rows[c]["Total"] = (decimal.Parse(item.Cells["preco"].Value.ToString()) * decimal.Parse(txtQuantidade.Text));

                            c++;
                            if (c >= fn_vendas.tb.Rows.Count)
                            {
                                fn_vendas.tb.Rows.Add();
                            }

                            csForm.Mensagem(item.Cells["nome"].Value + " selecionado com sucesso", "Selecionar Produto", MessageBoxIcon.Information);

                        }
                        else
                        {
                            csForm.Mensagem("Informe a quantidade do produto a ser selecionado", "Atenção", MessageBoxIcon.Information);
                        }

                    }
                }
                }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message,"",MessageBoxIcon.Warning);
            }
        }
        private void dgvProdutos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Mostrar_dados();
            }
            catch (Exception)
            {
            }
        }

        private void RadioGrosso_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RadioRetalho_CheckedChanged(object sender, EventArgs e)
        {
            txtQuantidade.Focus();
        }

        private void cboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrPesquisa.Focus();
        }


    }
}
