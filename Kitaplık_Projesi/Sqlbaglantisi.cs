using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kitaplık_Projesi
{
    internal class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-D0LP1EG;Initial Catalog=Kitaplık;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
