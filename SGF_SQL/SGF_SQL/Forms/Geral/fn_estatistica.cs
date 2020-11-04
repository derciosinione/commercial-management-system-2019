using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SGF_SQL
{
    public partial class fn_estatistica : Form
    {
        public fn_estatistica(string tipo)
        {
            InitializeComponent();
            csRestricoes.add_Number(txtAno_entrada);
            csRestricoes.add_Number(txtMes_entrada);
            if (tipo == "produtos")
            {
                pn_produtos.BringToFront();
                //this.produtos1TableAdapter.Fill(this.db_farmaciaDataSet.produtos1);
                //this.reportViewer1.RefreshReport();   
            }
            else if (tipo == "produtos_entrada")
            {
                pn_produtos_entrada.BringToFront();
                //this.produtos_entradaTableAdapter.FillBy(this.db_farmaciaDataSet.produtos_entrada);
                //this.rp_Entrada_produtos.RefreshReport();
            }
            else if (tipo == "funcionarios")
            {
                pn_funcionarios.BringToFront();
                //this.funcionariosTableAdapter.Fill(this.db_farmaciaDataSet.funcionarios);
                //this.rp_funcionarios.RefreshReport();
            }
            else if (tipo == "venda")
            {
                pn_venda.BringToFront();
                //this.produtosTableAdapter.Fill(this.db_farmaciaDataSet.produtos);
                //this.rpV_vendas.RefreshReport();
            }
        }

        private void fn_estatistica_Load(object sender, EventArgs e)
        {
            }

        private void fn_estatistica_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForm.fnOpacidade.Hide();
        }

        private void btnPesquiEntrada_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtAno_entrada.Text=="" || txtMes_entrada.Text==""){
                    //this.produtos_entradaTableAdapter.FillBy(this.db_farmaciaDataSet.produtos_entrada);
                }
                else {
                    //this.produtos_entradaTableAdapter.Fill(this.db_farmaciaDataSet.produtos_entrada, decimal.Parse(txtMes_entrada.Text), decimal.Parse(txtAno_entrada.Text));
                }
              
                //this.produtosTableAdapter.Fill(this.db_farmaciaDataSet1.produtos);
                this.rp_Entrada_produtos.RefreshReport();

            }
            catch (Exception)
            {
            }
        }

        private void btnPesquVenda_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtAnoVenda.Text == "" || txtMesVenda.Text == "")
                {
                    txtAnoVenda.Clear();
                    txtMesVenda.Clear();
                    //this.produtosTableAdapter.Fill(this.db_farmaciaDataSet.produtos);
                }
                else
                {
                    //this.produtosTableAdapter.FillBy(this.db_farmaciaDataSet.produtos,decimal.Parse(txtMesVenda.Text),decimal.Parse(txtAnoVenda.Text));
                }
                this.rpV_vendas.RefreshReport();
            }
            catch (Exception)
            {
            }
        }

    }
}
