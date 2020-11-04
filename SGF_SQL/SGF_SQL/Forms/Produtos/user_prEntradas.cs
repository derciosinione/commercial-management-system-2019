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
    public partial class user_prEntradas : UserControl
    {
        dtoProdutos p = new dtoProdutos();
        public static DataTable tb;
        public static int id, id_produto;
        public static string tipo, nome;
        public user_prEntradas()
        {
            InitializeComponent();
        }


        private void Sms()
        {
            if (p.vf)
            {
                csForm.Mensagem(p.result,"Entrada de Produtos",MessageBoxIcon.Information);
                csForm.tela_sub_produtos.Close();
            }
            else
            {
                csForm.Mensagem(p.result, "Entrada de Produtos", MessageBoxIcon.Error);
            }
        }
        private void user_prEntradas_Load(object sender, EventArgs e)
        {
            txtProduto.Text = nome;
            date_validade.Value = DateTime.Now;
            if (tipo == "add")
            {
                txtProduto.Enabled = false;
                btnCadastrar.Text = "Cadastrar";
            }
            else if (tipo == "edit")
            {
                btnCadastrar.Text = "Editar";
                numericVolume.Value = (int)tb.Rows[0]["volume"];
                txtPreco.Text = decimal.Ceiling(((decimal)tb.Rows[0]["custus"])).ToString();
                date_fabricacao.Value = DateTime.Parse(tb.Rows[0]["data_fabricacao"].ToString());
                date_validade.Value = DateTime.Parse(tb.Rows[0]["data_validade"].ToString());
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (btnCadastrar.Text == "Cadastrar")
                {
                    p.inserirproduto_entrada(id_produto, (int)numericVolume.Value, date_fabricacao.Value.ToString("yyyy-MM-dd"), date_validade.Value.ToString("yyyy-MM-dd"), decimal.Parse(txtPreco.Text));
                }
                else
                {
                    p.editarproduto_entrada(id, id_produto, (int)numericVolume.Value, date_fabricacao.Value.ToString("yyyy-MM-dd"), date_validade.Value.ToString("yyyy-MM-dd"), decimal.Parse(txtPreco.Text));
                }
                Sms();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message,"Atenção",MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            csForm.tela_sub_produtos.Close();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
