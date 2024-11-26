using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace eticaret_programi.classes
{
    public class sqlbaglanticlass
    {
        public static SqlConnection baglan = new SqlConnection(@"data source=MSI;initial catalog=final;integrated security=true");
        public static void CheckConnection(SqlConnection baglanti) 
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            else
            {

            }

        }
        

    }
}
