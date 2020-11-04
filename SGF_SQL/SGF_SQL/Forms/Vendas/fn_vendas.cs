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
    public partial class fn_vendas : Form
    {
        DTO.dtoVendas v = new DTO.dtoVendas();
        public static Form tela_consulta =new fn_consultar_produto();
        public static DataTable tb;
        csForm t = new csForm();
        decimal total = 0, total_today=0;
        string tipo_pagamento;
        public fn_vendas()
        {
            InitializeComponent();
        }

        private void Inicializar_restricoes()
        {
            csRestricoes.add_Nome(txtCliente);
            csRestricoes.add_Number(txtPagamento);
        }
        public void fecharApp()
        {
            if (csForm.user_login.First().Value == "gerente" || csForm.user_login.First().Value == "admin")
            {
                fn_login.form_menu.Show();
                this.Close();
                return;
            }
            else
            {
                if (MessageBox.Show("Desejas sair do sistema?", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
            }
        }
        private void fn_vendas_Load(object sender, EventArgs e)
        {
            try
            {

                updateTot(true);
                tipo_pagamento = RadioDinheiro.Text;
                Start_tbVenda();
                panelVendas.BringToFront();
                Inicializar_restricoes();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }

        //==============================PANEL DE VENDAS===========================================
        #region (Vender)
        private void Start_tbVenda() {
            this.Cursor = Cursors.WaitCursor;
            tb = new DataTable();
            tb.Clear();
            tb.Columns.Add("Id");
            tb.Columns.Add("Produto");
            tb.Columns.Add("Quantidade");
            tb.Columns.Add("Preco");
            tb.Columns.Add("Total");

            for (int i = 0; i < 14; i++)
            {
              tb.Rows.Add();
            }
            dgvVendas.DataSource = tb;
            txtCliente.Clear();
            txtPagamento.Text = "0";
            txtTotal.Text = "0";
            txtTroco.Text = "0";
            total = 0;
            RadioDinheiro.Checked = true;
            fn_consultar_produto.c=0;
            fn_consultar_produto.id_selectd.Clear();
            this.Cursor = Cursors.Default;
            }
        private decimal CALCULAR()
        {
            try
            {
                if (decimal.Parse(txtPagamento.Text) >= decimal.Parse(txtTotal.Text))
                {
                    txtTroco.Text = ((decimal.Parse(txtPagamento.Text)) - (decimal.Parse(txtTotal.Text))).ToString();
                   }
                else
                {
                    txtTroco.Text = "0,00";
                }
            }
            catch (Exception)
            {
            }
            return ((decimal.Parse(txtPagamento.Text)) - (decimal.Parse(txtTotal.Text)));
        }
        private void TOTAL()
        {
            total = 0;
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (tb.Rows[i]["id"].ToString() != string.Empty)
                {
                   total = total + decimal.Parse(tb.Rows[i]["Total"].ToString());    
                }
            }
            txtTotal.Text = total.ToString();
            if (radioMulticaixa.Checked)
            {
                txtPagamento.Text = txtTotal.Text;
                txtTroco.Text = "0";
                txtPagamento.Enabled = false;
                tipo_pagamento = radioMulticaixa.Text;
         
            }
         }
        private void telaDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            panelVendas.BringToFront();
            this.Cursor = Cursors.Default;
        }
        private void radioMulticaixa_CheckedChanged(object sender, EventArgs e)
        {
            txtPagamento.Text = txtTotal.Text;
            txtTroco.Text = "0";
            txtPagamento.Enabled = false;
            tipo_pagamento = radioMulticaixa.Text;
         
        }
        private void RadioDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                tipo_pagamento = RadioDinheiro.Text;
                txtPagamento.Enabled = true;
                txtPagamento.Focus();
                txtPagamento.Text = "0";
                if (decimal.Parse(txtPagamento.Text) >= decimal.Parse(txtTotal.Text))
                {
                    txtTroco.Text = ((decimal.Parse(txtPagamento.Text)) - (decimal.Parse(txtTotal.Text))).ToString();
                }
                else
                {
                    txtTroco.Text = "0,00";
                }
            }
            catch (Exception)
            {
            }
            
        }
        private void txtPagamento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CALCULAR();
            }
            catch (Exception)
            {
                return;
            }
        }
        private void toolConsultarProduto_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            panelVendas.BringToFront();
            csForm.fnOpacidade.Show();
            tela_consulta.ShowDialog();
            this.Cursor = Cursors.Default;
            dgvVendas.DataSource = tb;
            TOTAL(); 
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                //======================= Se o valor pago não for suficiente retorna
                if (dgvVendas.Rows.Count <= 0) return;
                if (CALCULAR()<0)
                {
                    csForm.Mensagem("O valor pago não é suficiente para efectuar a compra","ATENÇÃO",MessageBoxIcon.Stop);
                    return;
                }

                this.Cursor = Cursors.WaitCursor;
                
                v.inserirPagamento((txtCliente.Text=="")?"CONSUMIDOR FINAL" : txtCliente.Text, decimal.Parse(txtTotal.Text), decimal.Parse(txtPagamento.Text),tipo_pagamento);
                this.Cursor = Cursors.Default;     

                //======================= Se o pagamento não for efectuado retorna
                if (!v.vf_pagamento)
                {
                    csForm.Mensagem(v.result,"ERRO",MessageBoxIcon.Stop);
                    return;
                }
                this.Cursor = Cursors.WaitCursor;        
                
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (tb.Rows[i]["id"].ToString() != string.Empty)
                    {

                        v.inserirVenda(int.Parse(tb.Rows[i]["Id"].ToString()),int.Parse(tb.Rows[i]["Quantidade"].ToString()),decimal.Parse(tb.Rows[i]["Preco"].ToString()),int.Parse(csForm.user_id[0]));

                        if (!v.vf)
                        {
                            csForm.Mensagem(v.result, "ERRO", MessageBoxIcon.Stop);
                            break;
                        }
                    }
                }

                    /*==============CHAMAR FORMULÁRIO DE IMPRESSÃO DE FATURA===================*/
                    fn_faturaVenda.print_id = int.Parse(v.lastId());
                    csForm.CallAdd(this,new fn_faturaVenda());
                    csForm.Mensagem(v.result, "Menu de vendas",MessageBoxIcon.Information);
                    Start_tbVenda();
                    this.Cursor = Cursors.Default;        
            }
            catch (Exception ms)
            {
                this.Cursor = Cursors.Default;        
                csForm.Mensagem(ms.Message,"",MessageBoxIcon.Warning);
            }
        }
        private void dgvVendas_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (total>0 && fn_consultar_produto.c>0)
                {
                    total = total - decimal.Parse(tb.Rows[dgvVendas.CurrentRow.Index]["Total"].ToString());
                    txtTotal.Text = total.ToString();
                    fn_consultar_produto.c--;
                    fn_consultar_produto.id_selectd.Remove(tb.Rows[dgvVendas.CurrentRow.Index]["id"].ToString());
                }
                
                tb.Rows.Add();
            }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message, "", MessageBoxIcon.Warning);
            }
        }
   
         #endregion
        //==============================LISTAR VENDAS===========================================
        #region (Mostrar)
        #region (Metodos)
        private void dgvTamanho(DataGridView dgv)
        {
            try
            {
                dgv.Columns["id"].Width = 100;
                dgv.Columns["id_venda"].Visible = false;
                dgv.Columns["id_produto"].Visible = false;
                dgv.Columns["id_funcionario"].Visible = false;
                dgv.Columns["funcionario"].Visible = false;
                
            }
            catch (Exception)
            {
            }
        }
        private void updateTot(bool x)
        {
            try
            {
                t.total = int.Parse(v.tbVendas_today(csForm.user_id[0], "tot", null).Rows[0][0].ToString());

                if (x)
                {
                    dgvTotVendas.DataSource = v.tbVendas_today(csForm.user_id[0], "top", t.minLimite.ToString());
                    lbTotal.Text = "Total: " + v.tbVendas_today(csForm.user_id[0], "top", t.minLimite.ToString()).Rows.Count + " de " + t.total;
                }
                else
                {
                    if (txtPrPesquisa.Text != string.Empty)
                    {
                        dgvTotVendas.DataSource = v.tbVendas_today(csForm.user_id[0], cboxTipo.SelectedItem.ToString(), txtPrPesquisa.Text);
                        t.total = int.Parse(v.tbVendas_today(csForm.user_id[0], "tot", null).Rows[0][0].ToString());
                    }
                    else
                    {
                        dgvTotVendas.DataSource = v.tbVendas_today(csForm.user_id[0], "top", t.limite.ToString());
                    }
                    lbTotal.Text = "Total: " + v.tbVendas_today(csForm.user_id[0], "top", t.limite.ToString()).Rows.Count + " de " + t.total;
                }
                venda_Today();
                //Mostrar_dados();
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
                if (item.Cells["venda"].Value.ToString()!="cancelada")
                {
                    total_today = total_today + decimal.Parse(item.Cells["total"].Value.ToString());
                }
            }
            lbTotal_vendas.Text = total_today+" kz";
        }
        private void CancelarVenda(int valor, string mensagem, string tipo)
        {
            try
            {
                if (MessageBox.Show(mensagem + " " + dgvTotVendas.Rows[dgvTotVendas.CurrentRow.Index].Cells["id"].Value, "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                if (csForm.user_id[0] != dgvTotVendas.Rows[dgvTotVendas.CurrentRow.Index].Cells["id_funcionario"].Value.ToString())
                {
                    csForm.Mensagem("Não tens permissão para "+ tipo.ToLower() +" esta venda", "Atenção", MessageBoxIcon.Warning);
                    return;
                }

                v.cancelarVenda(valor, (int)dgvTotVendas.Rows[dgvTotVendas.CurrentRow.Index].Cells["id"].Value);
                csForm.Mensagem(v.result, "Vendas", MessageBoxIcon.Information);
                updateTot(false);
            }
            catch (Exception)
            {
            }
        }
       
        #endregion

        private void toolListaVendas_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            panelListaVendas.BringToFront();
            updateTot(true);
            dgvTamanho(dgvTotVendas);
            this.Cursor = Cursors.Default;
        }


        #endregion
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
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message, "Produtos", MessageBoxIcon.Warning);
            }
        }
        private void pcRefresh_Click(object sender, EventArgs e)
        {
            updateTot(true);
        }
        private void CancelarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

               CancelarVenda(1, "Desejas cancelar a(s) venda(s) com Id: ","cancelar");
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }
        private void RefazerVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (csForm.user_id[0] != dgvTotVendas.Rows[dgvTotVendas.CurrentRow.Index].Cells["id_funcionario"].Value.ToString())
            {
                csForm.Mensagem("Não tens permissão para refazer esta venda", "Atenção", MessageBoxIcon.Warning);
                return;
            }
            CancelarVenda(0, "Desejas refazer a(s) venda(s) com Id: ","refazer");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString() + "  " + DateTime.Now.DayOfWeek.ToString();
        }
        private void pcClose_Click(object sender, EventArgs e)
        {
            fecharApp();
        }
        private void fn_vendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (csForm.user_login.First().Value == "normal")
            {
                Application.ExitThread();
            }
            else
            {
                fn_login.form_menu.Show();
            }
        }
        private void toolStripMenuEliminarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (csForm.user_login.Last().Value!="admin")
                {
                    csForm.Mensagem("Contacte o administrador do sistema para eliminar a venda","Sem permição",MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Deseja eliminar a venda selecionada?" + dgvTotVendas.Rows[dgvTotVendas.CurrentRow.Index].Cells["id"].Value, "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                v.deleteVenda((int)dgvTotVendas.Rows[dgvTotVendas.CurrentRow.Index].Cells["id"].Value);
                csForm.Mensagem(v.result, "Vendas", MessageBoxIcon.Information);
                updateTot(false);
            }
            catch (Exception)
            {
            }
        }
        private void pcLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                fn_login tela_login = new fn_login();
                tela_login.Show();
                this.Hide();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }
        private void pcUser_Click(object sender, EventArgs e)
        {
            csForm.CallAdd(this, new fn_perfil());
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Start_tbVenda();
        }
        private void ImprimirtoolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            fn_faturaVenda.print_id = (int)dgvTotVendas.Rows[dgvTotVendas.CurrentRow.Index].Cells["id"].Value;
            csForm.CallAdd(this, new fn_faturaVenda());
            this.Cursor = Cursors.Default;
        }
        private void pcMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pcBack_Click(object sender, EventArgs e)
        {
           
        }

        private void pcSeguinte_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            csForm.CallAdd(this, new fn_escala());
        }
    }
}
