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
    public partial class fn_faturaVenda : Form
    {
        public static int print_id = 0;
        public fn_faturaVenda()
        {
            InitializeComponent();
        }

        private void fn_faturaVenda_Load(object sender, EventArgs e)
        {
            try
            {
                if (print_id<=0)
                {
                    csForm.Mensagem("O id inserido não e válido inválido", "Fatura", MessageBoxIcon.Warning);
                    return;
                }

                this.fatura_vendaTableAdapter.Fill(this.db_comercialDataSet.fatura_venda, print_id);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ms)
            {
                csForm.Mensagem1(false, ms.Message, "Fatura");
            }
            this.reportViewer1.RefreshReport();
        }

        private void fn_faturaVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForm.fnOpacidade.Hide();
        }
    }
}
