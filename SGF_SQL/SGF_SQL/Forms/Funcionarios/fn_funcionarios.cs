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
    public partial class fn_funcionarios : Form
    {
        DTO.dtoFuncionarios f = new DTO.dtoFuncionarios();
        csForm t = new csForm();
        DataTable tbFuncionarios = new DataTable();
        int cont = 0, id_f=0;
        public fn_funcionarios()
        {
            InitializeComponent();

        }


        private void Mostrar_dados()
        {
            
            try
            {
                if (cont>= tbFuncionarios.Rows.Count && txtPrPesquisa.Text!=string.Empty)
                {
                    cont = tbFuncionarios.Rows.Count;
                    txtCont.Text = cont.ToString();
                }

                id_f = int.Parse(tbFuncionarios.Rows[cont][0].ToString());
                txtBI.Text = tbFuncionarios.Rows[cont][1].ToString();
                txtNome.Text = tbFuncionarios.Rows[cont][2].ToString();
                txtSexo.Text = tbFuncionarios.Rows[cont][3].ToString();
                txtData.Text = DateTime.Parse(tbFuncionarios.Rows[cont][4].ToString()).ToShortDateString();
                txtResidencia.Text = tbFuncionarios.Rows[cont][5].ToString();
                txtFormacao.Text = tbFuncionarios.Rows[cont][6].ToString();
                txtEmail.Text = tbFuncionarios.Rows[cont][7].ToString();
                txtBanco.Text = tbFuncionarios.Rows[cont][8].ToString();
                txtNum_banco.Text = tbFuncionarios.Rows[cont][9].ToString();
                txtIban.Text = tbFuncionarios.Rows[cont][10].ToString();
                txtAumento.Text = tbFuncionarios.Rows[cont][11].ToString();
                pcImagem.Image= (tbFuncionarios.Rows[cont]["imagem"].ToString()!=string.Empty) ?cssConvFoto.CvByteParaImage((byte[])tbFuncionarios.Rows[cont]["imagem"]) : null;
                txtEstado.Text = (tbFuncionarios.Rows[cont]["estado"].ToString() != string.Empty) ? tbFuncionarios.Rows[cont]["estado"].ToString() : "hablitado";
                txtCargo.Text = tbFuncionarios.Rows[cont]["cargo"].ToString();
                txtSalario.Text = tbFuncionarios.Rows[cont]["salario"].ToString();
                lbacesso.Text ="Nível de acesso: "+ tbFuncionarios.Rows[cont]["acesso"].ToString();
                toolStripMenuDesablitar.Text = (tbFuncionarios.Rows[cont]["estado"].ToString() == string.Empty) ? "Desablitar Funcionário" : "Hablitar Funcionário";

                if (tbFuncionarios.Rows[cont]["acesso"].ToString()==string.Empty || txtEstado.Text!="hablitado")
                    radioNao.Checked = true;    
                else
                    RadioSim.Checked = true;

                if (f.tbContacto(id_f).Rows.Count <= 0) return;
                txtTel1.Text = f.tbContacto(id_f).Rows[0][0].ToString();
                txtTel2.Text =(f.tbContacto(id_f).Rows.Count==2) ? f.tbContacto(id_f).Rows[1][0].ToString() : null;
                
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
                t.total = int.Parse(f.tbFuncionarios("tot", null).Rows[0][0].ToString());
                tbFuncionarios.Clear();
                if (x)
                {
                    tbFuncionarios = f.tbFuncionarios("top", t.minLimite.ToString());
                }
                else
                {
                    if (txtPrPesquisa.Text != string.Empty)
                    {
                        cont = 0;
                        tbFuncionarios = f.tbFuncionarios(cboxTipo.SelectedItem.ToString(), txtPrPesquisa.Text);
                        t.total = int.Parse(f.tbFuncionarios("tot", null).Rows[0][0].ToString());

                    }
                    else
                    {
                        tbFuncionarios = f.tbFuncionarios("top", t.limite.ToString());
                    }
                }
                lbTotal.Text = "Total: " + tbFuncionarios.Rows.Count + " de " + t.total;
                Mostrar_dados();
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
            }
        }
        
        private void takeMore()
        {
            if (cont + 1 >= t.limite)
            {
                t.limite = ((t.total - t.limite) < t.minLimite) ? ((t.total - t.limite) + t.limite) : (t.limite + t.minLimite);
                updateTot(false);
            }
        }
        private void Avancar(bool x)
        {
            try
            {
                if (x)
                {
                    if (cont + 1 == t.total) return;
                    takeMore();
                    cont++;
                }
                else
                {
                    if (cont == 0) return;
                    cont--;
                }
                txtCont.Text = (cont + 1).ToString();
                Mostrar_dados();
            }
            catch (Exception)
            {

            }
        }

        private void fn_funcionarios_Load(object sender, EventArgs e)
        {
            csRestricoes.add_Number(txtCont);
            updateTot(true);
        }
        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fn_funcionarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            fn_login.form_menu.Show();
        }

        private void toolAddFuncionario_Click(object sender, EventArgs e)
        {
            csForm.CallAdd(this,new fn_newFuncionarios());
            updateTot(true);
        }

        private void toolStripMenuCargos_Click(object sender, EventArgs e)
        {
            csForm.CallAdd(this,new fn_cargos());
        }

        private void toolStripMenuEscala_Click(object sender, EventArgs e)
        {
            csForm.CallAdd(this, new fn_escala());
         }

        private void pcSeguinte_Click(object sender, EventArgs e)
        {
            Avancar(true);
                       
        }

        private void pcBack_Click(object sender, EventArgs e)
        {
            Avancar(false);
        }

        private void txtCont_TextChanged(object sender, EventArgs e)
        {
            try
            {
               cont =int.Parse(txtCont.Text) - 1;
               takeMore();
               Mostrar_dados();
            }
            catch(Exception){

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
                    cboxTipo.SelectedIndex = 1;
                }
                updateTot(false);
            }
            catch (Exception)
            {
            }
        }

        private void toolStripMenuEditar_Click(object sender, EventArgs e)
        {
            fn_newFuncionarios.id_funcionario = id_f;
            csForm.CallAdd(this,new fn_newFuncionarios());
            updateTot(true);
        }
        private void toolStripMenuEscala1_Click(object sender, EventArgs e)
        {
            fn_escala.id_f = id_f;
            fn_escala.nome_f = tbFuncionarios.Rows[cont]["nome"].ToString();
            csForm.CallAdd(this, new fn_escala());
        }

        private void pcRefresh_Click(object sender, EventArgs e)
        {
            updateTot(true);
        }

        private void toolStripMenuDesablitar_Click(object sender, EventArgs e)
        {
            if (toolStripMenuDesablitar.Text == "Hablitar Funcionário") f.desablitar_Funcionario(1, id_f);
            else f.desablitar_Funcionario(0, id_f);
           
            if (f.vf && f.result!="")
                csForm.Mensagem(f.result, "funcionários", MessageBoxIcon.Information);
            else if(!f.vf)
                csForm.Mensagem(f.result,"funcionários",MessageBoxIcon.Error);

            
            updateTot(true);
        }


       }
}
