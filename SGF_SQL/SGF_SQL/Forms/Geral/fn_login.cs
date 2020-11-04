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
    public partial class fn_login : Form
    {
        public static fn_menu form_menu=new fn_menu();
        public static fn_vendas form_vendas = new fn_vendas();
        DTO.dtoUserLogin l = new DTO.dtoUserLogin();
        public static DataTable tblogin;
       
        //string id_login, acesso;
        public fn_login()
        {
            InitializeComponent();
        }

        private void Entrar()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                tblogin = new DataTable();
                tblogin.Clear();
                tblogin = l.tbLogin(txtUser.Text, txtPass.Text);
                csForm.user_id.Clear();
                csForm.user_login.Clear();

                if (tblogin.Rows.Count <= 0)
                {
                    csForm.Mensagem("Não conseguimos encontrar este usuário.\n Verifica o nome de usuário ou a senha inserida", "Login", MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (txtUser.Text != string.Empty)
                {
                    #region(Verificação)

                    if (tblogin.Rows[0][1].ToString() == txtUser.Text && tblogin.Rows[0][2].ToString() == txtPass.Text)
                    {
                        if (csForm.Login(tblogin.Rows[0][0].ToString(), tblogin.Rows[0][3].ToString()) == "admin" || csForm.Login(tblogin.Rows[0][0].ToString(), tblogin.Rows[0][3].ToString()) == "gerente")
                            form_menu.Show();
                        else if (csForm.Login(tblogin.Rows[0][0].ToString(), tblogin.Rows[0][3].ToString()) == "normal")
                            form_vendas.Show();

                        this.Hide();
                    }
                    else
                    {
                        csForm.Mensagem("Não conseguimos encontrar este usuário.\n Verifica o nome de usuário ou a senha inserida", "Login", MessageBoxIcon.Warning);
                    }

                    #endregion
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        
        }
        private void fn_login_Load(object sender, EventArgs e)
        {
          form_menu=new fn_menu();
          fn_vendas form_vendas = new fn_vendas();
        }

        private void fn_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Entrar();
            }
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        }
    }

