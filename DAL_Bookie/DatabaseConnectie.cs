using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Bookie
{
    public class DatabaseConnectie
    {
        public SqlConnection connection
        {
            get { return new SqlConnection(connectionString);}
        }

        private const string connectionString = " ";
    }
}
