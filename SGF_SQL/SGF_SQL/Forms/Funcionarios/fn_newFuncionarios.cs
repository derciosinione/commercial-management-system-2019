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
    public partial class fn_newFuncionarios : Form
    {
        DTO.dtoFuncionarios f = new DTO.dtoFuncionarios();
        public static DataTable tbFuncionarios,tb_contacto;
        public static int id_funcionario = 0;
        string acesso;
        public fn_newFuncionarios()
        {
            InitializeComponent();
        }


        //=====================================METODOS===============================================
        private void Limpar()
        {
            try
            {
                txtBI.Clear();
                txtNome.Clear();
                txtFormacao.Clear();
                txtIban.Clear();
                txtBanco.Clear();
                txtNum_banco.Clear();
                txtAumento.Text = "0";
                txtTel1.Clear();
                txtTel2.Clear();
                txtResidencia.Clear();
                txtEmail.Clear();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }
        private void Cadastrar_funcionario()
        {
            acesso = (RadioSim.Checked) ? cbxAcesso.SelectedItem.ToString() : null;
            f.inserirFuncionario(txtBI.Text, txtNome.Text, cbxSexo.SelectedItem.ToString(), date_nascimento.Value.ToString("yyyy-MM-dd"), txtResidencia.Text, txtFormacao.Text, txtEmail.Text, txtBanco.Text, txtNum_banco.Text, txtIban.Text, decimal.Parse(txtAumento.Text), cssConvFoto.CvFotoToByte(pcImagem.Image), acesso, f.pegarIdCargo(cbxCargos.SelectedIndex), txtTel1.Text, txtTel2.Text);

            if (!f.vf)
            {
                csForm.Mensagem(f.result,"FUNCIONÁRIOS", MessageBoxIcon.Error);
                return;
            }
            csForm.Mensagem(f.result, "FUNCIONÁRIOS", MessageBoxIcon.Information);
            Limpar();
        }
        private void Editar_funcionario()
        {
            acesso = (RadioSim.Checked) ? cbxAcesso.SelectedItem.ToString() : "not";
            
            f.editarFuncionario(id_funcionario,txtBI.Text, txtNome.Text, cbxSexo.SelectedItem.ToString(), date_nascimento.Value.ToString("yyyy-MM-dd"), txtResidencia.Text, txtFormacao.Text, txtEmail.Text, txtBanco.Text, txtNum_banco.Text, txtIban.Text, decimal.Parse(txtAumento.Text), cssConvFoto.CvFotoToByte(pcImagem.Image), acesso, f.pegarIdCargo(cbxCargos.SelectedIndex), txtTel1.Text, txtTel2.Text);

            if (!f.vf)
            {
                csForm.Mensagem(f.result, "FUNCIONÁRIOS", MessageBoxIcon.Error);
                return;
            }
            csForm.Mensagem(f.result, "FUNCIONÁRIOS", MessageBoxIcon.Information);
        }
        private void Mostrar_dados()
        {

            try
            {
                tbFuncionarios = new DataTable();
                tb_contacto = new DataTable();
                tbFuncionarios = f.tbFuncionarios("id",id_funcionario.ToString());

                lbTitulo.Text = "Editar Funcionário";
                txtBI.Text = tbFuncionarios.Rows[0][1].ToString();
                txtNome.Text = tbFuncionarios.Rows[0][2].ToString();
                cbxSexo.SelectedItem = tbFuncionarios.Rows[0][3].ToString();
                date_nascimento.Value = DateTime.Parse(tbFuncionarios.Rows[0][4].ToString());
                txtResidencia.Text = tbFuncionarios.Rows[0][5].ToString();
                txtFormacao.Text = tbFuncionarios.Rows[0][6].ToString();
                txtEmail.Text = tbFuncionarios.Rows[0][7].ToString();
                txtBanco.Text = tbFuncionarios.Rows[0][8].ToString();
                txtNum_banco.Text = tbFuncionarios.Rows[0][9].ToString();
                txtIban.Text = tbFuncionarios.Rows[0][10].ToString();
                txtAumento.Text = decimal.Ceiling(decimal.Parse(tbFuncionarios.Rows[0][11].ToString())).ToString();
                pcImagem.Image = (tbFuncionarios.Rows[0]["imagem"].ToString() != string.Empty) ? cssConvFoto.CvByteParaImage((byte[])tbFuncionarios.Rows[0]["imagem"]) : null;
                cbxCargos.SelectedItem = (tbFuncionarios.Rows[0]["cargo"].ToString() != string.Empty) ? tbFuncionarios.Rows[0]["cargo"].ToString() : null;
                

                if (tbFuncionarios.Rows[0]["acesso"].ToString() == string.Empty)
                { 
                    radioNao.Checked = true;
                    groupBoxNivel.Visible = false;
                }
                else
                {
                    RadioSim.Checked = true;
                    groupBoxNivel.Visible = true;
                    cbxAcesso.SelectedItem = tbFuncionarios.Rows[0]["acesso"].ToString();
                }

                if (f.tbContacto(id_funcionario).Rows.Count <= 0) return;
                txtTel1.Text = f.tbContacto(id_funcionario).Rows[0][0].ToString();
                txtTel2.Text = (f.tbContacto(id_funcionario).Rows.Count == 2) ? f.tbContacto(id_funcionario).Rows[1][0].ToString() : null;

            }
            catch (Exception)
            {
            }
        }
      
        private void Iniciar_restricoes()
        {
            csRestricoes.add_Number(txtAumento);
            csRestricoes.add_Number(txtTel1);
            csRestricoes.add_Number(txtTel2);
            csRestricoes.add_Nome(txtNome);
            csRestricoes.add_Nome(txtFormacao);
            csRestricoes.add_Nome(txtResidencia);
            csRestricoes.add_Email(txtEmail);
            csRestricoes.add_txtUpper(txtBI);
            csRestricoes.add_txtUpper(txtBanco);
            csRestricoes.add_txtUpper(txtIban);
            csRestricoes.add_txtUpper(txtNum_banco);
            csRestricoes.add_Cmb_HANDELDE(cbxSexo);
            csRestricoes.add_Cmb_HANDELDE(cbxAcesso);
            csRestricoes.add_Cmb_HANDELDE(cbxCargos);

        }
        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fn_newFuncionarios_FormClosing(object sender, FormClosingEventArgs e)
        {
                id_funcionario = 0;   
                csForm.fnOpacidade.Hide();
        }
        private void fn_newFuncionarios_Load(object sender, EventArgs e)
        {
            try
            {
                Iniciar_restricoes();
                f.Cargos(cbxCargos);
                
                if (id_funcionario!=0)
                {
                    Mostrar_dados();
                    btnOperar.Text = "Editar";
                }
                else
                {
                    cbxCargos.SelectedIndex = 0;
                    cbxSexo.SelectedIndex = 0;
                    cbxAcesso.SelectedIndex = 2;
                    btnOperar.Text = "Cadastrar";

                }
            }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message,"Atenção", MessageBoxIcon.Warning);
            }
        }
        private void radioNao_CheckedChanged(object sender, EventArgs e)
        {
            acesso = "not";
            groupBoxNivel.Visible = false;
        }
        private void RadioSim_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAcesso.SelectedIndex<0)
            {
                cbxAcesso.SelectedIndex = 2;
                cbxAcesso.Select(0, 0);
            }
            groupBoxNivel.Visible = true;
        }
        private void pcImagem_DoubleClick(object sender, EventArgs e)
        {
            pcImagem.Image = null;
        }
        private void btnCarregarImg_Click(object sender, EventArgs e)
        {
            cssConvFoto.TakeFoto(pcImagem);
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (id_funcionario == 0) Cadastrar_funcionario();
            else Editar_funcionario();
            this.Cursor = Cursors.Default;
        }
    }
}
