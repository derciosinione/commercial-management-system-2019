using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DAL;

namespace BLL
{
    public class bllCategorias
    {
        public int Id {get; set;}
        public string Categoria {get; set;}

        public DataTable tabelaS;
        
        public bool inserirCategoria()
        {
            try
            {
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand("exec sp_categorias 0,'"+this.Categoria+"'", cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                MessageBox.Show("Categoria Cadastrada com sucesso","Categorias",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cnx.dbOnn(false);
                return true;
            
            }
            catch (Exception ms)
            {
                MessageBox.Show("bll " + ms.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool editarCategoria()
        {
            try
            {
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand("exec sp_categorias "+this.Id+",'" + this.Categoria + "'", cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                MessageBox.Show("Categoria editada com sucesso", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnx.dbOnn(false);
                return true;

            }
            catch (Exception ms)
            {
                MessageBox.Show("bll " + ms.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool deleteCategoria()
        {
            try
            {
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand("delete from categorias where id=" + this.Id + "", cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                cnx.dbOnn(false);
                return true;

            }
            catch (Exception ms)
            {
                MessageBox.Show("bll " + ms.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable AllCategorias(string Buscar)
        {
            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand("select * from categorias where nome like '"+Buscar+"%' order by id", cnx.Conect);
                cnx.Adp = new SqlDataAdapter(cnx.Cmd);
                cnx.Adp.Fill(tabelaS);
            }
            catch (Exception ms)
            {
                MessageBox.Show("Bll " + ms.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cnx.dbOnn(false); }
            return tabelaS;
        }


        public DataTable TocombolCategorias()
        {
            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand("select * from categorias order by nome", cnx.Conect);
                cnx.Adp = new SqlDataAdapter(cnx.Cmd);
                cnx.Adp.Fill(tabelaS);
            }
            catch (Exception ms)
            {
                MessageBox.Show("Bll " + ms.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cnx.dbOnn(false); }
            return tabelaS;
        }

        public ComboBox FullCombol(ComboBox cbx)
        {
            try
            {
                TocombolCategorias();
                cbx.Items.Clear();

                for (int i = 0; i < TocombolCategorias().Rows.Count; i++)
                {
                    cbx.Items.Add(TocombolCategorias().Rows[i][1]);
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show("Bll "+ ms.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cbx;
        }

        public int retornarId(int linha)
        {
            return (int)TocombolCategorias().Rows[linha][0];
        }
    }
    }