using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DTO
{
    public class dtoUserLogin
    {

        BLL.bllUserLogin l = new BLL.bllUserLogin();
        public DataTable tbLogin(string user,string senha)
        {
            return l.Login(user,senha);
        }


    }
}
