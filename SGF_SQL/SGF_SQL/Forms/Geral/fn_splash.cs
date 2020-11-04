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
    public partial class fn_splash : Form
    {
        public fn_splash()
        {
            InitializeComponent();
        }

        private void fn_splash_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar.Value++;
            if (ProgressBar.Value >= 98)
            {
                timer1.Enabled = false;
                fn_login tela_login = new fn_login();
                tela_login.Show();
                this.Hide();
            }
           
        }

    }
}
