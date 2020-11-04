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
    public partial class fn_perfil : Form
    {
        DTO.dtoFuncionarios f = new DTO.dtoFuncionarios();
        DataTable tbFuncionarios, tb_contacto;
        int id_f = 0;
        
        public fn_perfil()
        {
            InitializeComponent();
        }

        private void Mostrar_dados()
        {

            try
            {
                id_f = int.Parse(csForm.user_login.Last().Key.ToString());
                tbFuncionarios = new DataTable();
                tb_contacto = new DataTable();
                tbFuncionarios = f.tbFuncionarios("id", id_f.ToString());

                txtBI.Text = tbFuncionarios.Rows[0]["bi"].ToString();
                txtNome.Text = tbFuncionarios.Rows[0]["nome"].ToString();
                txtUserNameInfo.Text = tbFuncionarios.Rows[0]["nome_usuario"].ToString();
                txtSexo.Text = tbFuncionarios.Rows[0]["sexo"].ToString();
                txtData.Text = tbFuncionarios.Rows[0]["data_n"].ToString();
                txtResidencia.Text = tbFuncionarios.Rows[0]["residencia"].ToString();
                txtFormacao.Text = tbFuncionarios.Rows[0]["formacao"].ToString();
                txtEmail.Text = tbFuncionarios.Rows[0]["email"].ToString();
                txtBanco.Text = tbFuncionarios.Rows[0]["banco"].ToString();
                txtNum_banco.Text = tbFuncionarios.Rows[0]["num_banco"].ToString();
                txtIban.Text = tbFuncionarios.Rows[0]["iban"].ToString();
                lbacesso.Text = "Nível de acesso: " + tbFuncionarios.Rows[0]["acesso"].ToString();
                txtSalario.Text = tbFuncionarios.Rows[0]["salario"].ToString();
                txtAumento.Text = decimal.Ceiling(decimal.Parse(tbFuncionarios.Rows[0]["aumento"].ToString())).ToString();
                pcImagem.Image = (tbFuncionarios.Rows[0]["imagem"].ToString() != string.Empty) ? cssConvFoto.CvByteParaImage((byte[])tbFuncionarios.Rows[0]["imagem"]) : null;
                txtCargo.Text = (tbFuncionarios.Rows[0]["cargo"].ToString() != string.Empty) ? tbFuncionarios.Rows[0]["cargo"].ToString() : null;

                    if (f.tbContacto(id_f).Rows.Count <= 0) return;
                txtTel1.Text = f.tbContacto(id_f).Rows[0][0].ToString();
                txtTel2.Text = (f.tbContacto(id_f).Rows.Count == 2) ? f.tbContacto(id_f).Rows[1][0].ToString() : null;
                panel_infor.BringToFront();
            }
            catch (Exception)
            {
            }
        }
        private void Limpar()
        {
            txtOldKey.Clear();
            txtNewKey.Clear();
            txtConfirmar.Clear();
            btnSalvar.Enabled = false;
            txtNewKey.Enabled = false;
            txtConfirmar.Enabled = false;
        }
      
        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fn_perfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForm.fnOpacidade.Hide();
        }

        private void pcBack_Click(object sender, EventArgs e)
        {
            panel_infor.BringToFront();
            Limpar();
        }

        private void pcUser_Click(object sender, EventArgs e)
        {
            txtUserName.Text = txtUserNameInfo.Text;
            txtConfirmar.Text = "";
            txtNewKey.Text = "";
            panel_user.BringToFront();
        }

        private void fn_perfil_Load(object sender, EventArgs e)
        {
            Mostrar_dados();
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            if (txtNewKey.Text==txtConfirmar.Text)
            {
                btnSalvar.Enabled = true;
                lb_sms.Visible = false;
                return;
            }
            lb_sms.Visible = true;            
        }

        private void txtNewKey_TextChanged(object sender, EventArgs e)
        {
             if (txtNewKey.Text == txtConfirmar.Text)
            {
                btnSalvar.Enabled = true;
                return;
            }
             btnSalvar.Enabled = false;
            
        }

        private void txtOldKey_TextChanged(object sender, EventArgs e)
        {
            if (tbFuncionarios.Rows[0]["senha"].ToString() == txtOldKey.Text)
            {
                txtNewKey.Enabled = true;
                txtConfirmar.Enabled = true;
                btnSalvar.Enabled = true;
                return;
            }
            txtNewKey.Enabled = false;
            txtConfirmar.Enabled = false;
            btnSalvar.Enabled = false;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            f.trocarSenha(id_f, txtUserName.Text.Trim(), txtOldKey.Text, txtNewKey.Text, txtConfirmar.Text);
            csForm.Mensagem1(f.vf, f.result, "funcionários");
            if (f.vf) { 
                txtUserNameInfo.Text = txtUserName.Text;
                Limpar();
            }
        }

    }
}
