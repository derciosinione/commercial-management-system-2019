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
    public partial class fn_categorias : Form
    {
        dtoCategorias c = new dtoCategorias();
        int id = 0;
        public fn_categorias()
        {
            InitializeComponent();
        }


        private void operar()
        {
            if (btnOperar.Text == "Cadastrar")
            {
                c.inserirCategoria(txtCategorias.Text);
            }
            else
            {
                c.editarCategoria(id, txtCategorias.Text);
            }
            editar(false);
            dgvCategorias.DataSource = c.tbCategorias("");
        }
        private void editar(bool ops)
        {
            try
            {
                if (ops)
                {
                    id = (int)dgvCategorias.Rows[dgvCategorias.CurrentRow.Index].Cells[0].Value;
                    txtCategorias.Text = dgvCategorias.Rows[dgvCategorias.CurrentRow.Index].Cells[1].Value.ToString();
                    txtCategorias.SelectAll();
                    txtCategorias.Focus();
                    btnOperar.Text = "Editar";
                    btnCancelar.Text = "Cancelar";
                }
                else
                {
                    id = 0;
                    txtCategorias.Text = "";
                    btnOperar.Text = "Cadastrar";
                    btnCancelar.Text = "Editar";
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }


        private void fn_categorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForm.fnOpacidade.Hide();
        }

        private void fn_categorias_Load(object sender, EventArgs e)
        {
            try
            {
                dgvCategorias.DataSource = c.tbCategorias("");
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message,"Categorias",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow linha in dgvCategorias.Rows)
                {
                    if (linha.Cells[0].Selected == true || linha.Cells[1].Selected == true)
                    {
                        c.deleteCategoria((int)dgvCategorias.Rows[linha.Index].Cells[0].Value);
                    }
                }
                id = 0;
                dgvCategorias.DataSource = c.tbCategorias("");
                
            }
            catch (Exception)
            {
            }
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnCancelar.Text == "Editar")
            {
                editar(true);
            }
            else
            {
                editar(false);
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            operar();
        }

        private void txtCategorias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                operar();
            }
        }

        private void actualizarToolStrip_Click(object sender, EventArgs e)
        {
            dgvCategorias.DataSource = c.tbCategorias("");

        }

    }
}
