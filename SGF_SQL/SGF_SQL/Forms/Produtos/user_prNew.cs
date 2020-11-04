using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace SGF_SQL
{
    public partial class user_prNew : UserControl
    {
        dtoProdutos p = new dtoProdutos();
        public static DataTable tb;
        public static int id_produto;
        public static decimal preco_retalho, preco_grosso;
        public user_prNew()
        {
            InitializeComponent();
        }


        private void Limpar()
        {
            txtProduto.Clear();
            txtCodigo.Clear();
            txtPreco.Text = "0";
            pcProduto.Image = null;
        }
        private void CadastrarProduto()
        {
            p.inserirproduto(txtCodigo.Text,p.pegarIdCategoria(cboxCategorias.SelectedIndex),
                    txtProduto.Text,
                    cssConvFoto.CvFotoToByte(pcProduto.Image),
                    decimal.Parse(txtPreco.Text));
            if (p.vf) { 
                MessageBox.Show(p.result, "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            else
            {
                MessageBox.Show(p.result, "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarProduto()
        {
            p.editarproduto(txtCodigo.Text,id_produto, p.pegarIdCategoria(cboxCategorias.SelectedIndex),
            txtProduto.Text,
            cssConvFoto.CvFotoToByte(pcProduto.Image),
            decimal.Parse(txtPreco.Text));
            if (p.vf) csForm.tela_sub_produtos.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCarregarImg_Click(object sender, EventArgs e)
        {
            cssConvFoto.TakeFoto(pcProduto);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (btnCadastrar.Text == "Cadastrar") CadastrarProduto();
                else EditarProduto();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ms)
            {
                MessageBox.Show("Form "+ms.Message);
            }
        }

        private void user_prNew_Load(object sender, EventArgs e)
        {
            try
            {
                p.categorias(cboxCategorias);
                
                cboxCategorias.SelectedIndex = 0;

                if (id_produto != 0)
                {
                    #region (Pegar dados para editar)
                    btnCadastrar.Text = "Editar";
                    cboxCategorias.SelectedItem = tb.Rows[0]["categoria"].ToString();
                    txtCodigo.Text = tb.Rows[0]["codigo"].ToString();
                    txtProduto.Text = tb.Rows[0]["nome"].ToString();
                    pcProduto.Image = (tb.Rows[0]["imagem"].ToString() != string.Empty) ? cssConvFoto.CvByteParaImage((byte[])tb.Rows[0]["imagem"]) : null;
                    txtPreco.Text = decimal.Ceiling(decimal.Parse(tb.Rows[0]["preco"].ToString())).ToString();

                    #endregion
                }

            }
            catch (Exception)
            {
               // MessageBox.Show(ms.Message);
            }
        }

        private void cboxCategorias_Click(object sender, EventArgs e)
        {
            p.categorias(cboxCategorias);
        }

        private void pcProduto_DoubleClick(object sender, EventArgs e)
        {
            pcProduto.Image = null;
        }
    }
}
