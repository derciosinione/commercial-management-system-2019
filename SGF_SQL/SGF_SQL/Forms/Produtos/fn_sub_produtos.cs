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
    public partial class fn_sub_produtos : Form
    {
        bool opacidadeE = false;
        public fn_sub_produtos(string tipo)
        {
            InitializeComponent();

            if (tipo=="entrada")
            {
                opacidadeE = true;
                user_prEntradas1.BringToFront();
            }
            else
            {
                user_prNew1.BringToFront();
                this.Width = 648;
                this.Height = 360;
            }
        }

        private void fn_sub_produtos_Load(object sender, EventArgs e)
        {
           
        }

        private void fn_sub_produtos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (opacidadeE)
                fn_Pr_inform.tela_opacidade.Hide();
            else
            csForm.fnOpacidade.Hide();
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
