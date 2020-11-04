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
    public class bllFarmacia
    {
        string comando;
        public DataTable tabelaS;
        
        public bool Salvar(string nome, string localizacao,string NIF1,string email,
string banco,string num_banco,string Iban,string tel1,string tel2)
        {
            try
            {
                cnx.dbOnn(true);
                comando = "exec sp_sistema '" + nome + "','" + localizacao + "','" + NIF1 + "','" + email + "','" + banco + "','" + num_banco + "','" + Iban + "','" + tel1 + "','" + tel2 + "'";
                cnx.Cmd = new SqlCommand(comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                MessageBox.Show("informações alteradas com sucesso","SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally  {
                cnx.dbOnn(false);
            }
        }

        public bool Exportar_backup(string caminho)
        {
            try
            {
                cnx.dbOnn(true);
                comando = "backup database db_comercial to disk='"+caminho+"'";
                cnx.Cmd = new SqlCommand(comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                cnx.dbOnn(false);
                return true;
               
            }
            catch (Exception)
            {
                return false;            
            }
        }

        public void ImportarDB(string caminho)
        {
            try
            {
                comando = "RESTORE DATABASE [db_comercial] FROM  DISK ='" + caminho + "'";
                cnx.Cmd = new SqlCommand(comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                MessageBox.Show("Restauração feita com sucesso", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "SGC Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable AllFarmacia()
        {
            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand("select * from sistema", cnx.Conect);
                cnx.Adp = new SqlDataAdapter(cnx.Cmd);
                cnx.Adp.Fill(tabelaS);
            }
            catch (Exception ms)
            {
                MessageBox.Show("Bll " + ms.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cnx.dbOnn(false); }
            return tabelaS;
        }

    }
    }