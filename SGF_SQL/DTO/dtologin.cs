using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BLL;

namespace DTO
{
    public class dtologin
    {
       
        bllCategorias c = new bllCategorias();
        public bool inserirCategoria(string categoria)
        {
            try
            {
                if (categoria == string.Empty)
                {
                    MessageBox.Show("Digite a categoria", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                c.Categoria = categoria;
                c.inserirCategoria();
                return true;

            }
            catch (Exception ms)
            {
                MessageBox.Show("DTO "+ms.Message,"Categorias",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }


        public bool editarCategoria(int id, string categoria)
        {
            try
            {
                if (categoria == string.Empty)
                {
               MessageBox.Show("Digite a categoria", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (id <= 0)
                {
                    MessageBox.Show("Id inválido", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                c.Id = id;
                c.Categoria = categoria;
                c.editarCategoria();
                return true;

            }
            catch (Exception ms)
            {
                MessageBox.Show("DTO "+ms.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool deleteCategoria(int id)
        {
            try
            {
                if (id <= 0)
                {
                    MessageBox.Show("Id inválido","Categorias",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return false;
                }
                c.Id = id;
                c.deleteCategoria();
                return true;

            }
            catch (Exception ms)
            {
                MessageBox.Show("DTO " + ms.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable tbCategorias(string buscar)
        {
            return c.AllCategorias(buscar);
        }

    }
}
