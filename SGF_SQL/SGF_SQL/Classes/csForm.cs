using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data;


namespace SGF_SQL
{
    public class csForm
    {
        public static DataGridViewImageColumn ColumnEliminar, ColumnEditar, ColumnSelecionar;
        public int limite = 30, minLimite = 30, total = 0; //13 
        public static Form fnOpacidade= new fn_Opacity();
        public static Form tela_sub_produtos;
        public static Form tela_categoria = new fn_categorias();
        public static DataTable tb_info=new DataTable();
        public static List<string> user_id = new List<string>();
        public static Dictionary<string, string> user_login = new Dictionary<string, string>();
        
        public static string Login(string id,string acesso)
        {
                if (!user_login.ContainsKey(id))
            {
                user_id.Add(id);
                user_login.Add(id, acesso);
            }
            return user_login[id];
        }

        public static void LogOut(string id)
        {
            if (user_login.ContainsKey(id))
            {
                user_id.Remove(id);
                user_login.Remove(id);
            }
        } 

        public static void CreateDgvColumnDeleteEdit(DataGridView dgv)
        {
            // Adicionar a coluna para eliminar os dados
            ColumnEliminar = new DataGridViewImageColumn();
            ColumnEditar = new DataGridViewImageColumn();
            // Adicionar imagem as colunas
            ColumnEditar.Image = global::SGF_SQL.Properties.Resources.icons8_Edit_50px;
            ColumnEliminar.Image = global::SGF_SQL.Properties.Resources.Trash_Can_64px;
            ColumnEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColumnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColumnEliminar.HeaderText = "Eliminar";
            ColumnEditar.HeaderText = "Editar";
            ColumnEliminar.ToolTipText = "Clica aqui para eliminar o registo";
            ColumnEditar.ToolTipText = "Clica aqui para editar o registo";
            ColumnEliminar.Name = "columnEliminar";
            ColumnEditar.Name = "columnEditar";
            dgv.Columns.Add(ColumnEditar);
            dgv.Columns.Add(ColumnEliminar);
            dgv.Columns["ColumnEditar"].Width = 55;
            dgv.Columns["ColumnEliminar"].Width = 66;
        }

        public static void CreateDgvColumnSelect(DataGridView dgv)
        {
            // Adicionar a coluna para eliminar os dados
            ColumnSelecionar = new DataGridViewImageColumn();
            // Adicionar imagem as colunas
            ColumnSelecionar.Image = global::SGF_SQL.Properties.Resources.Forward_Arrow_50pxk;
            ColumnSelecionar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColumnSelecionar.HeaderText = "Selecionar";
            ColumnSelecionar.ToolTipText = "Clica aqui para selecionar o produto";
            ColumnSelecionar.Name = "columnSelecionar";
            dgv.Columns.Add(ColumnSelecionar);
            dgv.Columns["columnSelecionar"].Width = 29;
        }

        public static void Mensagem(string mensagem,string titulo,MessageBoxIcon icon){
            
            MessageBox.Show(mensagem,titulo.ToUpper(),MessageBoxButtons.OK,icon);
        }

        public static void Mensagem1(bool x, string mensagem, string titulo)
        {
            if (x)
            {
                MessageBox.Show(mensagem, titulo.ToUpper(), MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show(mensagem, titulo.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void CallAdd(Form oldForm, Form new_form)
        {
            oldForm.Cursor = Cursors.WaitCursor;
            csForm.fnOpacidade.Show();
            new_form.ShowDialog();
            oldForm.Cursor = Cursors.Default;

        }

        public void Avancar(Form formulario,bool x)
        {
            try
            {
                formulario.Cursor = Cursors.WaitCursor;

                if (x)
                {
                    if (total > limite)
                    {
                        limite = ((total - limite) < minLimite) ? ((total - limite) + limite) : (limite + minLimite);
                    }
                }
                else
                {
                    if (total > minLimite)
                    {
                        limite = ((limite - minLimite) < minLimite) ? (limite - (limite - minLimite)) : (limite - minLimite); // Operador ternário, equivalente a if
                    }
                }

                formulario.Cursor= Cursors.Default;

            }
            catch (Exception)
            {
            }
        }
      
    }
}
