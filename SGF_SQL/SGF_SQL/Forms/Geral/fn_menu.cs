using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace SGF_SQL
{
    public partial class fn_menu : Form
    {
        dtoCategorias c = new dtoCategorias();
        public static Form form_selected;
        

        public fn_menu()
        {
            InitializeComponent();
        }


        public bool Restricao(string menu)
        {
            if (csForm.user_login.Last().Value == "gerente")
            {
                csForm.Mensagem("Somente o administrador do sistema pode entrar no menu de "+menu, "Sem permição",MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Chamar()
        {
            form_selected.Show();
            this.Hide();
            TabControl.SelectedIndex = 0;
        }
        public void fecharApp()
        {
            if (MessageBox.Show("Desejas sair do sistema?", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }


        private void fn_menu_Load(object sender, EventArgs e)
        {
            //this.produtosTableAdapter.Fill(this.db_farmaciaDataSet1.produtos);
        }

        private void fn_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
        
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
            if (TabControl.SelectedTab.Name=="tabProdutos")
            {
                if (Restricao("Produtos"))
                {
                    form_selected = new fn_produtos();
                    Chamar();   
                }
                TabControl.SelectedIndex = 0;
            }
            else if (TabControl.SelectedTab.Name=="tabFuncionarios")
            {
                if (Restricao("Funcionários"))
                {
                    form_selected = new fn_funcionarios();
                    Chamar();   
                }
                TabControl.SelectedIndex = 0;
            }
            else if (TabControl.SelectedTab.Name == "tabEstatistica")
            {
                //this.produtosTableAdapter.Fill(this.db_farmaciaDataSet1.produtos);
            }
            }
            catch (Exception)
            {
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString() + "  " + DateTime.Now.DayOfWeek.ToString();
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            fecharApp();
        }

        private void pcMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void telaDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            fn_vendas tela_venda = new fn_vendas();
            tela_venda.Show();
            this.Hide();
            this.Cursor = Cursors.Default;
        }

        private void pcLogOut_Click(object sender, EventArgs e)
        {
            fn_login tela_login = new fn_login();
            tela_login.Show();
            this.Hide();
        }

        private void pcUser_Click(object sender, EventArgs e)
        {
            csForm.CallAdd(this, new fn_perfil());
         }

        private void pcEscala_Click(object sender, EventArgs e)
        {
            csForm.CallAdd(this, new fn_escala());
        }

        private void pcServicos_Click(object sender, EventArgs e)
        {
            if (Restricao("Funcionários"))
            {
                csForm.CallAdd(this,new fn_cargos());
            }
        }

        private void pcCategorias_Click(object sender, EventArgs e)
        {
            if (Restricao("Funcionários"))
            {
                csForm.CallAdd(this, new fn_categorias());
            }
        }

        private void pcEstatistica_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 5;
        }

        private void pcBackUp_Click(object sender, EventArgs e)
        {
            csForm.CallAdd(this, new fn_farmacia(1,"Cópia de Segurança"));
        }
        private void pcConfigure_Click(object sender, EventArgs e)
        {
            if (Restricao("Funcionários"))
            {
                csForm.CallAdd(this, new fn_farmacia(0,"Menu de Configurações"));
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            csForm.CallAdd(this,new fn_estatistica("produtos"));
        }

        private void relatórioDeEntradaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csForm.CallAdd(this, new fn_estatistica("produtos_entrada"));
        }

        private void relatórioDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csForm.CallAdd(this, new fn_estatistica("funcionarios"));
        }

        private void toolStripAtualizar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            fn_menu menu = new fn_menu();
            menu.Show();
            fn_login.form_menu = menu;
            fn_login.form_menu.Hide();
            this.Refresh();
            //this.produtosTableAdapter.Fill(this.db_farmaciaDataSet1.produtos);
            this.Cursor = Cursors.Default;

        }

        private void relatórioMensalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csForm.CallAdd(this, new fn_estatistica("venda"));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            csForm.Mensagem("Esta opção ainda não está disponível nesta versão.","SGF",MessageBoxIcon.Information);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            csForm.Mensagem("Esta opção ainda não está disponível nesta versão.","SGF",MessageBoxIcon.Information);

        }       
    }
}
