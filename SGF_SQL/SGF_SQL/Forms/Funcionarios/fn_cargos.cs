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
    public partial class fn_cargos : Form
    {
        csForm t = new csForm();
        DTO.dtoFuncionarios f = new DTO.dtoFuncionarios();
        int id = 0;
        public fn_cargos()
        {
            InitializeComponent();
        }


        private void updateTot()
        {
            try
            {
                    if (txtPrPesquisa.Text != string.Empty)
                    {
                        dgvCargos.DataSource = f.tbCargos(cboxTipo.SelectedItem.ToString(), txtPrPesquisa.Text);
                    }
                    else
                    {
                        dgvCargos.DataSource = f.tbCargos("top", t.limite.ToString());
                    }
            }
            catch (Exception)
            {
            }
        }

        private void Eliminar()
        {
            try
            {
                foreach (DataGridViewRow linha in dgvCargos.Rows)
                {
                    if (linha.Cells[0].Selected || linha.Cells[1].Selected || linha.Cells[2].Selected)
                    {
                        f.deleteCargo((int)dgvCargos.Rows[linha.Index].Cells[0].Value);
                        if (!f.vf)
                        {
                            csForm.Mensagem(f.result, "Cargos", MessageBoxIcon.Stop);
                            return;
                        }
                    }
                }
                id = 0;
                updateTot();
            }
            catch (Exception)
            {
            }
        }
        private void operar()
        {
            this.Cursor = Cursors.WaitCursor;
            if (btnOperar.Text == "Cadastrar")
            {
                f.inserirCargo(txtCargo.Text, decimal.Parse(txtSalario.Text));
                txtCargo.Clear();
                txtSalario.Text = "0";
            }
            else
            {
                f.editarCargo(id,txtCargo.Text, decimal.Parse(txtSalario.Text));
                if (!f.vf) return;
                editar(false);
            }
            csForm.Mensagem(f.result, "Cargos", MessageBoxIcon.Information);
            this.Cursor = Cursors.Default;
            
        }
        private void editar(bool ops)
        {
            try
            {
                if (ops)
                {
                    id = (int)dgvCargos.Rows[dgvCargos.CurrentRow.Index].Cells[0].Value;
                    txtCargo.Text = dgvCargos.Rows[dgvCargos.CurrentRow.Index].Cells[1].Value.ToString();
                    txtSalario.Text = decimal.Ceiling(decimal.Parse(dgvCargos.Rows[dgvCargos.CurrentRow.Index].Cells[2].Value.ToString())).ToString();
                    txtCargo.SelectAll();
                    txtCargo.Focus();
                    btnOperar.Text = "Editar";
                    panelAdd.BringToFront();
                }
                else
                {
                    id = 0;
                    txtCargo.Text = "";
                    txtSalario.Text = "0";
                    btnOperar.Text = "Cadastrar";
                    updateTot();
                    panelListar.BringToFront();
                }
            }
            catch (Exception)
            {
            }
        }
        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fn_cargos_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForm.fnOpacidade.Hide();
        }

        private void pcBack_Click(object sender, EventArgs e)
        {
            editar(false);
            panelListar.BringToFront();
        }

        private void fn_cargos_Load(object sender, EventArgs e)
        {
            panelAdd.BringToFront();
            txtCargo.Focus();
            csRestricoes.add_Nome(txtCargo);
            csRestricoes.add_Number(txtSalario);
            csRestricoes.add_Cmb_HANDELDE(cboxTipo);
            updateTot();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            operar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCargo.Focus();
            panelAdd.BringToFront();
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void txtPrPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboxTipo.SelectedIndex < 0)
                {
                    cboxTipo.SelectedIndex = 1;
                }
                updateTot();
            }
            catch (Exception ms)
            {
                csForm.Mensagem(ms.Message, "Produtos", MessageBoxIcon.Warning);
            }
        }

        private void dgvCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCargos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editar(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar(true);
        }

        private void dgvCargos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Eliminar();
        }

    }
}
