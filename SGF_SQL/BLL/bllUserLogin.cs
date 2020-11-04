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
    public class bllUserLogin
    {
        public DataTable tabelaS;
        
        public DataTable Login(string User, string Senha)
        {
            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand("exec sp_login '"+User+"','"+Senha+"'", cnx.Conect);
                cnx.Adp = new SqlDataAdapter(cnx.Cmd);
                cnx.Adp.Fill(tabelaS);
               
            }
            catch (Exception ms)
            {
                MessageBox.Show("Bll " + ms.Message, "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cnx.dbOnn(false); }
            return tabelaS;
        }
    }
    }