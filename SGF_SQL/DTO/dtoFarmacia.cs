using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace DTO
{
    public class dtoFarmacia
    {
        string pasta = @"C:\SGC_BackUp";
        string nome_backup = @"\db_comercial_backup.bak";

        BLL.bllFarmacia f = new BLL.bllFarmacia();
        public bool salvar_informacoes(string nome, string localizacao, string NIF1, string email,
string banco, string num_banco, string Iban, string tel1, string tel2)
        {
            try
            {
                if (nome == string.Empty)
                {
                    MessageBox.Show("Digite o nome do sistema", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (localizacao == string.Empty)
                {
                    MessageBox.Show("Digite o a localização do sistema", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                f.Salvar(nome, localizacao, NIF1, email, banco, num_banco, Iban, tel1, tel2);
                return true;

            }
            catch (Exception ms)
            {
                MessageBox.Show("DTO "+ms.Message,"Categorias",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ExportarDB()
        {
            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);
            if (f.Exportar_backup(pasta + nome_backup))
                return true;
            else return false;    
        }

        public void ImportarDB(string caminho)
        {
            f.Exportar_backup(pasta + nome_backup);
        }
        public DataTable tbFarmacia()
        {
            return f.AllFarmacia();
        }

    }
}
