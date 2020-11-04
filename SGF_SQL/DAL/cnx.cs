using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class cnx
    {
        public static SqlConnection Conect { get; set; }
        public static SqlDataAdapter Adp { get; set; }
        public static SqlCommand Cmd { get; set; }

        public static void dbOnn(bool ligar)
        {
            if (ligar)
            {
                Conect = new SqlConnection(@"Data Source=DESKTOP-3IG06O9\SQLEXPRESS;Initial Catalog=db_comercial;Integrated Security=True");
                Adp = new SqlDataAdapter();
                Cmd = new SqlCommand();
            }
            else
            {
                Conect = new SqlConnection();
                Conect.Close();
                Conect.Dispose();
            }
        }
    }
}
