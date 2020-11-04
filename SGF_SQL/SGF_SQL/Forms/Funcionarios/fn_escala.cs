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
    public partial class fn_escala : Form
    {
        DTO.dtoFuncionarios f = new DTO.dtoFuncionarios();
        public static int id_f = 0;
        public static string nome_f;
        csForm t = new csForm();
        List<string> list_turno;
        public fn_escala()
        {
            InitializeComponent();
        }


        //======================================METODOS===================================================

        private void addList_turno()
        {
            list_turno = new List<string>();
            list_turno.Clear();
              for (int i = 0; i <7; i++)
                list_turno.Add("manhã");
        }
        private void Mostrar()
        {
            try
            {
                csForm.tb_info.Clear();
                csForm.tb_info = f.tbEscala("id", id_f.ToString());
                lbName_f.Text = nome_f;
            
                 addList_turno();

                 if (csForm.tb_info.Rows.Count > 0)
                 {
                     for (int i = 0; i < csForm.tb_info.Rows.Count; i++)
                    {
                        #region(Pegar Dados da escala)
                        if (csForm.tb_info.Rows[i]["dia"].ToString() == "domingo")
                        {
                            CBxDomingo.Checked = true;

                            dtpDom_Entrada.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_entrada"].ToString());
                            dtpDom_Saida.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_saida"].ToString());

                            if (csForm.tb_info.Rows[i]["turno"].ToString() == "manhã")
                            {
                                rbDomingo_M.Checked = true;
                                list_turno[0] = rbDomingo_M.Text;
                            }
                            else if (csForm.tb_info.Rows[i]["turno"].ToString() == "tarde")
                            {
                                rbDomingo_T.Checked = true;
                                list_turno[0] = rbDomingo_T.Text;
                            }
                            else
                            { 
                                rbDomingo_N.Checked = true;
                                list_turno[0] = rbDomingo_N.Text;
                            }

                        }
                        if (csForm.tb_info.Rows[i]["dia"].ToString() == "segunda feira")
                        {
                            CBxSegunda.Checked = true;

                            dtpSegun_Entrada.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_entrada"].ToString());
                            dtpSegun_Saida.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_saida"].ToString());

                            if (csForm.tb_info.Rows[i]["turno"].ToString() == "manhã")
                            {
                                rbSegunda_M.Checked = true;
                                list_turno[1] = rbSegunda_M.Text;
                            }
                            else if (csForm.tb_info.Rows[i]["turno"].ToString() == "tarde")
                            {
                                rbSegunda_T.Checked = true;
                                list_turno[1] = rbSegunda_T.Text;
                            }
                            else
                            {
                                rbSegunda_N.Checked = true;
                                list_turno[1] = rbSegunda_N.Text;
                            }
                        }
                        if (csForm.tb_info.Rows[i]["dia"].ToString() == "terca feira")
                        {
                            CBxTerca.Checked = true;

                            dtpTerc_Entrada.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_entrada"].ToString());
                            dtpTerc_Saida.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_saida"].ToString());

                            if (csForm.tb_info.Rows[i]["turno"].ToString() == "manhã")
                            {
                                rbTerca_M.Checked = true;
                                list_turno[2] = rbTerca_M.Text;
                            }
                            else if (csForm.tb_info.Rows[i]["turno"].ToString() == "tarde")
                            {
                                rbTerca_T.Checked = true;
                                list_turno[2] = rbTerca_T.Text;
                            }
                            else
                            {
                                rbTerca_N.Checked = true;
                                list_turno[2] = rbTerca_N.Text;
                            }
                        }
                        if (csForm.tb_info.Rows[i]["dia"].ToString() == "quarta feira")
                        {
                            CBxQuarta.Checked = true;

                            dtpQuart_Entrada.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_entrada"].ToString());
                            dtpQuart_Saida.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_saida"].ToString());

                            if (csForm.tb_info.Rows[i]["turno"].ToString() == "manhã")
                            {
                                rbQuarta_M.Checked = true;
                                list_turno[3] = rbQuarta_M.Text;
                            }
                            else if (csForm.tb_info.Rows[i]["turno"].ToString() == "tarde")
                            {
                                rbQuarta_T.Checked = true;
                                list_turno[3] = rbQuarta_T.Text;
                            }
                            else
                            {
                                rbQuarta_N.Checked = true;
                                list_turno[3] = rbQuarta_N.Text;
                            }
                        }
                        if (csForm.tb_info.Rows[i]["dia"].ToString() == "quinta feira")
                        {
                            CBxQuinta.Checked = true;

                            dtpQuint_Entrada.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_entrada"].ToString());
                            dtpQuint_Saida.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_saida"].ToString());

                            if (csForm.tb_info.Rows[i]["turno"].ToString() == "manhã")
                            {
                                rbQuinta_M.Checked = true;
                                list_turno[4] = rbQuinta_M.Text;
                            }
                            else if (csForm.tb_info.Rows[i]["turno"].ToString() == "tarde")
                            {
                                rbQuinta_T.Checked = true;
                                list_turno[4] = rbQuinta_T.Text;
                            }
                            else
                            {
                                rbQuinta_N.Checked = true;
                                list_turno[4] = rbQuinta_N.Text;
                            }
                        }
                        if (csForm.tb_info.Rows[i]["dia"].ToString() == "sexta feira")
                        {
                            CBxSexta.Checked = true;

                            dtpSext_Entrada.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_entrada"].ToString());
                            dtpSext_Saida.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_saida"].ToString());

                            if (csForm.tb_info.Rows[i]["turno"].ToString() == "manhã")
                            {
                                rbSexta_M.Checked = true;
                                list_turno[5] = rbSexta_M.Text;
                            }
                            else if (csForm.tb_info.Rows[i]["turno"].ToString() == "tarde")
                            {
                                rbSexta_T.Checked = true;
                                list_turno[5] = rbSexta_T.Text;
                            }
                            else 
                            { 
                                rbSexta_N.Checked = true;
                                list_turno[5] = rbSexta_N.Text;
                            }
                        }
                        if (csForm.tb_info.Rows[i]["dia"].ToString() == "sabado")
                        {
                            CBxSabado.Checked = true;

                            dtpSabad_Entrada.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_entrada"].ToString());
                            dtpSabad_Saida.Value = DateTime.Parse(csForm.tb_info.Rows[i]["hora_saida"].ToString());

                            if (csForm.tb_info.Rows[i]["turno"].ToString() == "manhã")
                            {
                                rbSabado_M.Checked = true;
                                list_turno[6] = rbSabado_M.Text;
                            }
                            else if (csForm.tb_info.Rows[i]["turno"].ToString() == "tarde")
                            {
                                rbSabado_T.Checked = true;
                                list_turno[6] = rbSabado_T.Text;
                            }
                            else
                            {
                                rbSabado_N.Checked = true;
                                list_turno[6] = rbSabado_N.Text;
                            }
                        }
                        #endregion
                    }
                }

                 csForm.tb_info.Clear();
                 panelAdd.BringToFront();
            }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message,"funcionarios",MessageBoxIcon.Warning);
            }
        }
        private void Salvar()
        {
            try
            {
                f.deleteEscala(id_f);
                if (!f.vf)
                {
                    csForm.Mensagem1(false, f.result, "funcionários");
                    return;
                }

                if (CBxDomingo.Checked)
                {
                    f.inserirEscala(id_f, CBxDomingo.Text, list_turno[0], dtpDom_Entrada.Value.ToShortTimeString(), dtpDom_Saida.Value.ToShortTimeString());
                    if (!f.vf)
                        csForm.Mensagem1(f.vf, f.result, CBxDomingo.Text);
                }
                if (CBxSegunda.Checked)
                {
                    f.inserirEscala(id_f, CBxSegunda.Text, list_turno[1], dtpSegun_Entrada.Value.ToShortTimeString(), dtpSegun_Saida.Value.ToShortTimeString());
                    if (!f.vf)
                        csForm.Mensagem1(f.vf, f.result, CBxSegunda.Text);
                }
                if (CBxTerca.Checked)
                {
                    f.inserirEscala(id_f, CBxTerca.Text, list_turno[2], dtpTerc_Entrada.Value.ToShortTimeString(), dtpTerc_Saida.Value.ToShortTimeString());
                    if (!f.vf)
                        csForm.Mensagem1(f.vf, f.result, CBxTerca.Text);
                }
                if (CBxQuarta.Checked)
                {
                    f.inserirEscala(id_f, CBxQuarta.Text, list_turno[3], dtpQuart_Entrada.Value.ToShortTimeString(), dtpQuart_Saida.Value.ToShortTimeString());
                    if (!f.vf)
                        csForm.Mensagem1(f.vf, f.result, CBxQuarta.Text);
                }
                if (CBxQuinta.Checked)
                {
                    f.inserirEscala(id_f, CBxQuinta.Text, list_turno[4], dtpQuint_Entrada.Value.ToShortTimeString(), dtpQuint_Saida.Value.ToShortTimeString());
                    if (!f.vf)
                        csForm.Mensagem1(f.vf, f.result, CBxQuinta.Text);
                }
                if (CBxSexta.Checked)
                {
                    f.inserirEscala(id_f, CBxSexta.Text, list_turno[5], dtpSext_Entrada.Value.ToShortTimeString(), dtpSext_Saida.Value.ToShortTimeString());
                    if (!f.vf)
                        csForm.Mensagem1(f.vf, f.result, CBxSexta.Text);
                }
                if (CBxSabado.Checked)
                {
                    f.inserirEscala(id_f, CBxSabado.Text, list_turno[6], dtpSabad_Entrada.Value.ToShortTimeString(), dtpSabad_Saida.Value.ToShortTimeString());
                    if (!f.vf)
                        csForm.Mensagem1(f.vf, f.result, CBxSabado.Text);
                }
                csForm.Mensagem1(f.vf, f.result, "funcionários");
            }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message, "funcioário", MessageBoxIcon.Warning);
            }
        }

        private void dgvTamanho(DataGridView dgv)
        {
            try
            {
                dgv.Columns["turno"].Width = 150;
                dgv.Columns["hora_entrada"].Width = 150;
                dgv.Columns["hora_Saida"].Width = 150;
                dgv.Columns["hora_entrada"].HeaderText = "hora de entrada";
                dgv.Columns["hora_Saida"].HeaderText = "hora de saida";
                dgv.Columns["nome"].HeaderText = "funcionário";
                dgv.Columns["dia"].HeaderText = "dia de serviço";

            }
            catch (Exception)
            {
            }
        }
        private void CalcularTot()
        {
            t.total = int.Parse(f.tbEscala("tot", null).Rows[0][0].ToString());
            lbTotal.Text = "Total: " + dgvEscala.Rows.Count + " de " + t.total;
            dgvTamanho(dgvEscala);
        }
        private void updateTot(bool x)
        {
            try
            {
                if (x)
                {
                    dgvEscala.DataSource = f.tbEscala("top", t.minLimite.ToString());
                }
                else
                {
                    if (txtPrPesquisa.Text != string.Empty)
                    {
                        dgvEscala.DataSource = f.tbEscala(cboxTipo.SelectedItem.ToString(), txtPrPesquisa.Text);
                    }
                    else
                    {
                        dgvEscala.DataSource = f.tbEscala("top", t.limite.ToString());
                    }
                }
                CalcularTot();

            }
            catch (Exception)
            {
            }
        }
        private void Avancar(bool x)
        {
            t.Avancar(this, x);
            dgvEscala.DataSource = f.tbEscala("top", t.limite.ToString());
            CalcularTot();
        }
        
        #region (Form configuraction)
        private void fn_escala_Load(object sender, EventArgs e)
        {
            if (id_f != 0) { 
                Mostrar();
                return;
            }

            panel_listar.BringToFront();
            updateTot(true);
            
        }
        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fn_escala_FormClosing(object sender, FormClosingEventArgs e)
        {
            id_f = 0;
            csForm.fnOpacidade.Hide();
        }
        #endregion

        #region (GroupBox Checked)
        private void CBxDomingo_CheckedChanged(object sender, EventArgs e)
        {
            gbxDomingo.Enabled=(CBxDomingo.Checked)? true : false;
        }
        private void CBxSegunda_CheckedChanged(object sender, EventArgs e)
        {
            gbxSegunda.Enabled = (CBxSegunda.Checked) ? true : false;
        }
        private void CBxTerca_CheckedChanged(object sender, EventArgs e)
        {
            gbxTerca.Enabled = (CBxTerca.Checked) ? true : false;
        }
        private void CBxQuarta_CheckedChanged(object sender, EventArgs e)
        {
            gbxQuarta.Enabled = (CBxQuarta.Checked) ? true : false;
        }
        private void CBxQuinta_CheckedChanged(object sender, EventArgs e)
        {
            gbxQuinta.Enabled = (CBxQuinta.Checked) ? true : false;
        }
        private void CBxSexta_CheckedChanged(object sender, EventArgs e)
        {
            gbxSexta.Enabled = (CBxSexta.Checked) ? true : false;
        }
        private void CBxSabado_CheckedChanged(object sender, EventArgs e)
        {
            gbxSabado.Enabled = (CBxSabado.Checked) ? true : false;
        }
        #endregion

        #region (RadioButton turno)
        //=============================DOMINGO====================================
        private void rbDomingo_M_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[0] = rbDomingo_M.Text;
        }
        private void rbDomingo_T_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[0] = rbDomingo_T.Text;
        }
        private void rbDomingo_N_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[0] = rbDomingo_N.Text;
        }
        
        //=============================SEGUNDA====================================
        private void rbSegunda_M_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[1] = rbSegunda_M.Text;
        }
        private void rbSegunda_T_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[1] = rbSegunda_T.Text;

        }
        private void rbSegunda_N_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[1] = rbSegunda_N.Text;
        }
        
        //=============================TERÇA====================================
        private void rbTerca_N_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[2] = rbTerca_N.Text;
        }
        private void rbTerca_T_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[2] = rbTerca_T.Text;
        }
        private void rbTerca_M_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[2] = rbTerca_M.Text;
        }
        
        //=============================QUARTA====================================
        private void rbQuarta_M_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[3] = rbQuarta_M.Text;
        }
        private void rbQuarta_N_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[3] = rbQuarta_N.Text;
        }
        private void rbQuarta_T_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[3] = rbQuarta_T.Text;
        }

        //=============================QUINTA====================================
        private void rbQuinta_N_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[4] = rbQuinta_N.Text;
        }
        private void rbQuinta_T_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[4] = rbQuinta_T.Text;

        }
        private void rbQuinta_M_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[4] = rbQuinta_M.Text;
        }

        //=========================SEXTA=========================================
        private void rbSexta_N_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[5] = rbSexta_N.Text;
        }
        private void rbSexta_T_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[5] = rbSexta_T.Text;
        }
        private void rbSexta_M_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[5] = rbSexta_M.Text;
        }
        //=========================SABADO=========================================
        private void rbSabado_M_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[6] = rbSabado_M.Text;
        }
        private void rbSabado_N_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[6] = rbSabado_N.Text;
        }
        private void rbSabado_T_CheckedChanged(object sender, EventArgs e)
        {
            if (csForm.tb_info.Rows.Count <= 0)
            list_turno[6] = rbSabado_T.Text;
        }
        #endregion
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void pcSeguinte_Click(object sender, EventArgs e)
        {
            Avancar(true);
        }

        private void pcBack_Click(object sender, EventArgs e)
        {
            Avancar(false);
        }

        private void txtPrPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboxTipo.SelectedIndex < 0)
                {
                    cboxTipo.SelectedIndex = 0;
                }
                updateTot(false);
            }
            catch (Exception)
            {
            }
        }

        private void cboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrPesquisa.Focus();
        }

        private void pcRefresh_Click(object sender, EventArgs e)
        {
            updateTot(true);
        }

    }
}
