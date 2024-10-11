using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NA57A1V\SQLEXPRESS;Initial Catalog=DBStudent;Integrated Security=True");
    }
}
